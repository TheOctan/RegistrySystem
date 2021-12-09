namespace Catalog
{
    partial class SearchMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMenu));
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DosageLabel = new System.Windows.Forms.Label();
            this.ShelfLifeLabel = new System.Windows.Forms.Label();
            this.MedicamentName = new System.Windows.Forms.TextBox();
            this.Dosage = new System.Windows.Forms.NumericUpDown();
            this.ShelfLife = new System.Windows.Forms.DateTimePicker();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Find = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dosage)).BeginInit();
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
            this.CategoryLabel.Location = new System.Drawing.Point(12, 41);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(60, 13);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Категория";
            // 
            // DosageLabel
            // 
            this.DosageLabel.AutoSize = true;
            this.DosageLabel.Location = new System.Drawing.Point(12, 67);
            this.DosageLabel.Name = "DosageLabel";
            this.DosageLabel.Size = new System.Drawing.Size(64, 13);
            this.DosageLabel.TabIndex = 2;
            this.DosageLabel.Text = "Дозировка";
            // 
            // ShelfLifeLabel
            // 
            this.ShelfLifeLabel.AutoSize = true;
            this.ShelfLifeLabel.Location = new System.Drawing.Point(12, 91);
            this.ShelfLifeLabel.Name = "ShelfLifeLabel";
            this.ShelfLifeLabel.Size = new System.Drawing.Size(81, 13);
            this.ShelfLifeLabel.TabIndex = 3;
            this.ShelfLifeLabel.Text = "Срок годности";
            // 
            // MedicamentName
            // 
            this.MedicamentName.Location = new System.Drawing.Point(99, 12);
            this.MedicamentName.Name = "MedicamentName";
            this.MedicamentName.Size = new System.Drawing.Size(185, 20);
            this.MedicamentName.TabIndex = 4;
            // 
            // Dosage
            // 
            this.Dosage.Location = new System.Drawing.Point(99, 65);
            this.Dosage.Name = "Dosage";
            this.Dosage.Size = new System.Drawing.Size(185, 20);
            this.Dosage.TabIndex = 6;
            // 
            // ShelfLife
            // 
            this.ShelfLife.Enabled = false;
            this.ShelfLife.Location = new System.Drawing.Point(99, 91);
            this.ShelfLife.Name = "ShelfLife";
            this.ShelfLife.Size = new System.Drawing.Size(164, 20);
            this.ShelfLife.TabIndex = 7;
            // 
            // Category
            // 
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(98, 38);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(186, 21);
            this.Category.TabIndex = 8;
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(78, 117);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(100, 23);
            this.Find.TabIndex = 9;
            this.Find.Text = "Найти";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(184, 117);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(269, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SearchMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(297, 147);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.ShelfLife);
            this.Controls.Add(this.Dosage);
            this.Controls.Add(this.MedicamentName);
            this.Controls.Add(this.ShelfLifeLabel);
            this.Controls.Add(this.DosageLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchMenu";
            this.Text = "Поиск медикамента";
            ((System.ComponentModel.ISupportInitialize)(this.Dosage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label DosageLabel;
        private System.Windows.Forms.Label ShelfLifeLabel;
        private System.Windows.Forms.TextBox MedicamentName;
        private System.Windows.Forms.NumericUpDown Dosage;
        private System.Windows.Forms.DateTimePicker ShelfLife;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}