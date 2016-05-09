namespace Creation_Table
{
    partial class AddCol
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
            this.ColName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Datatype = new System.Windows.Forms.ComboBox();
            this.Null = new System.Windows.Forms.CheckBox();
            this.Primary = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Greater = new System.Windows.Forms.TextBox();
            this.Smaller = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // ColName
            // 
            this.ColName.Location = new System.Drawing.Point(105, 36);
            this.ColName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColName.Name = "ColName";
            this.ColName.Size = new System.Drawing.Size(233, 22);
            this.ColName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Type";
            // 
            // Datatype
            // 
            this.Datatype.FormattingEnabled = true;
            this.Datatype.Items.AddRange(new object[] {
            "Integer ",
            "Decimal",
            "String",
            "Rich Text"});
            this.Datatype.Location = new System.Drawing.Point(105, 90);
            this.Datatype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Datatype.Name = "Datatype";
            this.Datatype.Size = new System.Drawing.Size(233, 24);
            this.Datatype.TabIndex = 3;
            this.Datatype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Null
            // 
            this.Null.AutoSize = true;
            this.Null.Location = new System.Drawing.Point(20, 150);
            this.Null.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Null.Name = "Null";
            this.Null.Size = new System.Drawing.Size(90, 21);
            this.Null.TabIndex = 4;
            this.Null.Text = "Allow Null";
            this.Null.UseVisualStyleBackColor = true;
            // 
            // Primary
            // 
            this.Primary.AutoSize = true;
            this.Primary.Location = new System.Drawing.Point(256, 150);
            this.Primary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Primary.Name = "Primary";
            this.Primary.Size = new System.Drawing.Size(106, 21);
            this.Primary.TabIndex = 5;
            this.Primary.Text = "Primary Key";
            this.Primary.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Greater Than (Number)";
            // 
            // Greater
            // 
            this.Greater.Location = new System.Drawing.Point(191, 203);
            this.Greater.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Greater.Name = "Greater";
            this.Greater.Size = new System.Drawing.Size(153, 22);
            this.Greater.TabIndex = 8;
            this.Greater.TextChanged += new System.EventHandler(this.Greater_TextChanged);
            // 
            // Smaller
            // 
            this.Smaller.Location = new System.Drawing.Point(191, 246);
            this.Smaller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Smaller.Name = "Smaller";
            this.Smaller.Size = new System.Drawing.Size(153, 22);
            this.Smaller.TabIndex = 9;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(141, 290);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 28);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Less Than (Number)";
            // 
            // AddCol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 334);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Smaller);
            this.Controls.Add(this.Greater);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Primary);
            this.Controls.Add(this.Null);
            this.Controls.Add(this.Datatype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCol";
            this.Text = "AddCol";
            this.Load += new System.EventHandler(this.AddCol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Datatype;
        private System.Windows.Forms.CheckBox Null;
        private System.Windows.Forms.CheckBox Primary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Greater;
        private System.Windows.Forms.TextBox Smaller;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label4;
    }
}