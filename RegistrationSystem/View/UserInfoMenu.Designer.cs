
namespace RegistrationSystem.View
{
	partial class UserInfoMenu
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.surenameLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.patronymicLabel = new System.Windows.Forms.Label();
			this.phoneLabel = new System.Windows.Forms.Label();
			this.dateLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Фамилия";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Имя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Отчество";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Телефон";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Дата записи";
			// 
			// surenameLabel
			// 
			this.surenameLabel.AutoSize = true;
			this.surenameLabel.Location = new System.Drawing.Point(93, 9);
			this.surenameLabel.Name = "surenameLabel";
			this.surenameLabel.Size = new System.Drawing.Size(53, 13);
			this.surenameLabel.TabIndex = 5;
			this.surenameLabel.Text = "surename";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(93, 31);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(33, 13);
			this.nameLabel.TabIndex = 6;
			this.nameLabel.Text = "name";
			// 
			// patronymicLabel
			// 
			this.patronymicLabel.AutoSize = true;
			this.patronymicLabel.Location = new System.Drawing.Point(93, 54);
			this.patronymicLabel.Name = "patronymicLabel";
			this.patronymicLabel.Size = new System.Drawing.Size(58, 13);
			this.patronymicLabel.TabIndex = 7;
			this.patronymicLabel.Text = "patronymic";
			// 
			// phoneLabel
			// 
			this.phoneLabel.AutoSize = true;
			this.phoneLabel.Location = new System.Drawing.Point(93, 77);
			this.phoneLabel.Name = "phoneLabel";
			this.phoneLabel.Size = new System.Drawing.Size(37, 13);
			this.phoneLabel.TabIndex = 8;
			this.phoneLabel.Text = "phone";
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.Location = new System.Drawing.Point(93, 99);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(28, 13);
			this.dateLabel.TabIndex = 9;
			this.dateLabel.Text = "date";
			// 
			// UserInfoView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 174);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.phoneLabel);
			this.Controls.Add(this.patronymicLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.surenameLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UserInfoView";
			this.Text = "Информация о пользователе";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label surenameLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label patronymicLabel;
		private System.Windows.Forms.Label phoneLabel;
		private System.Windows.Forms.Label dateLabel;
	}
}