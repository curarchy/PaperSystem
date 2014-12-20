namespace PaperSystem.View
{
    partial class ArticalImport
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
            this.label1 = new System.Windows.Forms.Label();
            this.import = new System.Windows.Forms.Button();
            this.articalGridView = new System.Windows.Forms.DataGridView();
            this.chooseFile = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.articalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 668);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "选中文章后可以导入。摁住Ctrl键可以选择多条。Ctrl + A 为全选。";
            // 
            // import
            // 
            this.import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.import.Location = new System.Drawing.Point(948, 658);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 8;
            this.import.Text = "导入";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
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
            this.Artical,
            this.writter,
            this.Grade});
            this.articalGridView.Location = new System.Drawing.Point(33, 49);
            this.articalGridView.Name = "articalGridView";
            this.articalGridView.ReadOnly = true;
            this.articalGridView.RowTemplate.Height = 23;
            this.articalGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articalGridView.Size = new System.Drawing.Size(990, 603);
            this.articalGridView.TabIndex = 7;
            // 
            // chooseFile
            // 
            this.chooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseFile.Location = new System.Drawing.Point(948, 20);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(75, 23);
            this.chooseFile.TabIndex = 6;
            this.chooseFile.Text = "选择文件";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Artical
            // 
            this.Artical.DataPropertyName = "Artical";
            this.Artical.HeaderText = "篇目";
            this.Artical.Name = "Artical";
            this.Artical.ReadOnly = true;
            // 
            // writter
            // 
            this.writter.DataPropertyName = "writter";
            this.writter.HeaderText = "作者";
            this.writter.MinimumWidth = 40;
            this.writter.Name = "writter";
            this.writter.ReadOnly = true;
            this.writter.Width = 40;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "grade";
            this.Grade.HeaderText = "年级";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // ArticalImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.import);
            this.Controls.Add(this.articalGridView);
            this.Controls.Add(this.chooseFile);
            this.Name = "ArticalImport";
            this.Text = "ArticalImport";
            ((System.ComponentModel.ISupportInitialize)(this.articalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.DataGridView articalGridView;
        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artical;
        private System.Windows.Forms.DataGridViewTextBoxColumn writter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
    }
}