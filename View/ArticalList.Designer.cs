namespace PaperSystem.View
{
    partial class ArticalList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticalList));
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyword = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.articalGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search = new System.Windows.Forms.Button();
            this.gradeCheckedList = new System.Windows.Forms.CheckedListBox();
            this.gradeSelectedAll = new System.Windows.Forms.LinkLabel();
            this.gradeSelectedNone = new System.Windows.Forms.LinkLabel();
            this.import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.articalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "学期：";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(825, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "删除所选行";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "关键字 :";
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(97, 28);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(261, 21);
            this.keyword.TabIndex = 27;
            // 
            // create
            // 
            this.create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.create.Location = new System.Drawing.Point(841, 28);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 26;
            this.create.Text = "新建文章";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // articalGridView
            // 
            this.articalGridView.AllowUserToAddRows = false;
            this.articalGridView.AllowUserToDeleteRows = false;
            this.articalGridView.AllowUserToOrderColumns = true;
            this.articalGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Grade,
            this.Artical,
            this.Writter,
            this.Question});
            this.articalGridView.Location = new System.Drawing.Point(33, 183);
            this.articalGridView.Name = "articalGridView";
            this.articalGridView.ReadOnly = true;
            this.articalGridView.RowTemplate.Height = 23;
            this.articalGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articalGridView.Size = new System.Drawing.Size(883, 576);
            this.articalGridView.TabIndex = 25;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
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
            // Writter
            // 
            this.Writter.DataPropertyName = "Writter";
            this.Writter.HeaderText = "作者";
            this.Writter.Name = "Writter";
            this.Writter.ReadOnly = true;
            // 
            // Question
            // 
            this.Question.DataPropertyName = "Content";
            this.Question.HeaderText = "正文";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Width = 400;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Location = new System.Drawing.Point(744, 28);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 24;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // gradeCheckedList
            // 
            this.gradeCheckedList.CheckOnClick = true;
            this.gradeCheckedList.FormattingEnabled = true;
            this.gradeCheckedList.Location = new System.Drawing.Point(97, 77);
            this.gradeCheckedList.Name = "gradeCheckedList";
            this.gradeCheckedList.Size = new System.Drawing.Size(127, 100);
            this.gradeCheckedList.TabIndex = 36;
            // 
            // gradeSelectedAll
            // 
            this.gradeSelectedAll.AutoSize = true;
            this.gradeSelectedAll.Location = new System.Drawing.Point(33, 108);
            this.gradeSelectedAll.Name = "gradeSelectedAll";
            this.gradeSelectedAll.Size = new System.Drawing.Size(29, 12);
            this.gradeSelectedAll.TabIndex = 38;
            this.gradeSelectedAll.TabStop = true;
            this.gradeSelectedAll.Text = "全选";
            this.gradeSelectedAll.Click += new System.EventHandler(this.gradeSelectedAll_Click);
            // 
            // gradeSelectedNone
            // 
            this.gradeSelectedNone.AutoSize = true;
            this.gradeSelectedNone.Location = new System.Drawing.Point(33, 138);
            this.gradeSelectedNone.Name = "gradeSelectedNone";
            this.gradeSelectedNone.Size = new System.Drawing.Size(41, 12);
            this.gradeSelectedNone.TabIndex = 48;
            this.gradeSelectedNone.TabStop = true;
            this.gradeSelectedNone.Text = "全不选";
            this.gradeSelectedNone.Click += new System.EventHandler(this.gradeSelectedNone_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(744, 72);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 49;
            this.import.Text = "导入";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // ArticalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 786);
            this.Controls.Add(this.import);
            this.Controls.Add(this.gradeSelectedNone);
            this.Controls.Add(this.gradeSelectedAll);
            this.Controls.Add(this.gradeCheckedList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.create);
            this.Controls.Add(this.articalGridView);
            this.Controls.Add(this.search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArticalList";
            this.Text = "ArticalList";
            ((System.ComponentModel.ISupportInitialize)(this.articalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.DataGridView articalGridView;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.CheckedListBox gradeCheckedList;
        private System.Windows.Forms.LinkLabel gradeSelectedAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.LinkLabel gradeSelectedNone;
        private System.Windows.Forms.Button import;
    }
}