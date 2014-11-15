using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PaperSystem.View
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnArtical_Click(object sender, EventArgs e)
        {
            ArticalList articalList = new ArticalList();
            articalList.ShowDialog();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            QuestionList questionList = new QuestionList();
            questionList.ShowDialog();
        }
    }
}
