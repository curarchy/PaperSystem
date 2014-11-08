using System;
using System.Data;
using System.Windows.Forms;
using PaperSystem.Entity;
using System.Linq;
using PaperSystem.Model;
using System.Collections.Generic;

namespace PaperSystem.View
{
    public partial class QuestionExport : Form
    {
        public QuestionExport()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
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
            query.Grade = UIHelper.GetCheckedCheckboxs(this.groupGrade.Controls);
            return query;
        }

        public void BindSearchResult(DataSet ds)
        {
            DataGridView questionGridView = this.questionGridView;

            questionGridView.DataSource = ds.Tables[0];
            questionGridView.Refresh();
        }

        private List<int> TobeExportIDs = new List<int>();
        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            List<int> selectedItems = UIHelper.GetSelectedIndex(this.questionGridView);
            DataGridViewSelectedRowCollection exportRows = selectedGridView.DataSource as DataGridViewSelectedRowCollection;
            List<int> ids = selectedItems.Union<int>(TobeExportIDs).ToList();
            TobeExportIDs = ids;

            DataSet ds = QuestionModel.QueryQuestionByIDs(ids);
            BindSelectedResult(ds);
        }

        public void BindSelectedResult(DataSet ds)
        {
            DataGridView selectedGridView = this.selectedGridView;

            selectedGridView.DataSource = ds.Tables[0];
            selectedGridView.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> selectedItems = UIHelper.GetSelectedIndex(this.selectedGridView);
            TobeExportIDs = TobeExportIDs.Except<int>(selectedItems).ToList();

            DataSet ds = QuestionModel.QueryQuestionByIDs(TobeExportIDs);
            BindSelectedResult(ds);
        }

        private void btnExportPaper_Click(object sender, EventArgs e)
        {
            DataTable dataTabel = this.selectedGridView.DataSource as DataTable;
            string fileName = ExportModel.BuildPaper(dataTabel);
            MessageBox.Show("已在目录" + fileName + "生成试卷");
        }

        private void btnAddRandom_Click(object sender, EventArgs e)
        {
            //int count = Convert.ToInt16(this.randomCount.Value);
            //List<int> Items = UIHelper.GetSelectedIndex(this.questionGridView.Rows);
        }
    }
}
