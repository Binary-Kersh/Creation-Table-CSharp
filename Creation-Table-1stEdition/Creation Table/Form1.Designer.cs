namespace Creation_Table
{
    partial class wlc
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.Button();
            this.log_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(17, 73);
            this.username.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(185, 31);
            this.username.TabIndex = 0;
            this.username.Text = "User Name : ";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(17, 129);
            this.password.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(183, 31);
            this.password.TabIndex = 1;
            this.password.Text = "Password   : ";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(213, 73);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(194, 38);
            this.user.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(213, 126);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(194, 38);
            this.pass.TabIndex = 3;
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(23, 245);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(122, 39);
            this.sign.TabIndex = 4;
            this.sign.Text = "Sign up";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // log_in
            // 
            this.log_in.Location = new System.Drawing.Point(247, 245);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(122, 39);
            this.log_in.TabIndex = 5;
            this.log_in.Text = "Log in";
            this.log_in.UseVisualStyleBackColor = true;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // wlc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 321);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "wlc";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.wlc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button log_in;
    }
}

