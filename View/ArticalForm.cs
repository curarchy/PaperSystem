using System;
using System.Data;
using System.Windows.Forms;
using PaperSystem.Entity;
using PaperSystem.Model;

namespace PaperSystem.View
{
    public partial class ArticalForm : Form
    {
        public ArticalForm()
        {
            InitializeComponent();
            InitControls();
        }

        public void InitControls()
        {
            DataSet gradeDataSet = CommonModel.QueryGrade();
            this.grade.DataSource = gradeDataSet.Tables[0];
        }

        private void save_Click(object sender, System.EventArgs e)
        {
            ArticalEntity articalEntity = GetEntity();
            ArticalModel.AddArtical(articalEntity);

            this.Close();
        }

        /// <summary>
        /// 获取文章实体
        /// </summary>
        /// <returns></returns>
        public ArticalEntity GetEntity()
        {
            ArticalEntity artical = new ArticalEntity();

            artical.Content = this.content.Text;
            artical.Title = this.title.Text.Trim();
            artical.Grade = Convert.ToInt16(this.grade.SelectedValue);
            artical.Writter = this.writter.Text.Trim();
            artical.Memo = this.memo.Text.Trim();

            return artical;
        }
    }
}
