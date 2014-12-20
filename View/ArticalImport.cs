using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PaperSystem.Entity;
using PaperSystem.Model;

namespace PaperSystem.View
{
    public partial class ArticalImport : Form
    {
        public ArticalImport()
        {
            InitializeComponent();
        }

        private void chooseFile_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "excel|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openDialog.FileName;
                DataTable ds = ArticalModel.GetArticalsFromExcel(filename);
                BindSearchResult(ds);
            } 
        }

        public void BindSearchResult(DataTable ds)
        {
            DataGridView articalGridView = this.articalGridView;

            articalGridView.DataSource = ds;
            articalGridView.Refresh();
        }

        private void import_Click(object sender, System.EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = this.articalGridView.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("清先选择文章");
                return;
            }

            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要导入所选择的" + rows.Count.ToString() + "篇文章么？", "导入文章", messButton);
            if (dr == DialogResult.OK)
            {
                int success = 0;
                int faild = 0;

                for (int i = 0; i < rows.Count; i++)
                {
                    string grade = rows[i].Cells["Grade"].Value.ToString();

                    ArticalEntity artical = new ArticalEntity()
                    {
                         Content = rows[i].Cells["Content"].Value.ToString(),
                         Title = rows[i].Cells["Title"].Value.ToString(),
                         Writter = rows[i].Cells["Writter"].Value.ToString(),
                         Grade = GetGradeIDByName(grade)
                    };
                    try
                    {
                        ArticalModel.AddArtical(artical);
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

        private List<CommonEntity> GradeList = null;
        private int GetGradeIDByName(string name)
        {
            if (GradeList == null)
            {
                GradeList = CommonModel.QueryGradeList();
            }

            CommonEntity result = GradeList.Find(e => e.Value == name);
            return result == null ? 0 : result.Key;
        }
    }
}
