namespace PaperSystem.View
{
    partial class QuestionList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.search = new System.Windows.Forms.Button();
            this.questionGridView = new System.Windows.Forms.DataGridView();
            this.create = new System.Windows.Forms.Button();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.levelSelectedAll = new System.Windows.Forms.LinkLabel();
            this.levelCheckedList = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gradeSelectedAll = new System.Windows.Forms.LinkLabel();
            this.gradeCheckedList = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.levelSelectedNone = new System.Windows.Forms.LinkLabel();
            this.gradeSelectedNone = new System.Windows.Forms.LinkLabel();
            this.typeSelectedNone = new System.Windows.Forms.LinkLabel();
            this.typeSelectedAll = new System.Windows.Forms.LinkLabel();
            this.typeCheckedList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Location = new System.Drawing.Point(755, 19);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 1;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // questionGridView
            // 
            this.questionGridView.AllowUserToAddRows = false;
            this.questionGridView.AllowUserToDeleteRows = false;
            this.questionGridView.AllowUserToOrderColumns = true;
            this.questionGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Level,
            this.Type,
            this.Grade,
            this.Artical,
            this.Question,
            this.Writter,
            this.Answer});
            this.questionGridView.Location = new System.Drawing.Point(30, 159);
            this.questionGridView.Name = "questionGridView";
            this.questionGridView.ReadOnly = true;
            this.questionGridView.RowTemplate.Height = 23;
            this.questionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.questionGridView.Size = new System.Drawing.Size(883, 591);
            this.questionGridView.TabIndex = 2;
            this.questionGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.questionGridView_CellDoubleClick);
            // 
            // create
            // 
            this.create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.create.Location = new System.Drawing.Point(838, 19);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 3;
            this.create.Text = "新建题目";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(94, 19);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(324, 21);
            this.keyword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "关键字 :";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(822, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "删除所选行";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // import
            // 
            this.import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.import.Location = new System.Drawing.Point(757, 48);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 20;
            this.import.Text = "导入";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(838, 48);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // levelSelectedAll
            // 
            this.levelSelectedAll.AutoSize = true;
            this.levelSelectedAll.Location = new System.Drawing.Point(28, 82);
            this.levelSelectedAll.Name = "levelSelectedAll";
            this.levelSelectedAll.Size = new System.Drawing.Size(29, 12);
            this.levelSelectedAll.TabIndex = 42;
            this.levelSelectedAll.TabStop = true;
            this.levelSelectedAll.Text = "全选";
            this.levelSelectedAll.Click += new System.EventHandler(this.levelSelectedAll_Click);
            // 
            // levelCheckedList
            // 
            this.levelCheckedList.FormattingEnabled = true;
            this.levelCheckedList.Location = new System.Drawing.Point(94, 48);
            this.levelCheckedList.Name = "levelCheckedList";
            this.levelCheckedList.Size = new System.Drawing.Size(127, 100);
            this.levelCheckedList.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "难度：";
            // 
            // gradeSelectedAll
            // 
            this.gradeSelectedAll.AutoSize = true;
            this.gradeSelectedAll.Location = new System.Drawing.Point(244, 82);
            this.gradeSelectedAll.Name = "gradeSelectedAll";
            this.gradeSelectedAll.Size = new System.Drawing.Size(29, 12);
            this.gradeSelectedAll.TabIndex = 45;
            this.gradeSelectedAll.TabStop = true;
            this.gradeSelectedAll.Text = "全选";
            this.gradeSelectedAll.Click += new System.EventHandler(this.gradeSelectedAll_Click);
            // 
            // gradeCheckedList
            // 
            this.gradeCheckedList.CheckOnClick = true;
            this.gradeCheckedList.FormattingEnabled = true;
            this.gradeCheckedList.Location = new System.Drawing.Point(291, 46);
            this.gradeCheckedList.Name = "gradeCheckedList";
            this.gradeCheckedList.Size = new System.Drawing.Size(127, 100);
            this.gradeCheckedList.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 43;
            this.label6.Text = "学期：";
            // 
            // levelSelectedNone
            // 
            this.levelSelectedNone.AutoSize = true;
            this.levelSelectedNone.Location = new System.Drawing.Point(28, 112);
            this.levelSelectedNone.Name = "levelSelectedNone";
            this.levelSelectedNone.Size = new System.Drawing.Size(41, 12);
            this.levelSelectedNone.TabIndex = 46;
            this.levelSelectedNone.TabStop = true;
            this.levelSelectedNone.Text = "全不选";
            this.levelSelectedNone.Click += new System.EventHandler(this.levelSelectedNone_Click);
            // 
            // gradeSelectedNone
            // 
            this.gradeSelectedNone.AutoSize = true;
            this.gradeSelectedNone.Location = new System.Drawing.Point(244, 112);
            this.gradeSelectedNone.Name = "gradeSelectedNone";
            this.gradeSelectedNone.Size = new System.Drawing.Size(41, 12);
            this.gradeSelectedNone.TabIndex = 47;
            this.gradeSelectedNone.TabStop = true;
            this.gradeSelectedNone.Text = "全不选";
            this.gradeSelectedNone.Click += new System.EventHandler(this.gradeSelectedNone_Click);
            // 
            // typeSelectedNone
            // 
            this.typeSelectedNone.AutoSize = true;
            this.typeSelectedNone.Location = new System.Drawing.Point(440, 112);
            this.typeSelectedNone.Name = "typeSelectedNone";
            this.typeSelectedNone.Size = new System.Drawing.Size(41, 12);
            this.typeSelectedNone.TabIndex = 51;
            this.typeSelectedNone.TabStop = true;
            this.typeSelectedNone.Text = "全不选";
            this.typeSelectedNone.Click += new System.EventHandler(this.typeSelectedNone_Click);
            // 
            // typeSelectedAll
            // 
            this.typeSelectedAll.AutoSize = true;
            this.typeSelectedAll.Location = new System.Drawing.Point(440, 82);
            this.typeSelectedAll.Name = "typeSelectedAll";
            this.typeSelectedAll.Size = new System.Drawing.Size(29, 12);
            this.typeSelectedAll.TabIndex = 50;
            this.typeSelectedAll.TabStop = true;
            this.typeSelectedAll.Text = "全选";
            this.typeSelectedAll.Click += new System.EventHandler(this.typeSelectedAll_Click);
            // 
            // typeCheckedList
            // 
            this.typeCheckedList.CheckOnClick = true;
            this.typeCheckedList.FormattingEnabled = true;
            this.typeCheckedList.Location = new System.Drawing.Point(487, 46);
            this.typeCheckedList.Name = "typeCheckedList";
            this.typeCheckedList.Size = new System.Drawing.Size(127, 100);
            this.typeCheckedList.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "题型：";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "LevelText";
            this.Level.HeaderText = "难度";
            this.Level.MinimumWidth = 40;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 60;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "TypeText";
            this.Type.HeaderText = "类型";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 60;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "GradeText";
            this.Grade.HeaderText = "学期";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 60;
            // 
            // Artical
            // 
            this.Artical.DataPropertyName = "Title";
            this.Artical.HeaderText = "篇目";
            this.Artical.Name = "Artical";
            this.Artical.ReadOnly = true;
            // 
            // Question
            // 
            this.Question.DataPropertyName = "Question";
            this.Question.HeaderText = "题干";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Width = 400;
            // 
            // Writter
            // 
            this.Writter.DataPropertyName = "Writter";
            this.Writter.HeaderText = "作者";
            this.Writter.Name = "Writter";
            this.Writter.ReadOnly = true;
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "答案";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            // 
            // QuestionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 762);
            this.Controls.Add(this.typeSelectedNone);
            this.Controls.Add(this.typeSelectedAll);
            this.Controls.Add(this.typeCheckedList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradeSelectedNone);
            this.Controls.Add(this.levelSelectedNone);
            this.Controls.Add(this.gradeSelectedAll);
            this.Controls.Add(this.gradeCheckedList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.levelSelectedAll);
            this.Controls.Add(this.levelCheckedList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.import);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.create);
            this.Controls.Add(this.questionGridView);
            this.Controls.Add(this.search);
            this.Name = "QuestionList";
            this.Text = "QuestionList";
            ((System.ComponentModel.ISupportInitialize)(this.questionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView questionGridView;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.LinkLabel levelSelectedAll;
        private System.Windows.Forms.CheckedListBox levelCheckedList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel gradeSelectedAll;
        private System.Windows.Forms.CheckedListBox gradeCheckedList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel levelSelectedNone;
        private System.Windows.Forms.LinkLabel gradeSelectedNone;
        private System.Windows.Forms.LinkLabel typeSelectedNone;
        private System.Windows.Forms.LinkLabel typeSelectedAll;
        private System.Windows.Forms.CheckedListBox typeCheckedList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
    }
}