using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PaperSystem.Entity;

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
            GetEntity();
            //QuestionBaseEntity question = new QuestionBaseEntity();
            //question.Level = 2;
            //question.Type = 0;
            //question.MainContent = "这是第一个问题";
            //question.AnswerA = "这是第一个答案";

            //QuestionModel.AddQuestion(question);
        }

        public QuestionBaseEntity GetEntity() {
            QuestionBaseEntity question = new QuestionBaseEntity();

            
            // question.Type = 

            return question;
        }
    }
}
