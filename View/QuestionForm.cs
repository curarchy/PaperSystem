using System;
using System.Windows.Forms;
using PaperSystem.Entity;
using PaperSystem.Model;

namespace PaperSystem.View
{
    public partial class QuestionForm : Form
    {
        private string formType = "create";
        private int ID = 0;

        public QuestionForm()
        {
            InitializeComponent();
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

        private void save_Click(object sender, EventArgs e)
        {
            if (this.formType == "create")
            {
                QuestionBaseEntity question = GetEntity();
                QuestionModel.AddQuestion(question);
            }
            else if (this.formType == "modify")
            {
                QuestionBaseEntity question = GetEntity();
                QuestionModel.ModifyQuestion(question);
            }

            this.Close();
        }

        public QuestionBaseEntity GetEntity() {
            QuestionBaseEntity question = new QuestionBaseEntity();

            question.Type = UIHelper.GetCheckedRadioButton(this.type.Controls);
            question.Level = UIHelper.GetCheckedRadioButton(this.level.Controls);
            question.Answer = this.answer.Text.Trim();
            question.Question = this.question.Text.Trim();
            question.Memo = this.memo.Text.Trim();
            question.ID = ID;
            question.Writter = this.writter.Text.Trim();
            question.Artical = this.artical.Text.Trim();
            question.Collection = this.collection.Text.Trim();
            question.Grade = this.grade.SelectedIndex;
            question.Keyword = this.keyword.Text.Trim();

            return question;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InitData(QuestionBaseEntity entity)
        {
            UIHelper.SetCheckedRadioButton(this.type.Controls, entity.Type);
            UIHelper.SetCheckedRadioButton(this.level.Controls, entity.Level);
            this.answer.Text = entity.Answer;
            this.question.Text = entity.Question;
            this.memo.Text = entity.Memo;
            this.writter.Text = entity.Writter;
            this.artical.Text = entity.Artical;
            this.collection.Text = entity.Collection;
            this.grade.SelectedIndex = entity.Grade;
            this.keyword.Text = entity.Keyword;
        }
    }
}
