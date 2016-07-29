namespace Client
{
	partial class JoinRoomForm
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
			this.errorLbl = new System.Windows.Forms.Label();
			this.roomsList = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.refreshBtn = new System.Windows.Forms.Button();
			this.joinBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.userLbl = new System.Windows.Forms.Label();
			this.closeBtn = new System.Windows.Forms.Button();
			this.expandBtn = new System.Windows.Forms.Button();
			this.minimizeBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.usersList = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// errorLbl
			// 
			this.errorLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorLbl.ForeColor = System.Drawing.Color.DarkRed;
			this.errorLbl.Location = new System.Drawing.Point(8, 459);
			this.errorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.errorLbl.Name = "errorLbl";
			this.errorLbl.Size = new System.Drawing.Size(492, 19);
			this.errorLbl.TabIndex = 11;
			this.errorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roomsList
			// 
			this.roomsList.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.roomsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roomsList.FormattingEnabled = true;
			this.roomsList.ItemHeight = 20;
			this.roomsList.Location = new System.Drawing.Point(133, 132);
			this.roomsList.Margin = new System.Windows.Forms.Padding(2);
			this.roomsList.Name = "roomsList";
			this.roomsList.Size = new System.Drawing.Size(252, 84);
			this.roomsList.TabIndex = 13;
			this.roomsList.SelectedIndexChanged += new System.EventHandler(this.roomsList_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(200, 106);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 25);
			this.label2.TabIndex = 14;
			this.label2.Text = "Rooms List:";
			// 
			// refreshBtn
			// 
			this.refreshBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
			this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshBtn.Location = new System.Drawing.Point(133, 388);
			this.refreshBtn.Margin = new System.Windows.Forms.Padding(2);
			this.refreshBtn.Name = "refreshBtn";
			this.refreshBtn.Size = new System.Drawing.Size(107, 46);
			this.refreshBtn.TabIndex = 15;
			this.refreshBtn.Text = "Refresh";
			this.refreshBtn.UseVisualStyleBackColor = false;
			this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
			// 
			// joinBtn
			// 
			this.joinBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.joinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.joinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.joinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.joinBtn.Location = new System.Drawing.Point(276, 388);
			this.joinBtn.Margin = new System.Windows.Forms.Padding(2);
			this.joinBtn.Name = "joinBtn";
			this.joinBtn.Size = new System.Drawing.Size(107, 46);
			this.joinBtn.TabIndex = 16;
			this.joinBtn.Text = "Join";
			this.joinBtn.UseVisualStyleBackColor = false;
			this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
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
			this.label1.TabIndex = 17;
			this.label1.Text = "Magshimim Trivia 2016";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.userLbl);
			this.panel1.Controls.Add(this.closeBtn);
			this.panel1.Controls.Add(this.expandBtn);
			this.panel1.Controls.Add(this.minimizeBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(492, 20);
			this.panel1.TabIndex = 18;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			// 
			// userLbl
			// 
			this.userLbl.AutoSize = true;
			this.userLbl.Dock = System.Windows.Forms.DockStyle.Right;
			this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userLbl.Location = new System.Drawing.Point(399, 0);
			this.userLbl.Name = "userLbl";
			this.userLbl.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.userLbl.Size = new System.Drawing.Size(93, 20);
			this.userLbl.TabIndex = 4;
			this.userLbl.Text = "USERNAME";
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
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(202, 238);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 25);
			this.label3.TabIndex = 20;
			this.label3.Text = "Users List:";
			// 
			// usersList
			// 
			this.usersList.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.usersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usersList.FormattingEnabled = true;
			this.usersList.ItemHeight = 20;
			this.usersList.Location = new System.Drawing.Point(133, 265);
			this.usersList.Margin = new System.Windows.Forms.Padding(2);
			this.usersList.Name = "usersList";
			this.usersList.Size = new System.Drawing.Size(252, 84);
			this.usersList.TabIndex = 19;
			// 
			// JoinRoomForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.ClientSize = new System.Drawing.Size(508, 486);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.usersList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.joinBtn);
			this.Controls.Add(this.refreshBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.roomsList);
			this.Controls.Add(this.errorLbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(508, 346);
			this.Name = "JoinRoomForm";
			this.Padding = new System.Windows.Forms.Padding(8);
			this.Text = "JoinRoomForm";
			this.SizeChanged += new System.EventHandler(this.JoinRoomForm_SizeChanged);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JoinRoomForm_MouseDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label errorLbl;
		private System.Windows.Forms.ListBox roomsList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button refreshBtn;
		private System.Windows.Forms.Button joinBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Button expandBtn;
		private System.Windows.Forms.Button minimizeBtn;
		private System.Windows.Forms.Label userLbl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox usersList;
	}
}