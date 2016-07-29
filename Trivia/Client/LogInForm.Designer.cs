namespace Client
{
    partial class LogInForm
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
			this.registerBtn = new System.Windows.Forms.Button();
			this.logInBtn = new System.Windows.Forms.Button();
			this.errorLbl = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.closeBtn = new System.Windows.Forms.Button();
			this.expandBtn = new System.Windows.Forms.Button();
			this.minimizeBtn = new System.Windows.Forms.Button();
			this.username = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(8, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(492, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Magshimim Trivia 2016";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			// 
			// registerBtn
			// 
			this.registerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
			this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registerBtn.Location = new System.Drawing.Point(145, 219);
			this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
			this.registerBtn.Name = "registerBtn";
			this.registerBtn.Size = new System.Drawing.Size(107, 46);
			this.registerBtn.TabIndex = 6;
			this.registerBtn.Text = "Register";
			this.registerBtn.UseVisualStyleBackColor = false;
			this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
			// 
			// logInBtn
			// 
			this.logInBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.logInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logInBtn.Location = new System.Drawing.Point(273, 219);
			this.logInBtn.Margin = new System.Windows.Forms.Padding(2);
			this.logInBtn.Name = "logInBtn";
			this.logInBtn.Size = new System.Drawing.Size(107, 46);
			this.logInBtn.TabIndex = 7;
			this.logInBtn.Text = "Log In";
			this.logInBtn.UseVisualStyleBackColor = false;
			this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
			// 
			// errorLbl
			// 
			this.errorLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLbl.ForeColor = System.Drawing.Color.DarkRed;
			this.errorLbl.Location = new System.Drawing.Point(8, 278);
			this.errorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.errorLbl.Name = "errorLbl";
			this.errorLbl.Size = new System.Drawing.Size(492, 19);
			this.errorLbl.TabIndex = 8;
			this.errorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.closeBtn);
			this.panel1.Controls.Add(this.expandBtn);
			this.panel1.Controls.Add(this.minimizeBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(492, 20);
			this.panel1.TabIndex = 9;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			// 
			// closeBtn
			// 
			this.closeBtn.Dock = System.Windows.Forms.DockStyle.Left;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::Client.Properties.Resources.close_window1;
			this.closeBtn.Location = new System.Drawing.Point(0, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(20, 20);
			this.closeBtn.TabIndex = 0;
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// expandBtn
			// 
			this.expandBtn.FlatAppearance.BorderSize = 0;
			this.expandBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.expandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.expandBtn.Image = global::Client.Properties.Resources.expand_window;
			this.expandBtn.Location = new System.Drawing.Point(25, 0);
			this.expandBtn.Margin = new System.Windows.Forms.Padding(0);
			this.expandBtn.Name = "expandBtn";
			this.expandBtn.Size = new System.Drawing.Size(20, 20);
			this.expandBtn.TabIndex = 1;
			this.expandBtn.UseVisualStyleBackColor = true;
			this.expandBtn.Click += new System.EventHandler(this.expandBtn_Click);
			// 
			// minimizeBtn
			// 
			this.minimizeBtn.FlatAppearance.BorderSize = 0;
			this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeBtn.Image = global::Client.Properties.Resources.minimize_window;
			this.minimizeBtn.Location = new System.Drawing.Point(50, 0);
			this.minimizeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.minimizeBtn.Name = "minimizeBtn";
			this.minimizeBtn.Size = new System.Drawing.Size(20, 20);
			this.minimizeBtn.TabIndex = 2;
			this.minimizeBtn.UseVisualStyleBackColor = true;
			this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
			// 
			// username
			// 
			this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.Location = new System.Drawing.Point(211, 130);
			this.username.Margin = new System.Windows.Forms.Padding(2);
			this.username.MaxLength = 99;
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(203, 26);
			this.username.TabIndex = 1;
			this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(117, 131);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Username: ";
			// 
			// password
			// 
			this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(211, 156);
			this.password.Margin = new System.Windows.Forms.Padding(2);
			this.password.MaxLength = 99;
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(203, 26);
			this.password.TabIndex = 4;
			this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(117, 157);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password: ";
			// 
			// LogInForm
			// 
			this.AcceptButton = this.logInBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.ClientSize = new System.Drawing.Size(508, 305);
			this.ControlBox = false;
			this.Controls.Add(this.errorLbl);
			this.Controls.Add(this.logInBtn);
			this.Controls.Add(this.registerBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.username);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(508, 305);
			this.Name = "LogInForm";
			this.Padding = new System.Windows.Forms.Padding(8);
			this.Text = "Magshimim Trivia 2016 - Log In";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.SizeChanged += new System.EventHandler(this.LogInForm_SizeChanged);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogInForm_MouseDown);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button registerBtn;
		private System.Windows.Forms.Button logInBtn;
		private System.Windows.Forms.Label errorLbl;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Button minimizeBtn;
		private System.Windows.Forms.Button expandBtn;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Label label3;
	}
}

