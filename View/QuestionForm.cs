using System;
using System.Data;
using System.Windows.Forms;
using PaperSystem.Entity;
using PaperSystem.Model;

namespace PaperSystem.View
{
    public partial class QuestionForm : Form
    {
        private string formType = "create";
        private int ID = 0;
        private QuestionBaseEntity Question { get; set; }

        public QuestionForm()
        {
            InitializeComponent();
            InitControls();
        }

        public QuestionForm(string type, int id)
        {
            InitializeComponent();
            InitControls();
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
            question.Keyword = question.Type == 0 ? this.keyword.Text.Trim() : "";
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
            this.type.SelectedValue = entity.Type;
            this.level.SelectedValue = entity.Level;
            this.answer.Text = entity.Answer;
            this.question.Text = entity.Question;
            this.memo.Text = entity.Memo;
            this.keyword.Text = entity.Keyword;
            this.paragraph.Value = entity.Paragraph;

            Question = entity;
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

            int type = Convert.ToInt16(this.type.SelectedValue);
            int count = 0;
            if (type == 2)
            {
                count = WordProcessModel.GuessParagraphEX(id, words);
            }
            else
            {
                count = WordProcessModel.GuessParagraph(id, words);
            }
            this.paragraph.Value = count;
        }

        private void articalGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt16(this.articalGridView.Rows[e.RowIndex].Cells["articalID"].Value);
            ArticalEntity artical = ArticalModel.QuerySingle(ID);

            ViewContent viewContent = new ViewContent(artical.Content);
            viewContent.Show();
        }

        /// <summary>
        /// 题型切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.description.Text = "";
            int type = Convert.ToInt16(this.type.SelectedValue);
            switch (type)
            {
                case 1:
                    this.keyword.Show();
                    this.labKeyword.Show();
                    break;
                default:
                     this.keyword.Hide();
                    this.labKeyword.Hide();
                    break;
            }
        }

        private void keyword_Enter(object sender, EventArgs e)
        {
            int type = Convert.ToInt16(this.type.SelectedValue);
            switch (type)
            { 
                case 1:
                    this.description.Text = "请输入加点字。如\"举\"。";
                    break;
                default:
                    this.description.Text = "";
                    break;
            }
        }

        private void question_Enter(object sender, EventArgs e)
        {
            int type = Convert.ToInt16(this.type.SelectedValue);
            switch (type)
            {
                case 1:
                    this.description.Text = "请输入加点字所在语句。如\"举头望明月\"。";
                    break;
                case 2:
                    this.description.Text = "请输入题干。如\"鸢飞戾天者，_______。经纶世务者，_______。\"。";
                    break;
                case 3:
                    this.description.Text = "请输入题干。如\"凤凰山下雨初，水风清，晚霞明。\"。";
                    break;
                default:
                    this.description.Text = "";
                    break;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            int type = Convert.ToInt16(this.type.SelectedValue);
            switch (type)
            {
                case 1:
                    this.description.Text = "请输答案。如\"抬\"。";
                    break;
                case 2:
                    this.description.Text = "请输入答案。间隔用|隔开。如\"望峰息心|窥谷忘反\"。";
                    break;
                case 3:
                    this.description.Text = "请输入译文。如\"雨后初晴的凤凰山下，云淡风清，明丽的晚霞映衬着湖光山色。\"。";
                    break;
                default:
                    this.description.Text = "";
                    break;
            }
        }

        private void memo_Enter(object sender, EventArgs e)
        {
            this.description.Text = "请输入备注。";
        }

        private void articalGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Question != null)
            {
                for (int i = 0; i < articalGridView.Rows.Count; i++)
                {
                    int id = Convert.ToInt16(this.articalGridView.Rows[i].Cells["articalID"].Value);
                    if (id == Question.Artical)
                    {
                        this.articalGridView.Rows[i].Selected = true;
                    }
                }
            }
        }
    }
}
