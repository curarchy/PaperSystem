namespace PaperSystem.View
{
    partial class ArticalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticalForm));
            this.title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.writter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.RichTextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.memo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(305, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(394, 21);
            this.title.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 45;
            this.label6.Text = "篇目：";
            // 
            // writter
            // 
            this.writter.Location = new System.Drawing.Point(95, 24);
            this.writter.Name = "writter";
            this.writter.Size = new System.Drawing.Size(123, 21);
            this.writter.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 43;
            this.label5.Text = "作者：";
            // 
            // grade
            // 
            this.grade.DisplayMember = "Value";
            this.grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grade.FormattingEnabled = true;
            this.grade.Location = new System.Drawing.Point(767, 24);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(121, 20);
            this.grade.TabIndex = 42;
            this.grade.ValueMember = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "学期：";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(721, 702);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 40;
            this.close.Text = " 关闭";
            this.close.UseVisualStyleBackColor = true;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(95, 68);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(793, 494);
            this.content.TabIndex = 32;
            this.content.Text = "";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(26, 71);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(41, 12);
            this.labelQuestion.TabIndex = 31;
            this.labelQuestion.Text = "正文：";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(813, 702);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 35;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(95, 568);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(793, 128);
            this.memo.TabIndex = 47;
            this.memo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "备注：";
            // 
            // ArticalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.writter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.close);
            this.Controls.Add(this.content);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArticalForm";
            this.Text = "ArticalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox writter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RichTextBox memo;
        private System.Windows.Forms.Label label1;

    }
}