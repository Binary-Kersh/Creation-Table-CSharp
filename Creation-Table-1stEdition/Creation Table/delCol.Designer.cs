namespace Creation_Table
{
    partial class delCol
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
            this.colList = new System.Windows.Forms.CheckedListBox();
            this.colDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colList
            // 
            this.colList.FormattingEnabled = true;
            this.colList.Location = new System.Drawing.Point(12, 12);
            this.colList.Name = "colList";
            this.colList.Size = new System.Drawing.Size(260, 199);
            this.colList.TabIndex = 0;
            // 
            // colDel
            // 
            this.colDel.Location = new System.Drawing.Point(102, 226);
            this.colDel.Name = "colDel";
            this.colDel.Size = new System.Drawing.Size(75, 23);
            this.colDel.TabIndex = 1;
            this.colDel.Text = "delete";
            this.colDel.UseVisualStyleBackColor = true;
            this.colDel.Click += new System.EventHandler(this.colDel_Click);
            // 
            // delCol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.colDel);
            this.Controls.Add(this.colList);
            this.Name = "delCol";
            this.Text = "delCol";
            this.Load += new System.EventHandler(this.delCol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox colList;
        private System.Windows.Forms.Button colDel;
    }
}