using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PaperSystem.Entity;
using PaperSystem.Model;

namespace PaperSystem.View
{
    public partial class QuestionImport : Form
    {
        public QuestionImport()
        {
            InitializeComponent();
        }

        private void chooseFile_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "excel|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK){
                string filename = openDialog.FileName;
                DataTable ds = QuestionModel.GetQuestionsFromExcel(filename);
                BindSearchResult(ds);
            } 
        }

        public void BindSearchResult(DataTable ds)
        {
            DataGridView questionGridView = this.questionGridView;

            questionGridView.DataSource = ds;
            questionGridView.Refresh();
        }

        private void import_Click(object sender, System.EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = this.questionGridView.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("清先选择题目");
                return;
            }
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要导入所选择的" + rows.Count.ToString() + "道题目么？", "导入题库", messButton);
            if (dr == DialogResult.OK) {
                int success = 0;
                int faild = 0;

                for (int i = 0; i < rows.Count; i++ )
                {
                    string artical = rows[i].Cells["Artical"].Value.ToString();
                    ArticalEntity articalEntity = GetArticalIDByName(artical);

                    int type = Convert.ToInt16(rows[i].Cells["Type"].Value);
                    string questionInfo = rows[i].Cells["Question"].Value.ToString();

                    int paragraph = 0;
                    if (articalEntity != null)
                    {
                        if (type == 2)
                        {
                            paragraph = WordProcessModel.GuessParagraphEX(articalEntity.Content, questionInfo);
                        }
                        else
                        {
                            paragraph = WordProcessModel.GuessParagraph(articalEntity.Content, questionInfo);
                        }
                    }

                    QuestionBaseEntity question = new QuestionBaseEntity()
                    {
                        Keyword = rows[i].Cells["Keyword"].Value.ToString(),
                        Answer = rows[i].Cells["Answer"].Value.ToString(),
                        Question = questionInfo,
                        Artical = articalEntity == null ? 0 : articalEntity.ID,
                        Type = type,
                        Memo = rows[i].Cells["Memo"].Value.ToString(),
                        Level = Convert.ToInt16(rows[i].Cells["Level"].Value),
                        Paragraph = paragraph
                    };
                    try
                    {
                        QuestionModel.AddQuestion(question);
                        success++;
                    }
                    catch
                    {
                        faild++;
                    }
                }
                MessageBox.Show("成功导入" + success + "条，失败" + faild + "条");
            }
        }

        private Dictionary<string, ArticalEntity> dictionary = new Dictionary<string, ArticalEntity>();
        private ArticalEntity GetArticalIDByName(string name)
        {
            ArticalEntity value = null;
            if (dictionary.ContainsKey(name))
            {
                dictionary.TryGetValue(name, out value);
                return value;
            }
            else
            {
                ArticalEntity artical = ArticalModel.QuerySingle(name);
                if (artical != null)
                {
                    dictionary.Add(name, artical);
                    return artical;
                }
                else
                {
                    dictionary.Add(name, null);
                    return null;
                }
            }
        }
    }
}
