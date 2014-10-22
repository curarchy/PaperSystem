using System;
using System.Windows.Forms;
using PaperSystem.View;

namespace PaperSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            QuestionForm questionForm = new QuestionForm();
            questionForm.ShowDialog();
        }
    }
}
