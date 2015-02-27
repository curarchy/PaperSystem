using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PaperSystem.Entity;
using PaperSystem.Model;

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
            int tabIndex = this.selectedQuestions.SelectedIndex + 1;
            List<int> deleteQuestions = new List<int>();
            List<int> selectedItems = null;
            List<QuestionBaseEntity> questions = new List<QuestionBaseEntity>();
            switch (tabIndex)
            { 
                case 1:
                    deleteQuestions = UIHelper.GetSelectedIndex(this.selectedExplain);
                    if (dictionary.ContainsKey(3))
                    {
                        dictionary.TryGetValue(3, out selectedItems);
                        selectedItems = selectedItems.Except<int>(deleteQuestions).ToList();
                        dictionary.Remove(3);
                    }
                    dictionary.Add(3, selectedItems);

                    DataSet ds = QuestionModel.QueryQuestionByIDs(selectedItems);
                    BindSelectedResult(ds, this.selectedExplain);
                    break;
                case 2:
                    deleteQuestions = UIHelper.GetSelectedIndex(this.selectedTranslation);
                    if (dictionary.ContainsKey(1))
                    {
                        dictionary.TryGetValue(1, out selectedItems);
                        selectedItems = selectedItems.Except<int>(deleteQuestions).ToList();
                        dictionary.Remove(1);
                    }
                    dictionary.Add(1, selectedItems);
                    DataSet ds2 = QuestionModel.QueryQuestionByIDs(selectedItems);
                    BindSelectedResult(ds2, this.selectedTranslation);
                    break;
                case 3:
                    deleteQuestions = UIHelper.GetSelectedIndex(this.selectedWrite);
                    if (dictionary.ContainsKey(2))
                    {
                        dictionary.TryGetValue(2, out selectedItems);
                        selectedItems = selectedItems.Except<int>(deleteQuestions).ToList();
                        dictionary.Remove(2);
                    }
                    dictionary.Add(2, selectedItems);
                    DataSet ds3 = QuestionModel.QueryQuestionByIDs(selectedItems);
                    BindSelectedResult(ds3, this.selectedWrite);
                    break;
                default:
                    break;
            }

            typeList.ForEach(q =>
            {
                List<int> dicItems = null;
                if (dictionary.ContainsKey(q.Key))
                {
                    dictionary.TryGetValue(q.Key, out dicItems);
                    if (dicItems != null) {
                        DataSet ds = QuestionModel.QueryQuestionByIDs(dicItems);

                        questions.AddRange(Transform.QuestionBaseTransform.Transform(ds.Tables[0]));
                    }                    
                }
            });
            BindChart(questions);
        }

        private void btnExportPaper_Click(object sender, EventArgs e)
        {
            string paper = "";
            string answer = "";
            int index = 0;
            string[] chinese = {"一","二","三","四"};

            bool needAnswer = this.cbxWithAns.Checked;

            string line1 = this.line1_1.Text + this.line1_2.Text + this.line1_3.Text;
            string line2 = this.line2_1.Text + this.line2_2.Text + this.line2_3.Text;

            string title = String.Format("<h1><p>{0}</p><p>{1}</p></h1>", line1, line2);

            string titleLine1 = "<tr><td>内容</td>";
            string titleLine2 = "<tr><td>分值</td>";
            string titleLine3 = "<tr><td>得分</td>";

            int totalPoints = 0;

            typeList.ForEach(q =>
            {
                if (dictionary.ContainsKey(q.Key))
                {
                    List<int> selectedItems = null;
                    dictionary.TryGetValue(q.Key, out selectedItems);
                    DataSet ds = QuestionModel.QueryQuestionByIDs(selectedItems);
                    List<QuestionBaseEntity> questions = Transform.QuestionBaseTransform.Transform(ds.Tables[0]);

                    if (questions.Count == 0) 
                    {
                        return;
                    }

                    int point = 0;

                    if (q.Key == 3) {
                        point = Convert.ToInt16(this.explainPoint.Value);
                        titleLine1 += "<td>加点词解释</td>";
                        titleLine2 += "<td>" + point + "' * " + questions.Count 
                            + " = " + (point * questions.Count) +"</td>";
                        titleLine3 += "<td></td>";
                        totalPoints += (point * questions.Count);
                    }
                    else if (q.Key == 1) {
                        point = Convert.ToInt16(this.translationPoint.Value);
                        titleLine1 += "<td>翻译</td>";
                        titleLine2 += "<td>" + point + "' * " + questions.Count
                            + " = " + (point * questions.Count) + "</td>";
                        titleLine3 += "<td></td>";
                        totalPoints += (point * questions.Count);
                    }
                    else if (q.Key == 2)
                    {
                        point = Convert.ToInt16(this.writePoint.Value);
                        titleLine1 += "<td>默写</td>";
                        titleLine2 += "<td>" + point + "' * " + questions.Count
                            + " = " + (point * questions.Count) + "</td>";
                        titleLine3 += "<td></td>";
                        totalPoints += (point * questions.Count);
                    }

                    paper += ExportModel.BuildPaper(questions, q.Key, chinese[index], point);
                    if (needAnswer)
                    {
                        answer += ExportModel.BuildAnswer(questions, q.Key, chinese[index], point);
                    }
                    index++;
                }
            });

            titleLine1 += "<td>总分</td></tr>";
            titleLine2 += "<td>" + totalPoints + "</td></tr>";
            titleLine3 += "<td></td></tr>";
            title += ("<table>" + titleLine1 + titleLine2 + titleLine3 + "</table>");

            string fileName = this.path.Text + "\\" + this.fileName.Text + ".doc";
            ExportModel.WriteStringToFile(paper, title, fileName);
            MessageBox.Show("已在目录" + fileName + "生成试卷");

            if (needAnswer)
            {
                string answerFileName = this.path.Text + "\\" + this.answerFileName.Text + ".doc";
                ExportModel.WriteStringToFile(answer, title, answerFileName);
                MessageBox.Show("已在目录" + fileName + "生成答案");
            }
        }

        /// <summary>
        /// 随机添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRandom_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt16(this.randomCount.Value);
            List<QuestionBaseEntity> toBeAddedItems = UIHelper.GetAllIndex(this.questionGridView);

            List<int> selectedItems = new List<int>();

            typeList.ForEach(q =>
            {
                List<int> selectedItemsWithKey = new List<int>();
                dictionary.TryGetValue(q.Key, out selectedItemsWithKey);
                if (selectedItemsWithKey != null)
                {
                    selectedItems = selectedItems.Concat<int>(selectedItemsWithKey).ToList();
                }
            });

            toBeAddedItems = toBeAddedItems.FindAll(f => {
                return !selectedItems.Contains(f.ID);
            });


            toBeAddedItems = UIHelper.GetRandomList(toBeAddedItems);

            if (toBeAddedItems.Count >= count)
            {
                toBeAddedItems = toBeAddedItems.Take(count).ToList();
            }


            List<QuestionBaseEntity> questions = new List<QuestionBaseEntity>();

            typeList.ForEach(q =>
            {
                List<int> choosedItems = new List<int>();
                toBeAddedItems.ForEach(j =>
                {
                    if (j.Type == q.Key)
                    {
                        choosedItems.Add(j.ID);
                    }
                });


                List<int> hasSelectedItems = null;
                if (dictionary.ContainsKey(q.Key))
                {
                    dictionary.TryGetValue(q.Key, out hasSelectedItems);
                    choosedItems = choosedItems.Union<int>(hasSelectedItems).ToList();
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

        #region setText

        private void button3_Click(object sender, EventArgs e)
        {
            this.line1_2.Text = "六年级";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.line1_2.Text = "七年级";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.line1_2.Text = "八年级";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.line1_2.Text = "九年级";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.line1_3.Text = "第一学期";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.line1_3.Text = "第二学期";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.line2_2.Text = "月考";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.line2_2.Text = "期中";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.line2_2.Text = "期末";
        }

        #endregion;
    }
}
