
namespace RegistrationSystem.View
{
	partial class AddMenuView
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
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.patronymicTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.date = new System.Windows.Forms.DateTimePicker();
			this.Cancel = new System.Windows.Forms.Button();
			this.Add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Фамилия";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Имя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Отчество";
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.Location = new System.Drawing.Point(72, 12);
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(133, 20);
			this.surnameTextBox.TabIndex = 3;
			this.surnameTextBox.Click += new System.EventHandler(this.SurnameTextBox_Click);
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(72, 38);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(133, 20);
			this.nameTextBox.TabIndex = 4;
			this.nameTextBox.Click += new System.EventHandler(this.NameTextBox_Click);
			// 
			// patronymicTextBox
			// 
			this.patronymicTextBox.Location = new System.Drawing.Point(72, 64);
			this.patronymicTextBox.Name = "patronymicTextBox";
			this.patronymicTextBox.Size = new System.Drawing.Size(133, 20);
			this.patronymicTextBox.TabIndex = 5;
			this.patronymicTextBox.Click += new System.EventHandler(this.PatronymicTextBox_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Телефон";
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Location = new System.Drawing.Point(72, 90);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(133, 20);
			this.phoneTextBox.TabIndex = 7;
			this.phoneTextBox.Click += new System.EventHandler(this.PhoneTextBox_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Дата";
			// 
			// date
			// 
			this.date.Location = new System.Drawing.Point(72, 116);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(185, 20);
			this.date.TabIndex = 15;
			// 
			// Cancel
			// 
			this.Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Cancel.Location = new System.Drawing.Point(184, 142);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(100, 23);
			this.Cancel.TabIndex = 19;
			this.Cancel.Text = "Отмена";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// Add
			// 
			this.Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Add.Location = new System.Drawing.Point(78, 142);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(100, 23);
			this.Add.TabIndex = 18;
			this.Add.Text = "Добавить";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// AddMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(295, 173);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.date);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.phoneTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.patronymicTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.surnameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddMenu";
			this.Text = "AddMenu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox surnameTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox patronymicTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker date;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Add;
	}
}