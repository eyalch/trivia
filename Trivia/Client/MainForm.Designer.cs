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
			this.label1 = new System.Windows.Forms.Label();
			this.joinRoomBtn = new System.Windows.Forms.Button();
			this.createRoomBtn = new System.Windows.Forms.Button();
			this.bestScoresBtn = new System.Windows.Forms.Button();
			this.myStatusBtn = new System.Windows.Forms.Button();
			this.user = new System.Windows.Forms.Label();
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
			this.label1.TabIndex = 1;
			this.label1.Text = "Magshimim Trivia 2016";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// joinRoomBtn
			// 
			this.joinRoomBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.joinRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
			this.joinRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.joinRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.joinRoomBtn.Location = new System.Drawing.Point(16, 198);
			this.joinRoomBtn.Name = "joinRoomBtn";
			this.joinRoomBtn.Size = new System.Drawing.Size(450, 225);
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
			this.createRoomBtn.Location = new System.Drawing.Point(512, 198);
			this.createRoomBtn.Name = "createRoomBtn";
			this.createRoomBtn.Size = new System.Drawing.Size(450, 225);
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
			this.bestScoresBtn.Location = new System.Drawing.Point(512, 458);
			this.bestScoresBtn.Name = "bestScoresBtn";
			this.bestScoresBtn.Size = new System.Drawing.Size(450, 225);
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
			this.myStatusBtn.Location = new System.Drawing.Point(16, 458);
			this.myStatusBtn.Name = "myStatusBtn";
			this.myStatusBtn.Size = new System.Drawing.Size(450, 225);
			this.myStatusBtn.TabIndex = 4;
			this.myStatusBtn.Text = "My Status";
			this.myStatusBtn.UseVisualStyleBackColor = false;
			// 
			// user
			// 
			this.user.Dock = System.Windows.Forms.DockStyle.Top;
			this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.user.ForeColor = System.Drawing.Color.White;
			this.user.Location = new System.Drawing.Point(0, 132);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(974, 42);
			this.user.TabIndex = 6;
			this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.ClientSize = new System.Drawing.Size(974, 779);
			this.Controls.Add(this.user);
			this.Controls.Add(this.bestScoresBtn);
			this.Controls.Add(this.myStatusBtn);
			this.Controls.Add(this.createRoomBtn);
			this.Controls.Add(this.joinRoomBtn);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(1000, 850);
			this.Name = "MainForm";
			this.Text = "Magshimim Trivia 2016";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button joinRoomBtn;
		private System.Windows.Forms.Button createRoomBtn;
		private System.Windows.Forms.Button bestScoresBtn;
		private System.Windows.Forms.Button myStatusBtn;
		private System.Windows.Forms.Label user;
	}
}