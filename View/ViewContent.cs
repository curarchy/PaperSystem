using System.Windows.Forms;

namespace PaperSystem.View
{
    public partial class ViewContent : Form
    {
        public ViewContent()
        {
            InitializeComponent();
        }

        public ViewContent(string content)
        {
            InitializeComponent();
            this.content.Text = content;
        }
    }
}
