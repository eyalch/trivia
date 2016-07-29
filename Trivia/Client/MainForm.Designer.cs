namespace Client
{
	partial class MainForm
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
			this.joinRoomBtn = new System.Windows.Forms.Button();
			this.createRoomBtn = new System.Windows.Forms.Button();
			this.bestScoresBtn = new System.Windows.Forms.Button();
			this.myStatusBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.userLbl = new System.Windows.Forms.Label();
			this.closeBtn = new System.Windows.Forms.Button();
			this.expandBtn = new System.Windows.Forms.Button();
			this.minimizeBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// joinRoomBtn
			// 
			this.joinRoomBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.joinRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.joinRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.joinRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.joinRoomBtn.Location = new System.Drawing.Point(16, 132);
			this.joinRoomBtn.Margin = new System.Windows.Forms.Padding(2);
			this.joinRoomBtn.Name = "joinRoomBtn";
			this.joinRoomBtn.Size = new System.Drawing.Size(225, 117);
			this.joinRoomBtn.TabIndex = 2;
			this.joinRoomBtn.Text = "Join Room";
			this.joinRoomBtn.UseVisualStyleBackColor = false;
			this.joinRoomBtn.Click += new System.EventHandler(this.joinRoomBtn_Click);
			// 
			// createRoomBtn
			// 
			this.createRoomBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.createRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
			this.createRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createRoomBtn.ForeColor = System.Drawing.Color.White;
			this.createRoomBtn.Location = new System.Drawing.Point(264, 132);
			this.createRoomBtn.Margin = new System.Windows.Forms.Padding(2);
			this.createRoomBtn.Name = "createRoomBtn";
			this.createRoomBtn.Size = new System.Drawing.Size(225, 117);
			this.createRoomBtn.TabIndex = 3;
			this.createRoomBtn.Text = "Create Room";
			this.createRoomBtn.UseVisualStyleBackColor = false;
			// 
			// bestScoresBtn
			// 
			this.bestScoresBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.bestScoresBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
			this.bestScoresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bestScoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bestScoresBtn.Location = new System.Drawing.Point(264, 267);
			this.bestScoresBtn.Margin = new System.Windows.Forms.Padding(2);
			this.bestScoresBtn.Name = "bestScoresBtn";
			this.bestScoresBtn.Size = new System.Drawing.Size(225, 117);
			this.bestScoresBtn.TabIndex = 5;
			this.bestScoresBtn.Text = "Best Scores";
			this.bestScoresBtn.UseVisualStyleBackColor = false;
			// 
			// myStatusBtn
			// 
			this.myStatusBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.myStatusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.myStatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.myStatusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.myStatusBtn.ForeColor = System.Drawing.Color.White;
			this.myStatusBtn.Location = new System.Drawing.Point(16, 267);
			this.myStatusBtn.Margin = new System.Windows.Forms.Padding(2);
			this.myStatusBtn.Name = "myStatusBtn";
			this.myStatusBtn.Size = new System.Drawing.Size(225, 117);
			this.myStatusBtn.TabIndex = 4;
			this.myStatusBtn.Text = "My Status";
			this.myStatusBtn.UseVisualStyleBackColor = false;
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
			this.label1.TabIndex = 11;
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
			this.panel1.TabIndex = 10;
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
			this.userLbl.TabIndex = 3;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.ClientSize = new System.Drawing.Size(508, 435);
			this.Controls.Add(this.bestScoresBtn);
			this.Controls.Add(this.myStatusBtn);
			this.Controls.Add(this.createRoomBtn);
			this.Controls.Add(this.joinRoomBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(508, 396);
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(8);
			this.Text = "Magshimim Trivia 2016";
			this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button joinRoomBtn;
		private System.Windows.Forms.Button createRoomBtn;
		private System.Windows.Forms.Button bestScoresBtn;
		private System.Windows.Forms.Button myStatusBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Button expandBtn;
		private System.Windows.Forms.Button minimizeBtn;
		private System.Windows.Forms.Label userLbl;
	}
}