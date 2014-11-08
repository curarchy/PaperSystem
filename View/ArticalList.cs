using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PaperSystem.Entity;
using PaperSystem.Model;
using System.Data;

namespace PaperSystem.View
{
    public partial class ArticalList : Form
    {
        public ArticalList()
        {
            InitializeComponent();
            InitList();
        }

        private void InitList()
        {
            this.articalGridView.AutoGenerateColumns = false;

            this.gradeCheckedList.ValueMember = "Key";
            this.gradeCheckedList.DisplayMember = "Value";
            
            List<CommonEntity> gradeList = CommonModel.QueryGradeList();
            this.gradeCheckedList.Items.AddRange(gradeList.ToArray());
        }

        private void create_Click(object sender, EventArgs e)
        {
            ArticalForm articalForm = new ArticalForm();
            articalForm.FormClosed += new FormClosedEventHandler(articalForm_FormClosed);
            articalForm.ShowDialog();
        }

        void articalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Search();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search();
        }

        public ArticalQueryEntity GetEntity()
        {
            ArticalQueryEntity query = new ArticalQueryEntity();
            query.Keyword = this.keyword.Text;
            query.Grade = UIHelper.GetCheckedList(this.gradeCheckedList);
            return query;
        }

        public void BindSearchResult(DataSet ds)
        {
            DataGridView articalGridView = this.articalGridView;

            articalGridView.DataSource = ds.Tables[0];
            articalGridView.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> selectedItems = UIHelper.GetSelectedIndex(this.articalGridView);
            ArticalModel.DeleteArticals(selectedItems);

            Search();
        }

        public void Search()
        {
            ArticalQueryEntity queryEntity = GetEntity();
            DataSet ds = ArticalModel.QueryArtical(queryEntity);
            BindSearchResult(ds);
        }

        private void gradeSelectedNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gradeCheckedList.Items.Count; i++)
            {
                this.gradeCheckedList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void gradeSelectedAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gradeCheckedList.Items.Count; i++)
            {
                this.gradeCheckedList.SetItemCheckState(i, CheckState.Checked);
            }
        }
    }
}
