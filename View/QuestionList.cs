using System;
using System.Collections.Generic;
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

        public void BindSearchResult(DataSet ds) {
            DataGridView questionGridView = this.questionGridView;

            questionGridView.DataSource = ds.Tables[0];
            questionGridView.Refresh();
        }

        private void create_Click(object sender, EventArgs e)
        {
            QuestionForm questionForm = new QuestionForm();
            questionForm.FormClosed += new FormClosedEventHandler(questionForm_FormClosed);
            questionForm.ShowDialog();            
        }

        void questionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Search();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> selectedItems = UIHelper.GetSelectedIndex(this.questionGridView);
            QuestionModel.DeleteQuestions(selectedItems);

            Search();
        }

        private void questionGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt16(this.questionGridView.Rows[e.RowIndex].Cells["ID"].Value);

            QuestionForm questionForm = new QuestionForm("modify", ID);
            questionForm.FormClosed += new FormClosedEventHandler(questionForm_FormClosed);
            questionForm.ShowDialog();
        }

        private void import_Click(object sender, EventArgs e)
        {
            QuestionImport questionImport = new QuestionImport();
            questionImport.FormClosed += new FormClosedEventHandler(questionForm_FormClosed);
            questionImport.ShowDialog();   
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            QuestionExport questionExportForm = new QuestionExport();
            questionExportForm.ShowDialog();
        }
    }
}
