namespace Catalog
{
    partial class AddMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMenu));
			this.NameLabel = new System.Windows.Forms.Label();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.DosageLabel = new System.Windows.Forms.Label();
			this.NumberOfDosesLabel = new System.Windows.Forms.Label();
			this.DateOfIssueLabel = new System.Windows.Forms.Label();
			this.ShelfLifeLabel = new System.Windows.Forms.Label();
			this.PurposeLabel = new System.Windows.Forms.Label();
			this.MedicamentName = new System.Windows.Forms.TextBox();
			this.Category = new System.Windows.Forms.ComboBox();
			this.Dosage = new System.Windows.Forms.NumericUpDown();
			this.CountOfDoses = new System.Windows.Forms.NumericUpDown();
			this.Purpose = new System.Windows.Forms.RichTextBox();
			this.DateOfIssue = new System.Windows.Forms.DateTimePicker();
			this.ShelfLife = new System.Windows.Forms.DateTimePicker();
			this.AddMedicament = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.AddCategory = new System.Windows.Forms.Button();
			this.DeleteCategory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Dosage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CountOfDoses)).BeginInit();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			resources.ApplyResources(this.NameLabel, "NameLabel");
			this.NameLabel.Name = "NameLabel";
			// 
			// CategoryLabel
			// 
			resources.ApplyResources(this.CategoryLabel, "CategoryLabel");
			this.CategoryLabel.Name = "CategoryLabel";
			// 
			// DosageLabel
			// 
			resources.ApplyResources(this.DosageLabel, "DosageLabel");
			this.DosageLabel.Name = "DosageLabel";
			// 
			// NumberOfDosesLabel
			// 
			resources.ApplyResources(this.NumberOfDosesLabel, "NumberOfDosesLabel");
			this.NumberOfDosesLabel.Name = "NumberOfDosesLabel";
			// 
			// DateOfIssueLabel
			// 
			resources.ApplyResources(this.DateOfIssueLabel, "DateOfIssueLabel");
			this.DateOfIssueLabel.Name = "DateOfIssueLabel";
			// 
			// ShelfLifeLabel
			// 
			resources.ApplyResources(this.ShelfLifeLabel, "ShelfLifeLabel");
			this.ShelfLifeLabel.Name = "ShelfLifeLabel";
			// 
			// PurposeLabel
			// 
			resources.ApplyResources(this.PurposeLabel, "PurposeLabel");
			this.PurposeLabel.Name = "PurposeLabel";
			// 
			// MedicamentName
			// 
			resources.ApplyResources(this.MedicamentName, "MedicamentName");
			this.MedicamentName.Name = "MedicamentName";
			this.MedicamentName.Click += new System.EventHandler(this.MedicamentName_Click);
			// 
			// Category
			// 
			this.Category.FormattingEnabled = true;
			resources.ApplyResources(this.Category, "Category");
			this.Category.Name = "Category";
			this.Category.Click += new System.EventHandler(this.Category_Click);
			// 
			// Dosage
			// 
			resources.ApplyResources(this.Dosage, "Dosage");
			this.Dosage.Name = "Dosage";
			this.Dosage.Click += new System.EventHandler(this.Dosage_Click);
			// 
			// CountOfDoses
			// 
			resources.ApplyResources(this.CountOfDoses, "CountOfDoses");
			this.CountOfDoses.Name = "CountOfDoses";
			// 
			// Purpose
			// 
			resources.ApplyResources(this.Purpose, "Purpose");
			this.Purpose.Name = "Purpose";
			// 
			// DateOfIssue
			// 
			resources.ApplyResources(this.DateOfIssue, "DateOfIssue");
			this.DateOfIssue.Name = "DateOfIssue";
			// 
			// ShelfLife
			// 
			resources.ApplyResources(this.ShelfLife, "ShelfLife");
			this.ShelfLife.Name = "ShelfLife";
			// 
			// AddMedicament
			// 
			resources.ApplyResources(this.AddMedicament, "AddMedicament");
			this.AddMedicament.Name = "AddMedicament";
			this.AddMedicament.UseVisualStyleBackColor = true;
			this.AddMedicament.Click += new System.EventHandler(this.AddMedicament_Click);
			// 
			// Cancel
			// 
			resources.ApplyResources(this.Cancel, "Cancel");
			this.Cancel.Name = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// AddCategory
			// 
			resources.ApplyResources(this.AddCategory, "AddCategory");
			this.AddCategory.Name = "AddCategory";
			this.AddCategory.UseVisualStyleBackColor = true;
			this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
			// 
			// DeleteCategory
			// 
			resources.ApplyResources(this.DeleteCategory, "DeleteCategory");
			this.DeleteCategory.Name = "DeleteCategory";
			this.DeleteCategory.UseVisualStyleBackColor = true;
			this.DeleteCategory.Click += new System.EventHandler(this.DeleteCategory_Click);
			// 
			// AddMenu
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.Controls.Add(this.DeleteCategory);
			this.Controls.Add(this.AddCategory);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.AddMedicament);
			this.Controls.Add(this.ShelfLife);
			this.Controls.Add(this.DateOfIssue);
			this.Controls.Add(this.Purpose);
			this.Controls.Add(this.CountOfDoses);
			this.Controls.Add(this.Dosage);
			this.Controls.Add(this.Category);
			this.Controls.Add(this.MedicamentName);
			this.Controls.Add(this.PurposeLabel);
			this.Controls.Add(this.ShelfLifeLabel);
			this.Controls.Add(this.DateOfIssueLabel);
			this.Controls.Add(this.NumberOfDosesLabel);
			this.Controls.Add(this.DosageLabel);
			this.Controls.Add(this.CategoryLabel);
			this.Controls.Add(this.NameLabel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddMenu";
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
        private System.Windows.Forms.Label DateOfIssueLabel;
        private System.Windows.Forms.Label ShelfLifeLabel;
        private System.Windows.Forms.Label PurposeLabel;
        private System.Windows.Forms.TextBox MedicamentName;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.NumericUpDown Dosage;
        private System.Windows.Forms.NumericUpDown CountOfDoses;
        private System.Windows.Forms.RichTextBox Purpose;
        private System.Windows.Forms.DateTimePicker DateOfIssue;
        private System.Windows.Forms.DateTimePicker ShelfLife;
        private System.Windows.Forms.Button AddMedicament;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.Button DeleteCategory;
    }
}