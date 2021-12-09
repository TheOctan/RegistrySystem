namespace Catalog
{
    partial class EditMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMenu));
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DosageLabel = new System.Windows.Forms.Label();
            this.NumberOfDosesLabel = new System.Windows.Forms.Label();
            this.PurposeLabel = new System.Windows.Forms.Label();
            this.MedicamentName = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Dosage = new System.Windows.Forms.NumericUpDown();
            this.CountOfDoses = new System.Windows.Forms.NumericUpDown();
            this.Purpose = new System.Windows.Forms.RichTextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.AddCategory = new System.Windows.Forms.Button();
            this.DeleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dosage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfDoses)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(12, 37);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(60, 13);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Категория";
            // 
            // DosageLabel
            // 
            this.DosageLabel.AutoSize = true;
            this.DosageLabel.Location = new System.Drawing.Point(12, 63);
            this.DosageLabel.Name = "DosageLabel";
            this.DosageLabel.Size = new System.Drawing.Size(64, 13);
            this.DosageLabel.TabIndex = 2;
            this.DosageLabel.Text = "Дозировка";
            // 
            // NumberOfDosesLabel
            // 
            this.NumberOfDosesLabel.AutoSize = true;
            this.NumberOfDosesLabel.Location = new System.Drawing.Point(12, 90);
            this.NumberOfDosesLabel.Name = "NumberOfDosesLabel";
            this.NumberOfDosesLabel.Size = new System.Drawing.Size(87, 13);
            this.NumberOfDosesLabel.TabIndex = 3;
            this.NumberOfDosesLabel.Text = "Количество доз";
            // 
            // PurposeLabel
            // 
            this.PurposeLabel.AutoSize = true;
            this.PurposeLabel.Location = new System.Drawing.Point(12, 117);
            this.PurposeLabel.Name = "PurposeLabel";
            this.PurposeLabel.Size = new System.Drawing.Size(68, 13);
            this.PurposeLabel.TabIndex = 4;
            this.PurposeLabel.Text = "Назначение";
            // 
            // MedicamentName
            // 
            this.MedicamentName.Location = new System.Drawing.Point(105, 8);
            this.MedicamentName.Name = "MedicamentName";
            this.MedicamentName.Size = new System.Drawing.Size(185, 20);
            this.MedicamentName.TabIndex = 5;
            this.MedicamentName.Click += new System.EventHandler(this.MedicamentName_Click);
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(105, 34);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(185, 21);
            this.Category.TabIndex = 6;
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // Dosage
            // 
            this.Dosage.Location = new System.Drawing.Point(105, 61);
            this.Dosage.Name = "Dosage";
            this.Dosage.Size = new System.Drawing.Size(185, 20);
            this.Dosage.TabIndex = 7;
            this.Dosage.Click += new System.EventHandler(this.Dosage_Click);
            // 
            // CountOfDoses
            // 
            this.CountOfDoses.Location = new System.Drawing.Point(105, 88);
            this.CountOfDoses.Name = "CountOfDoses";
            this.CountOfDoses.Size = new System.Drawing.Size(185, 20);
            this.CountOfDoses.TabIndex = 8;
            // 
            // Purpose
            // 
            this.Purpose.Location = new System.Drawing.Point(105, 114);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(347, 90);
            this.Purpose.TabIndex = 9;
            this.Purpose.Text = "";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(352, 210);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(246, 210);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(100, 23);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(296, 32);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(75, 23);
            this.AddCategory.TabIndex = 12;
            this.AddCategory.Text = "Добавить";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // DeleteCategory
            // 
            this.DeleteCategory.Location = new System.Drawing.Point(377, 32);
            this.DeleteCategory.Name = "DeleteCategory";
            this.DeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.DeleteCategory.TabIndex = 13;
            this.DeleteCategory.Text = "Удалить";
            this.DeleteCategory.UseVisualStyleBackColor = true;
            this.DeleteCategory.Click += new System.EventHandler(this.DeleteCategory_Click);
            // 
            // EditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(464, 241);
            this.Controls.Add(this.DeleteCategory);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Purpose);
            this.Controls.Add(this.CountOfDoses);
            this.Controls.Add(this.Dosage);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.MedicamentName);
            this.Controls.Add(this.PurposeLabel);
            this.Controls.Add(this.NumberOfDosesLabel);
            this.Controls.Add(this.DosageLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMenu";
            this.Text = "Редактирование лекарства";
            ((System.ComponentModel.ISupportInitialize)(this.Dosage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfDoses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label DosageLabel;
        private System.Windows.Forms.Label NumberOfDosesLabel;
        private System.Windows.Forms.Label PurposeLabel;
        private System.Windows.Forms.TextBox MedicamentName;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.NumericUpDown Dosage;
        private System.Windows.Forms.NumericUpDown CountOfDoses;
        private System.Windows.Forms.RichTextBox Purpose;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.Button DeleteCategory;
    }
}