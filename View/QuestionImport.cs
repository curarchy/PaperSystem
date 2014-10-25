using System.Windows.Forms;
using System.Data;
using PaperSystem.Model;

namespace PaperSystem.View
{
    public partial class QuestionImport : Form
    {
        public QuestionImport()
        {
            InitializeComponent();
        }

        private void chooseFile_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "excel|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK){
                string filename = openDialog.FileName;
                DataSet ds = QuestionModel.GetQuestionsFromExcel(filename);
                BindSearchResult(ds);
            } 
        }

        public void BindSearchResult(DataSet ds)
        {
            DataGridView questionGridView = this.questionGridView;

            questionGridView.DataSource = ds.Tables[0];
            questionGridView.Refresh();
        }
    }
}
