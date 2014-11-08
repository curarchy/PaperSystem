namespace PaperSystem.View
{
    partial class Start
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
            this.btnArtical = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArtical
            // 
            this.btnArtical.Location = new System.Drawing.Point(85, 44);
            this.btnArtical.Name = "btnArtical";
            this.btnArtical.Size = new System.Drawing.Size(75, 23);
            this.btnArtical.TabIndex = 0;
            this.btnArtical.Text = "文章管理";
            this.btnArtical.UseVisualStyleBackColor = true;
            this.btnArtical.Click += new System.EventHandler(this.btnArtical_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(85, 96);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion.TabIndex = 1;
            this.btnQuestion.Text = "题目管理";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 216);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.btnArtical);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArtical;
        private System.Windows.Forms.Button btnQuestion;
    }
}