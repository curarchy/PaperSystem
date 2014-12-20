namespace PaperSystem.View
{
    partial class QuestionImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionImport));
            this.chooseFile = new System.Windows.Forms.Button();
            this.questionGridView = new System.Windows.Forms.DataGridView();
            this.import = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseFile.Location = new System.Drawing.Point(927, 12);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(75, 23);
            this.chooseFile.TabIndex = 0;
            this.chooseFile.Text = "选择文件";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
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
            this.Question,
            this.Artical,
            this.Answer,
            this.Keyword,
            this.Memo});
            this.questionGridView.Location = new System.Drawing.Point(12, 41);
            this.questionGridView.Name = "questionGridView";
            this.questionGridView.ReadOnly = true;
            this.questionGridView.RowTemplate.Height = 23;
            this.questionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.questionGridView.Size = new System.Drawing.Size(990, 603);
            this.questionGridView.TabIndex = 3;
            // 
            // import
            // 
            this.import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.import.Location = new System.Drawing.Point(927, 650);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 4;
            this.import.Text = "导入";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "选中题目后可以导入。摁住Ctrl键可以选择多条。Ctrl + A 为全选。";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level1";
            this.Level.HeaderText = "难度";
            this.Level.MinimumWidth = 40;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 40;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "TypeText";
            this.Type.HeaderText = "类型";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Question
            // 
            this.Question.DataPropertyName = "Question";
            this.Question.HeaderText = "题干";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Width = 400;
            // 
            // Artical
            // 
            this.Artical.DataPropertyName = "Artical";
            this.Artical.HeaderText = "篇目";
            this.Artical.Name = "Artical";
            this.Artical.ReadOnly = true;
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "答案";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            // 
            // Keyword
            // 
            this.Keyword.DataPropertyName = "Keyword";
            this.Keyword.HeaderText = "关键字";
            this.Keyword.Name = "Keyword";
            this.Keyword.ReadOnly = true;
            // 
            // Memo
            // 
            this.Memo.DataPropertyName = "Memo1";
            this.Memo.HeaderText = "备注";
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            // 
            // QuestionImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 707);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.import);
            this.Controls.Add(this.questionGridView);
            this.Controls.Add(this.chooseFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestionImport";
            this.Text = "QuestionImport";
            ((System.ComponentModel.ISupportInitialize)(this.questionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.DataGridView questionGridView;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
    }
}