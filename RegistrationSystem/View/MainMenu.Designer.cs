
namespace RegistrationSystem
{
	partial class MainMenu
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Add = new System.Windows.Forms.Button();
			this.Edit = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.Find = new System.Windows.Forms.Button();
			this.Save = new System.Windows.Forms.Button();
			this.Open = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
            "Пусто"});
			this.listBox1.Location = new System.Drawing.Point(12, 25);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(272, 303);
			this.listBox1.TabIndex = 0;
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
			// Edit
			// 
			this.Edit.Enabled = false;
			this.Edit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Edit.Location = new System.Drawing.Point(290, 83);
			this.Edit.Name = "Edit";
			this.Edit.Size = new System.Drawing.Size(100, 23);
			this.Edit.TabIndex = 6;
			this.Edit.Text = "Редактировать";
			this.Edit.UseVisualStyleBackColor = true;
			this.Edit.Click += new System.EventHandler(this.Edit_Click);
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
			// Find
			// 
			this.Find.Enabled = false;
			this.Find.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Find.Location = new System.Drawing.Point(290, 112);
			this.Find.Name = "Find";
			this.Find.Size = new System.Drawing.Size(100, 23);
			this.Find.TabIndex = 9;
			this.Find.Text = "Поиск";
			this.Find.UseVisualStyleBackColor = true;
			this.Find.Click += new System.EventHandler(this.Find_Click);
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
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 369);
			this.Controls.Add(this.Open);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.Find);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Edit);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.MaximizeBox = false;
			this.Name = "MainMenu";
			this.Text = "Registry System";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Edit;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Button Find;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button Open;
	}
}

