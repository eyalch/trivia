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
			this.label1 = new System.Windows.Forms.Label();
			this.error = new System.Windows.Forms.Label();
			this.user = new System.Windows.Forms.Label();
			this.list = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.refreshBtn = new System.Windows.Forms.Button();
			this.joinBtn = new System.Windows.Forms.Button();
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
			// error
			// 
			this.error.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.error.ForeColor = System.Drawing.Color.DarkRed;
			this.error.Location = new System.Drawing.Point(0, 522);
			this.error.Name = "error";
			this.error.Size = new System.Drawing.Size(974, 37);
			this.error.TabIndex = 11;
			this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// user
			// 
			this.user.Dock = System.Windows.Forms.DockStyle.Top;
			this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.user.ForeColor = System.Drawing.Color.White;
			this.user.Location = new System.Drawing.Point(0, 132);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(974, 42);
			this.user.TabIndex = 12;
			this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// list
			// 
			this.list.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.list.FormattingEnabled = true;
			this.list.ItemHeight = 37;
			this.list.Location = new System.Drawing.Point(250, 238);
			this.list.Name = "list";
			this.list.Size = new System.Drawing.Size(500, 152);
			this.list.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(384, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 46);
			this.label2.TabIndex = 14;
			this.label2.Text = "Rooms List:";
			// 
			// refreshBtn
			// 
			this.refreshBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
			this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshBtn.Location = new System.Drawing.Point(250, 408);
			this.refreshBtn.Name = "refreshBtn";
			this.refreshBtn.Size = new System.Drawing.Size(214, 88);
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
			this.joinBtn.Location = new System.Drawing.Point(536, 408);
			this.joinBtn.Name = "joinBtn";
			this.joinBtn.Size = new System.Drawing.Size(214, 88);
			this.joinBtn.TabIndex = 16;
			this.joinBtn.Text = "Join";
			this.joinBtn.UseVisualStyleBackColor = false;
			this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
			// 
			// JoinRoomForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.ClientSize = new System.Drawing.Size(974, 559);
			this.Controls.Add(this.joinBtn);
			this.Controls.Add(this.refreshBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.list);
			this.Controls.Add(this.user);
			this.Controls.Add(this.error);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(1000, 630);
			this.Name = "JoinRoomForm";
			this.Text = "JoinRoomForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label error;
		private System.Windows.Forms.Label user;
		private System.Windows.Forms.ListBox list;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button refreshBtn;
		private System.Windows.Forms.Button joinBtn;
	}
}