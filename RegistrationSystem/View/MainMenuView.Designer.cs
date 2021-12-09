
namespace RegistrationSystem.View
{
	partial class MainMenuView
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
			this.UserList = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.AddButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.OpenButton = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// UserList
			// 
			this.UserList.FormattingEnabled = true;
			this.UserList.Location = new System.Drawing.Point(12, 25);
			this.UserList.Name = "UserList";
			this.UserList.Size = new System.Drawing.Size(272, 303);
			this.UserList.TabIndex = 0;
			this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
			this.UserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserList_MouseDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Записи";
			// 
			// AddButton
			// 
			this.AddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.AddButton.Location = new System.Drawing.Point(290, 25);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(100, 23);
			this.AddButton.TabIndex = 5;
			this.AddButton.Text = "Добавить";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.Add_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Enabled = false;
			this.DeleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.DeleteButton.Location = new System.Drawing.Point(290, 54);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(100, 23);
			this.DeleteButton.TabIndex = 7;
			this.DeleteButton.Text = "Удалить";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.Delete_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Enabled = false;
			this.SaveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.SaveButton.Location = new System.Drawing.Point(102, 334);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(100, 23);
			this.SaveButton.TabIndex = 10;
			this.SaveButton.Text = "Сохранить";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.Save_Click);
			// 
			// OpenButton
			// 
			this.OpenButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.OpenButton.Location = new System.Drawing.Point(12, 334);
			this.OpenButton.Name = "OpenButton";
			this.OpenButton.Size = new System.Drawing.Size(84, 23);
			this.OpenButton.TabIndex = 11;
			this.OpenButton.Text = "Обзор";
			this.OpenButton.UseVisualStyleBackColor = true;
			this.OpenButton.Click += new System.EventHandler(this.Open_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "json";
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
			// 
			// MainMenuView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 369);
			this.Controls.Add(this.OpenButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UserList);
			this.MaximizeBox = false;
			this.Name = "MainMenuView";
			this.Text = "Registry System";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuView_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox UserList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button OpenButton;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

