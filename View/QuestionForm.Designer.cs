namespace PaperSystem.View
{
    partial class QuestionForm
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
            this.labelType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paragraph = new System.Windows.Forms.NumericUpDown();
            this.type = new System.Windows.Forms.ComboBox();
            this.guessParagraph = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.articalGridView = new System.Windows.Forms.DataGridView();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.ComboBox();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.RichTextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelMemo = new System.Windows.Forms.Label();
            this.memo = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paragraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(36, 34);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(41, 12);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "题型：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.paragraph);
            this.panel1.Controls.Add(this.type);
            this.panel1.Controls.Add(this.guessParagraph);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.articalGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.level);
            this.panel1.Controls.Add(this.keyword);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.question);
            this.panel1.Controls.Add(this.labelQuestion);
            this.panel1.Controls.Add(this.answer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelLevel);
            this.panel1.Controls.Add(this.labelMemo);
            this.panel1.Controls.Add(this.memo);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.labelType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 605);
            this.panel1.TabIndex = 2;
            // 
            // paragraph
            // 
            this.paragraph.Location = new System.Drawing.Point(82, 540);
            this.paragraph.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.paragraph.Name = "paragraph";
            this.paragraph.Size = new System.Drawing.Size(66, 21);
            this.paragraph.TabIndex = 51;
            this.paragraph.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // type
            // 
            this.type.DisplayMember = "Value";
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(83, 31);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(108, 20);
            this.type.TabIndex = 50;
            this.type.ValueMember = "Key";
            // 
            // guessParagraph
            // 
            this.guessParagraph.Location = new System.Drawing.Point(154, 538);
            this.guessParagraph.Name = "guessParagraph";
            this.guessParagraph.Size = new System.Drawing.Size(75, 23);
            this.guessParagraph.TabIndex = 49;
            this.guessParagraph.Text = "猜一下";
            this.guessParagraph.UseVisualStyleBackColor = true;
            this.guessParagraph.Click += new System.EventHandler(this.guessParagraph_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 543);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 47;
            this.label18.Text = "段落：";
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
            this.Grade,
            this.articalID,
            this.Artical,
            this.Writter});
            this.articalGridView.Location = new System.Drawing.Point(38, 108);
            this.articalGridView.MultiSelect = false;
            this.articalGridView.Name = "articalGridView";
            this.articalGridView.ReadOnly = true;
            this.articalGridView.RowTemplate.Height = 23;
            this.articalGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articalGridView.Size = new System.Drawing.Size(369, 414);
            this.articalGridView.TabIndex = 46;
            this.articalGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articalGridView_CellDoubleClick);
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "GradeText";
            this.Grade.HeaderText = "学期";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 60;
            // 
            // articalID
            // 
            this.articalID.DataPropertyName = "ID";
            this.articalID.HeaderText = "ID";
            this.articalID.Name = "articalID";
            this.articalID.ReadOnly = true;
            this.articalID.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "所属文章：";
            // 
            // level
            // 
            this.level.DisplayMember = "Value";
            this.level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.level.FormattingEnabled = true;
            this.level.Location = new System.Drawing.Point(460, 83);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(108, 20);
            this.level.TabIndex = 44;
            this.level.ValueMember = "Key";
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(460, 125);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(439, 21);
            this.keyword.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "例字：";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(732, 540);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 18;
            this.close.Text = " 关闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(460, 164);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(439, 176);
            this.question.TabIndex = 5;
            this.question.Text = "";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(413, 167);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(41, 12);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "题干：";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(460, 346);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(439, 85);
            this.answer.TabIndex = 17;
            this.answer.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "答案：";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(413, 86);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(41, 12);
            this.labelLevel.TabIndex = 2;
            this.labelLevel.Text = "难度：";
            // 
            // labelMemo
            // 
            this.labelMemo.AutoSize = true;
            this.labelMemo.Location = new System.Drawing.Point(413, 449);
            this.labelMemo.Name = "labelMemo";
            this.labelMemo.Size = new System.Drawing.Size(41, 12);
            this.labelMemo.TabIndex = 6;
            this.labelMemo.Text = "备注：";
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(460, 437);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(439, 85);
            this.memo.TabIndex = 7;
            this.memo.Text = "";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(824, 540);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "猜测题干在文章的第几段。如果没有匹配到，则是0.请双击文章，手动匹配。";
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 605);
            this.Controls.Add(this.panel1);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paragraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articalGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RichTextBox question;
        private System.Windows.Forms.Label labelMemo;
        private System.Windows.Forms.RichTextBox memo;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RichTextBox answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox level;
        private System.Windows.Forms.Button guessParagraph;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView articalGridView;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn articalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writter;
        private System.Windows.Forms.NumericUpDown paragraph;
        private System.Windows.Forms.Label label2;
    }
}