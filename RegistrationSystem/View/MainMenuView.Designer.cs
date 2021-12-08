
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
			this.Add = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.Save = new System.Windows.Forms.Button();
			this.Open = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UserList
			// 
			this.UserList.FormattingEnabled = true;
			this.UserList.Items.AddRange(new object[] {
            "Пусто"});
			this.UserList.Location = new System.Drawing.Point(12, 25);
			this.UserList.Name = "UserList";
			this.UserList.Size = new System.Drawing.Size(272, 303);
			this.UserList.TabIndex = 0;
			this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
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
			// Add
			// 
			this.Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Add.Location = new System.Drawing.Point(290, 25);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(100, 23);
			this.Add.TabIndex = 5;
			this.Add.Text = "Добавить";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Delete
			// 
			this.Delete.Enabled = false;
			this.Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Delete.Location = new System.Drawing.Point(290, 54);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(100, 23);
			this.Delete.TabIndex = 7;
			this.Delete.Text = "Удалить";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// Save
			// 
			this.Save.Enabled = false;
			this.Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Save.Location = new System.Drawing.Point(102, 334);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(100, 23);
			this.Save.TabIndex = 10;
			this.Save.Text = "Сохранить";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// Open
			// 
			this.Open.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Open.Location = new System.Drawing.Point(12, 334);
			this.Open.Name = "Open";
			this.Open.Size = new System.Drawing.Size(84, 23);
			this.Open.TabIndex = 11;
			this.Open.Text = "Обзор";
			this.Open.UseVisualStyleBackColor = true;
			this.Open.Click += new System.EventHandler(this.Open_Click);
			// 
			// MainMenuView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 369);
			this.Controls.Add(this.Open);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UserList);
			this.MaximizeBox = false;
			this.Name = "MainMenuView";
			this.Text = "Registry System";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox UserList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button Open;
	}
}

