using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PaperSystem.Entity;
using PaperSystem.Model;
using System.Windows.Forms.DataVisualization.Charting;

namespace PaperSystem.View
{
    public partial class QuestionExport : Form
    {
        public QuestionExport()
        {
            InitializeComponent();
            InitControls();
        }

        List<CommonEntity> typeList = null;

        private void InitControls()
        {
            this.questionGridView.AutoGenerateColumns = false;

            this.gradeCheckedList.ValueMember = "Key";
            this.gradeCheckedList.DisplayMember = "Value";

            List<CommonEntity> gradeList = CommonModel.QueryGradeList();
            this.gradeCheckedList.Items.AddRange(gradeList.ToArray());

            this.levelCheckedList.ValueMember = "Key";
            this.levelCheckedList.DisplayMember = "Value";

            List<CommonEntity> levelList = CommonModel.QueryLevelList();
            this.levelCheckedList.Items.AddRange(levelList.ToArray());

            this.typeCheckedList.ValueMember = "Key";
            this.typeCheckedList.DisplayMember = "Value";

            typeList = CommonModel.QueryTypeList();
            this.typeCheckedList.Items.AddRange(typeList.ToArray());
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            QuestionQueryBaseEntity query = GetEntity();
            DataSet ds = QuestionModel.QueryQuestion(query);
            BindSearchResult(ds);
        }

        public QuestionQueryBaseEntity GetEntity()
        {
            QuestionQueryBaseEntity query = new QuestionQueryBaseEntity();
            query.Keyword = this.keyword.Text;
            query.Level = UIHelper.GetCheckedList(this.levelCheckedList);
            query.Grade = UIHelper.GetCheckedList(this.gradeCheckedList);
            query.Type = UIHelper.GetCheckedList(this.typeCheckedList);
            return query;
        }

        public void BindSearchResult(DataSet ds)
        {
            DataGridView questionGridView = this.questionGridView;

            questionGridView.DataSource = ds.Tables[0];
            questionGridView.Refresh();
        }

        /// <summary>
        /// 当前所选题目集合
        /// type
        /// ids
        /// </summary>
        private Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            List<QuestionBaseEntity> questions = new List<QuestionBaseEntity>();

            typeList.ForEach(q => {
                List<int> choosedItems = UIHelper.GetSelectedIndex(this.questionGridView, q.Key);
                List<int> selectedItems = null;
                if (dictionary.ContainsKey(q.Key)) 
                {
                    dictionary.TryGetValue(q.Key, out selectedItems);
                    choosedItems = choosedItems.Union<int>(selectedItems).ToList();
                    dictionary.Remove(q.Key);
                }

                dictionary.Add(q.Key, choosedItems);

                DataSet ds = QuestionModel.QueryQuestionByIDs(choosedItems);

                questions.AddRange(Transform.QuestionBaseTransform.Transform(ds.Tables[0]));
                switch (q.Key)
                { 
                    case 1:
                        BindSelectedResult(ds, this.selectedTranslation);
                        break;
                    case 2:
                        BindSelectedResult(ds, this.selectedWrite);
                        break;
                    case 3:
                        BindSelectedResult(ds, this.selectedExplain);
                        break;
                    default:
                        break;
                }
            });
            BindChart(questions);
        }

        public void BindChart(List<QuestionBaseEntity> questions)
        {
            int[] level = { 0, 0, 0, 0, 0 };

            questions.ForEach(
                q =>
                {
                    level[q.Level - 1]++;
                }
            );

            this.chartReport.Series.Clear();
            Series series = new Series("questions");
            series.ChartType = SeriesChartType.Spline;
            series.Name = "难度";
            for (int i = 0; i < level.Length; i++)
            {
                series.Points.AddY(level[i]);
            }
            this.chartReport.Series.Add(series);
            this.chartReport.ChartAreas[0].RecalculateAxesScale();
            this.chartReport.Update();
        }

        public void BindSelectedResult(DataSet ds, DataGridView dtv)
        {
            dtv.DataSource = ds.Tables[0];
            dtv.Refresh();

            List<QuestionBaseEntity> questions = Transform.QuestionBaseTransform.Transform(ds.Tables[0]);
            this.chartReport.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //List<int> selectedItems = UIHelper.GetSelectedIndex(this.selectedGridView);
            //TobeExportIDs = TobeExportIDs.Except<int>(selectedItems).ToList();

            //DataSet ds = QuestionModel.QueryQuestionByIDs(TobeExportIDs);
            //BindSelectedResult(ds);
        }

        private void btnExportPaper_Click(object sender, EventArgs e)
        {
            string paper = "";
            int index = 0;
            string[] chinese = {"一","二","三","四"};

            typeList.ForEach(q =>
            {
                if (dictionary.ContainsKey(q.Key))
                {
                    List<int> selectedItems = null;
                    dictionary.TryGetValue(q.Key, out selectedItems);
                    DataSet ds = QuestionModel.QueryQuestionByIDs(selectedItems);
                    List<QuestionBaseEntity> questions = Transform.QuestionBaseTransform.Transform(ds.Tables[0]);
                    int point = 0;

                    if (q.Key == 3) {
                        point = Convert.ToInt16(this.explainPoint.Value);
                    }
                    else if (q.Key == 1) {
                        point = Convert.ToInt16(this.translationPoint.Value);
                    }
                    else if (q.Key == 2)
                    {
                        point = Convert.ToInt16(this.writePoint.Value);
                    }

                    paper += ExportModel.BuildPaper(questions, q.Key, chinese[index], point);
                    index++;
                }

            });

            string fileName = this.path.Text + "\\" + this.fileName.Text + ".doc";
            ExportModel.WriteStringToFile(paper, fileName);
            MessageBox.Show("已在目录" + fileName + "生成试卷");
        }

        private void btnAddRandom_Click(object sender, EventArgs e)
        {
            //int count = Convert.ToInt16(this.randomCount.Value);
            //List<int> Items = UIHelper.GetSelectedIndex(this.questionGridView.Rows);
        }

        #region 全选事件
        private void levelSelectedAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.levelCheckedList.Items.Count; i++)
            {
                this.levelCheckedList.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void gradeSelectedAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gradeCheckedList.Items.Count; i++)
            {
                this.gradeCheckedList.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void levelSelectedNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.levelCheckedList.Items.Count; i++)
            {
                this.levelCheckedList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void gradeSelectedNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gradeCheckedList.Items.Count; i++)
            {
                this.gradeCheckedList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void typeSelectedNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.typeCheckedList.Items.Count; i++)
            {
                this.typeCheckedList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void typeSelectedAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.typeCheckedList.Items.Count; i++)
            {
                this.typeCheckedList.SetItemCheckState(i, CheckState.Checked);
            }
        }
        #endregion;

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderdialog = new FolderBrowserDialog();
            DialogResult dg = folderdialog.ShowDialog();
            if (dg == System.Windows.Forms.DialogResult.OK) {
                this.path.Text = folderdialog.SelectedPath;
            }
        }
    }
}
