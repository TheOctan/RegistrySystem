namespace RegistrationSystem.View
{
    partial class SaveMenu
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
			this.Save = new System.Windows.Forms.Button();
			this.NotSave = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.Message = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Save
			// 
			this.Save.Location = new System.Drawing.Point(45, 96);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(100, 23);
			this.Save.TabIndex = 0;
			this.Save.Text = "Сохранить";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// NotSave
			// 
			this.NotSave.Location = new System.Drawing.Point(151, 96);
			this.NotSave.Name = "NotSave";
			this.NotSave.Size = new System.Drawing.Size(100, 23);
			this.NotSave.TabIndex = 1;
			this.NotSave.Text = "Не сохранять";
			this.NotSave.UseVisualStyleBackColor = true;
			this.NotSave.Click += new System.EventHandler(this.NotSave_Click);
			// 
			// Cancel
			// 
			this.Cancel.Location = new System.Drawing.Point(257, 96);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 2;
			this.Cancel.Text = "Отмена";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// Message
			// 
			this.Message.AutoSize = true;
			this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Message.Location = new System.Drawing.Point(42, 36);
			this.Message.Name = "Message";
			this.Message.Size = new System.Drawing.Size(230, 17);
			this.Message.TabIndex = 3;
			this.Message.Text = "Вы хотите сохранить изменения?";
			// 
			// SaveMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(344, 131);
			this.Controls.Add(this.Message);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.NotSave);
			this.Controls.Add(this.Save);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SaveMenu";
			this.Text = "Registration System";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button NotSave;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Message;
    }
}