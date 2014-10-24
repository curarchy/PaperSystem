using System;
using System.Windows.Forms;
using PaperSystem.Entity;
using PaperSystem.Model;

namespace PaperSystem.View
{
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            QuestionBaseEntity question = GetEntity();
            QuestionModel.AddQuestion(question);
        }

        public QuestionBaseEntity GetEntity() {
            QuestionBaseEntity question = new QuestionBaseEntity();

            question.Type = UIHelper.GetCheckedRadioButton(this.type.Controls);
            question.Level = UIHelper.GetCheckedRadioButton(this.level.Controls);
            question.AnswerA = this.answer.Text.Trim();
            question.MainContent = this.question.Text.Trim();
            question.Memo = this.memo.Text.Trim();

            return question;
        }
    }
}
