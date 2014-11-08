using System.Windows.Forms;
using System.Data;
using PaperSystem.Model;
using PaperSystem.Entity;

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
                DataSet ds = QuestionModel.GetQuestionsFromExcel(filename);
                BindSearchResult(ds);
            } 
        }

        public void BindSearchResult(DataSet ds)
        {
            DataGridView questionGridView = this.questionGridView;

            questionGridView.DataSource = ds.Tables[0];
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
            if (dr == System.Windows.Forms.DialogResult.OK) {
                int success = 0;
                int faild = 0;

                for (int i = 0; i < rows.Count; i++ )
                {
                    QuestionBaseEntity question = new QuestionBaseEntity()
                    {
                        //Keyword = rows[i].Cells["Keyword"].Value.ToString(),
                        //Answer = rows[i].Cells["Answer"].Value.ToString(),
                        //Question = rows[i].Cells["Question"].Value.ToString(),
                        //Artical = rows[i].Cells["Artical"].Value.ToString(),
                        //Collection = rows[i].Cells["Collection"].Value.ToString(),
                        //Writter = rows[i].Cells["Writter"].Value.ToString(),
                        //Type = 0,
                        //Grade = 6,
                        //Level = 3
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
    }
}
