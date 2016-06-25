namespace Client
{
	partial class RegisterForm
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
			this.username = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.TextBox();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.registerBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.TextBox();
			this.error = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(974, 132);
			this.label1.TabIndex = 0;
			this.label1.Text = "Magshimim Trivia 2016";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// username
			// 
			this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.Location = new System.Drawing.Point(397, 151);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(400, 44);
			this.username.TabIndex = 1;
			this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(209, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 37);
			this.label2.TabIndex = 3;
			this.label2.Text = "Username: ";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(209, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 37);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password: ";
			// 
			// password
			// 
			this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(397, 201);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(400, 44);
			this.password.TabIndex = 4;
			this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelBtn.Location = new System.Drawing.Point(265, 333);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(214, 88);
			this.cancelBtn.TabIndex = 6;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = false;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// registerBtn
			// 
			this.registerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registerBtn.Location = new System.Drawing.Point(521, 333);
			this.registerBtn.Name = "registerBtn";
			this.registerBtn.Size = new System.Drawing.Size(214, 88);
			this.registerBtn.TabIndex = 7;
			this.registerBtn.Text = "Register";
			this.registerBtn.UseVisualStyleBackColor = false;
			this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(209, 254);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 37);
			this.label4.TabIndex = 9;
			this.label4.Text = "Email: ";
			// 
			// email
			// 
			this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.email.Location = new System.Drawing.Point(397, 251);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(400, 44);
			this.email.TabIndex = 8;
			this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// error
			// 
			this.error.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.error.ForeColor = System.Drawing.Color.DarkRed;
			this.error.Location = new System.Drawing.Point(0, 442);
			this.error.Name = "error";
			this.error.Size = new System.Drawing.Size(974, 37);
			this.error.TabIndex = 10;
			this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.ClientSize = new System.Drawing.Size(974, 479);
			this.Controls.Add(this.error);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.email);
			this.Controls.Add(this.registerBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.username);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(1000, 550);
			this.Name = "RegisterForm";
			this.Text = "Magshimim Trivia 2016 - Register";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button registerBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.Label error;
	}
}