using Catalog.Data;

namespace Catalog
{
    partial class StartMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
			this.Review = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.MedicamentsList = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Category = new System.Windows.Forms.ComboBox();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.Purpose = new System.Windows.Forms.RichTextBox();
			this.ShelfLife = new System.Windows.Forms.TextBox();
			this.DateOfIssue = new System.Windows.Forms.TextBox();
			this.CountOfDoses = new System.Windows.Forms.TextBox();
			this.Dosage = new System.Windows.Forms.TextBox();
			this.MedicamentName = new System.Windows.Forms.TextBox();
			this.PurposeLabel = new System.Windows.Forms.Label();
			this.ShelfLifeLabel = new System.Windows.Forms.Label();
			this.DateOfIssueLabel = new System.Windows.Forms.Label();
			this.NumberOfDosesLabel = new System.Windows.Forms.Label();
			this.DosageLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.Edit = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.Save = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.Search = new System.Windows.Forms.Button();
			this.Add = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Review
			// 
			resources.ApplyResources(this.Review, "Review");
			this.Review.Name = "Review";
			this.Review.UseVisualStyleBackColor = true;
			this.Review.Click += new System.EventHandler(this.Review_Click);
			// 
			// MedicamentsList
			// 
			resources.ApplyResources(this.MedicamentsList, "MedicamentsList");
			this.MedicamentsList.FormattingEnabled = true;
			this.MedicamentsList.Items.AddRange(new object[] {
            resources.GetString("MedicamentsList.Items")});
			this.MedicamentsList.Name = "MedicamentsList";
			this.MedicamentsList.SelectedIndexChanged += new System.EventHandler(this.MedicamentsList_SelectedIndexChanged);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Category);
			this.groupBox1.Controls.Add(this.CategoryLabel);
			this.groupBox1.Controls.Add(this.Purpose);
			this.groupBox1.Controls.Add(this.ShelfLife);
			this.groupBox1.Controls.Add(this.DateOfIssue);
			this.groupBox1.Controls.Add(this.CountOfDoses);
			this.groupBox1.Controls.Add(this.Dosage);
			this.groupBox1.Controls.Add(this.MedicamentName);
			this.groupBox1.Controls.Add(this.PurposeLabel);
			this.groupBox1.Controls.Add(this.ShelfLifeLabel);
			this.groupBox1.Controls.Add(this.DateOfIssueLabel);
			this.groupBox1.Controls.Add(this.NumberOfDosesLabel);
			this.groupBox1.Controls.Add(this.DosageLabel);
			this.groupBox1.Controls.Add(this.NameLabel);
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// Category
			// 
			this.Category.BackColor = System.Drawing.SystemColors.ControlLightLight;
			resources.ApplyResources(this.Category, "Category");
			this.Category.FormattingEnabled = true;
			this.Category.Name = "Category";
			this.Category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
			// 
			// CategoryLabel
			// 
			resources.ApplyResources(this.CategoryLabel, "CategoryLabel");
			this.CategoryLabel.Name = "CategoryLabel";
			// 
			// Purpose
			// 
			this.Purpose.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Purpose.Cursor = System.Windows.Forms.Cursors.IBeam;
			resources.ApplyResources(this.Purpose, "Purpose");
			this.Purpose.Name = "Purpose";
			this.Purpose.ReadOnly = true;
			// 
			// ShelfLife
			// 
			this.ShelfLife.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ShelfLife.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.ShelfLife, "ShelfLife");
			this.ShelfLife.Name = "ShelfLife";
			this.ShelfLife.ReadOnly = true;
			// 
			// DateOfIssue
			// 
			this.DateOfIssue.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.DateOfIssue.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.DateOfIssue, "DateOfIssue");
			this.DateOfIssue.Name = "DateOfIssue";
			this.DateOfIssue.ReadOnly = true;
			// 
			// CountOfDoses
			// 
			this.CountOfDoses.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.CountOfDoses.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.CountOfDoses, "CountOfDoses");
			this.CountOfDoses.Name = "CountOfDoses";
			this.CountOfDoses.ReadOnly = true;
			// 
			// Dosage
			// 
			this.Dosage.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Dosage.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.Dosage, "Dosage");
			this.Dosage.Name = "Dosage";
			this.Dosage.ReadOnly = true;
			// 
			// MedicamentName
			// 
			this.MedicamentName.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.MedicamentName.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.MedicamentName, "MedicamentName");
			this.MedicamentName.Name = "MedicamentName";
			this.MedicamentName.ReadOnly = true;
			// 
			// PurposeLabel
			// 
			resources.ApplyResources(this.PurposeLabel, "PurposeLabel");
			this.PurposeLabel.Name = "PurposeLabel";
			// 
			// ShelfLifeLabel
			// 
			resources.ApplyResources(this.ShelfLifeLabel, "ShelfLifeLabel");
			this.ShelfLifeLabel.Name = "ShelfLifeLabel";
			// 
			// DateOfIssueLabel
			// 
			resources.ApplyResources(this.DateOfIssueLabel, "DateOfIssueLabel");
			this.DateOfIssueLabel.Name = "DateOfIssueLabel";
			// 
			// NumberOfDosesLabel
			// 
			resources.ApplyResources(this.NumberOfDosesLabel, "NumberOfDosesLabel");
			this.NumberOfDosesLabel.Name = "NumberOfDosesLabel";
			// 
			// DosageLabel
			// 
			resources.ApplyResources(this.DosageLabel, "DosageLabel");
			this.DosageLabel.Name = "DosageLabel";
			// 
			// NameLabel
			// 
			resources.ApplyResources(this.NameLabel, "NameLabel");
			this.NameLabel.Name = "NameLabel";
			// 
			// Edit
			// 
			resources.ApplyResources(this.Edit, "Edit");
			this.Edit.Name = "Edit";
			this.Edit.UseVisualStyleBackColor = true;
			this.Edit.Click += new System.EventHandler(this.Edit_Click);
			// 
			// Delete
			// 
			resources.ApplyResources(this.Delete, "Delete");
			this.Delete.Name = "Delete";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// Save
			// 
			resources.ApplyResources(this.Save, "Save");
			this.Save.Name = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "Новый текстовый документ.txt";
			// 
			// Search
			// 
			resources.ApplyResources(this.Search, "Search");
			this.Search.Name = "Search";
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// Add
			// 
			resources.ApplyResources(this.Add, "Add");
			this.Add.Name = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// StartMenu
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.Controls.Add(this.Search);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Edit);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MedicamentsList);
			this.Controls.Add(this.Review);
			this.MaximizeBox = false;
			this.Name = "StartMenu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartMenu_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox Purpose;
        private System.Windows.Forms.ListBox MedicamentsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Review;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox ShelfLife;
        private System.Windows.Forms.TextBox DateOfIssue;
        private System.Windows.Forms.TextBox CountOfDoses;
        private System.Windows.Forms.TextBox Dosage;
        private System.Windows.Forms.TextBox MedicamentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DosageLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PurposeLabel;
        private System.Windows.Forms.Label ShelfLifeLabel;
        private System.Windows.Forms.Label DateOfIssueLabel;
        private System.Windows.Forms.Label NumberOfDosesLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Button Search;
		private System.Windows.Forms.Button Add;
	}
}

