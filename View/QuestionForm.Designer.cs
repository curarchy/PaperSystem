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
            this.translate = new System.Windows.Forms.RadioButton();
            this.labelType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.RichTextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.answer = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.GroupBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelMemo = new System.Windows.Forms.Label();
            this.memo = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.writter = new System.Windows.Forms.TextBox();
            this.artical = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.collection = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.level.SuspendLayout();
            this.type.SuspendLayout();
            this.SuspendLayout();
            // 
            // translate
            // 
            this.translate.AutoSize = true;
            this.translate.Checked = true;
            this.translate.Location = new System.Drawing.Point(12, 20);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(47, 16);
            this.translate.TabIndex = 0;
            this.translate.TabStop = true;
            this.translate.Tag = "0";
            this.translate.Text = "翻译";
            this.translate.UseVisualStyleBackColor = true;
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
            this.panel1.Controls.Add(this.keyword);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.collection);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.artical);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.writter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.grade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.question);
            this.panel1.Controls.Add(this.labelQuestion);
            this.panel1.Controls.Add(this.level);
            this.panel1.Controls.Add(this.answer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.type);
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
            // close
            // 
            this.close.Location = new System.Drawing.Point(731, 552);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 18;
            this.close.Text = " 关闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(105, 173);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(793, 179);
            this.question.TabIndex = 5;
            this.question.Text = "";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(36, 176);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(41, 12);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "题干：";
            // 
            // level
            // 
            this.level.Controls.Add(this.radioButton1);
            this.level.Controls.Add(this.label2);
            this.level.Controls.Add(this.radioButton2);
            this.level.Controls.Add(this.label1);
            this.level.Controls.Add(this.radioButton3);
            this.level.Controls.Add(this.radioButton4);
            this.level.Controls.Add(this.radioButton5);
            this.level.Location = new System.Drawing.Point(287, 12);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(261, 47);
            this.level.TabIndex = 15;
            this.level.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(44, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(29, 16);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "难";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(184, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(29, 16);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Tag = "5";
            this.radioButton2.Text = "5";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "易";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(149, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(29, 16);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Tag = "4";
            this.radioButton3.Text = "4";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(114, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(29, 16);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "3";
            this.radioButton4.Text = "3";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(79, 22);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(29, 16);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.Tag = "2";
            this.radioButton5.Text = "2";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(105, 358);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(793, 85);
            this.answer.TabIndex = 17;
            this.answer.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "答案：";
            // 
            // type
            // 
            this.type.Controls.Add(this.translate);
            this.type.Location = new System.Drawing.Point(105, 12);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(108, 47);
            this.type.TabIndex = 16;
            this.type.TabStop = false;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(240, 34);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(41, 12);
            this.labelLevel.TabIndex = 2;
            this.labelLevel.Text = "难度：";
            // 
            // labelMemo
            // 
            this.labelMemo.AutoSize = true;
            this.labelMemo.Location = new System.Drawing.Point(36, 452);
            this.labelMemo.Name = "labelMemo";
            this.labelMemo.Size = new System.Drawing.Size(41, 12);
            this.labelMemo.TabIndex = 6;
            this.labelMemo.Text = "备注：";
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(105, 449);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(793, 85);
            this.memo.TabIndex = 7;
            this.memo.Text = "";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(823, 552);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "学期：";
            // 
            // grade
            // 
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "六上",
            "六下",
            "七上",
            "七下",
            "八上",
            "八下",
            "九上",
            "九下",
            "其它"});
            this.grade.Location = new System.Drawing.Point(621, 29);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(121, 20);
            this.grade.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "作者：";
            // 
            // writter
            // 
            this.writter.Location = new System.Drawing.Point(105, 87);
            this.writter.Name = "writter";
            this.writter.Size = new System.Drawing.Size(108, 21);
            this.writter.TabIndex = 22;
            // 
            // artical
            // 
            this.artical.Location = new System.Drawing.Point(309, 87);
            this.artical.Name = "artical";
            this.artical.Size = new System.Drawing.Size(108, 21);
            this.artical.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "篇目：";
            // 
            // collection
            // 
            this.collection.Location = new System.Drawing.Point(518, 87);
            this.collection.Name = "collection";
            this.collection.Size = new System.Drawing.Size(108, 21);
            this.collection.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "选自：";
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(105, 131);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(108, 21);
            this.keyword.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "例字：";
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
            this.level.ResumeLayout(false);
            this.level.PerformLayout();
            this.type.ResumeLayout(false);
            this.type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton translate;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RichTextBox question;
        private System.Windows.Forms.Label labelMemo;
        private System.Windows.Forms.RichTextBox memo;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox level;
        private System.Windows.Forms.GroupBox type;
        private System.Windows.Forms.RichTextBox answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox collection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox artical;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox writter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.Label label4;
    }
}