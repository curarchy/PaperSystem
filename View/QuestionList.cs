using System;
using System.Data;
using System.Windows.Forms;
using PaperSystem.Entity;
using PaperSystem.Model;

namespace PaperSystem.View
{
    public partial class QuestionList : Form
    {
        public QuestionList()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            QuestionQueryBaseEntity query = GetEntity();
            DataSet ds = QuestionModel.QueryQuestion(query);
            BindSearchResult(ds);
        }

        public QuestionQueryBaseEntity GetEntity()
        {
            QuestionQueryBaseEntity query = new QuestionQueryBaseEntity();
            query.Keyword = this.keyword.Text;
            query.Level = UIHelper.GetCheckedCheckboxs(this.groupLevel.Controls);
            return query;
        }

        public void BindSearchResult(DataSet ds) {
            DataGridView questionGridView = this.questionGridView;

            questionGridView.DataSource = ds.Tables[0];
            questionGridView.Refresh();
        }

        private void create_Click(object sender, EventArgs e)
        {
            QuestionForm questionForm = new QuestionForm();
            questionForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = this.questionGridView.SelectedRows;
        }
    }
}
