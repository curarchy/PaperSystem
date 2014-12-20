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
            InitControls();
        }

        private void InitControls()
        {
            this.questionGridView.AutoGenerateColumns = false;

            this.gradeCheckedList.ValueMember = "Key";
            this.gradeCheckedList.DisplayMember = "Value";

            List<CommonEntity> gradeList = CommonModel.QueryGradeList();
            this.gradeCheckedList.Items.AddRange(gradeList.ToArray());

            this.levelCheckedList.ValueMember = "Key";
            this.levelCheckedList.DisplayMember = "Value";

            List<CommonEntity> levelList = CommonModel.QueryLevelList();
            this.levelCheckedList.Items.AddRange(levelList.ToArray());

            this.typeCheckedList.ValueMember = "Key";
            this.typeCheckedList.DisplayMember = "Value";

            List<CommonEntity> typeList = CommonModel.QueryTypeList();
            this.typeCheckedList.Items.AddRange(typeList.ToArray());
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
            query.Level = UIHelper.GetCheckedList(this.levelCheckedList);
            query.Grade = UIHelper.GetCheckedList(this.gradeCheckedList);
            query.Type = UIHelper.GetCheckedList(this.typeCheckedList);
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

        #region 全选事件
        private void levelSelectedAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.levelCheckedList.Items.Count; i++)
            {
                this.levelCheckedList.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void gradeSelectedAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gradeCheckedList.Items.Count; i++)
            {
                this.gradeCheckedList.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void levelSelectedNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.levelCheckedList.Items.Count; i++)
            {
                this.levelCheckedList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void gradeSelectedNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gradeCheckedList.Items.Count; i++)
            {
                this.gradeCheckedList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void typeSelectedNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.typeCheckedList.Items.Count; i++)
            {
                this.typeCheckedList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void typeSelectedAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.typeCheckedList.Items.Count; i++)
            {
                this.typeCheckedList.SetItemCheckState(i, CheckState.Checked);
            }
        }
        #endregion;
    }
}
