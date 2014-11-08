using System;
using System.Windows.Forms;
using PaperSystem.Entity;
using PaperSystem.Model;
using System.Data;

namespace PaperSystem.View
{
    public partial class QuestionForm : Form
    {
        private string formType = "create";
        private int ID = 0;

        public QuestionForm()
        {
            InitializeComponent();
            InitControls();
        }

        public QuestionForm(string type, int id)
        {
            InitializeComponent();
            if (type == "modify") 
            {
                formType = type;
                this.save.Text = "修改";

                QuestionBaseEntity question = QuestionModel.QuerySingle(id);
                ID = question.ID;
                InitData(question);
            }
        }

        public void InitControls()
        {
            this.articalGridView.AutoGenerateColumns = false;

            DataSet levelDataSet = CommonModel.QueryLevel();
            this.level.DataSource = levelDataSet.Tables[0];

            DataSet typeDataSet = CommonModel.QueryType();
            this.type.DataSource = typeDataSet.Tables[0];

            DataSet artical = ArticalModel.QueryAllArtical();
            this.articalGridView.DataSource = artical.Tables[0];
            this.articalGridView.Refresh();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (this.formType == "create")
            {
                QuestionBaseEntity question = GetEntity();
                if (ValidateEntity(question))
                {
                    QuestionModel.AddQuestion(question);
                    this.Close();
                }
            }
            else if (this.formType == "modify")
            {
                QuestionBaseEntity question = GetEntity();
                if (ValidateEntity(question))
                {
                    QuestionModel.ModifyQuestion(question);
                    this.Close();
                }
            }
        }

        public QuestionBaseEntity GetEntity() 
        {
            QuestionBaseEntity question = new QuestionBaseEntity();

            question.Type = Convert.ToInt16(this.type.SelectedValue);
            question.Level = Convert.ToInt16(this.level.SelectedValue);
            question.Answer = this.answer.Text.Trim();
            question.Question = this.question.Text.Trim();
            question.Memo = this.memo.Text.Trim();
            question.ID = ID;
            question.Artical = Convert.ToInt16(this.articalGridView.SelectedRows[0].Cells["articalID"].Value);
            question.Keyword = this.keyword.Text.Trim();
            question.Paragraph = Convert.ToInt16(this.paragraph.Value);

            return question;
        }

        public bool ValidateEntity(QuestionBaseEntity question)
        {
            if (question.Paragraph < 0)
            {
                MessageBox.Show("请先输入段落");
                return false;
            }
            return true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InitData(QuestionBaseEntity entity)
        {
            //UIHelper.SetCheckedRadioButton(this.type.Controls, entity.Type);
            //UIHelper.SetCheckedRadioButton(this.level.Controls, entity.Level);
            //this.answer.Text = entity.Answer;
            //this.question.Text = entity.Question;
            //this.memo.Text = entity.Memo;
            //this.writter.Text = entity.Writter;
            //this.artical.Text = entity.Artical;
            //this.collection.Text = entity.Collection;
            //this.grade.SelectedIndex = entity.Grade;
            //this.keyword.Text = entity.Keyword;
        }

        private void guessParagraph_Click(object sender, EventArgs e)
        {
            string words = this.question.Text.Trim();

            if (string.IsNullOrEmpty(words))
            {
                MessageBox.Show("请先输入题干");
                return;
            }

            int id = Convert.ToInt16(this.articalGridView.SelectedRows[0].Cells["articalID"].Value);
            int count = WordProcessModel.GuessParagraph(id, words);
            this.paragraph.Value = count;
        }

        private void articalGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt16(this.articalGridView.Rows[e.RowIndex].Cells["articalID"].Value);
            ArticalEntity artical = ArticalModel.QuerySingle(ID);

            ViewContent viewContent = new ViewContent(artical.Content);
            viewContent.Show();
        }
    }
}
