namespace Creation_Table
{
    partial class OpenTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.add_column = new System.Windows.Forms.Button();
            this.delete_column = new System.Windows.Forms.Button();
            this.delete_row = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(468, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(11, 242);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(76, 21);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // add_column
            // 
            this.add_column.Location = new System.Drawing.Point(100, 240);
            this.add_column.Margin = new System.Windows.Forms.Padding(2);
            this.add_column.Name = "add_column";
            this.add_column.Size = new System.Drawing.Size(100, 21);
            this.add_column.TabIndex = 2;
            this.add_column.Text = "Add Column";
            this.add_column.UseVisualStyleBackColor = true;
            this.add_column.Click += new System.EventHandler(this.add_column_Click);
            // 
            // delete_column
            // 
            this.delete_column.Location = new System.Drawing.Point(256, 240);
            this.delete_column.Name = "delete_column";
            this.delete_column.Size = new System.Drawing.Size(108, 23);
            this.delete_column.TabIndex = 7;
            this.delete_column.Text = "Delete Column";
            this.delete_column.UseVisualStyleBackColor = true;
            this.delete_column.Click += new System.EventHandler(this.delete_column_Click);
            // 
            // delete_row
            // 
            this.delete_row.Location = new System.Drawing.Point(376, 240);
            this.delete_row.Name = "delete_row";
            this.delete_row.Size = new System.Drawing.Size(82, 23);
            this.delete_row.TabIndex = 8;
            this.delete_row.Text = "Delete Row";
            this.delete_row.UseVisualStyleBackColor = true;
            this.delete_row.Click += new System.EventHandler(this.delete_row_Click);
            // 
            // OpenTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 272);
            this.Controls.Add(this.delete_row);
            this.Controls.Add(this.delete_column);
            this.Controls.Add(this.add_column);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OpenTable";
            this.Text = "OpenTable";
            this.Load += new System.EventHandler(this.OpenTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add_column;
        private System.Windows.Forms.Button delete_column;
        private System.Windows.Forms.Button delete_row;
    }
}