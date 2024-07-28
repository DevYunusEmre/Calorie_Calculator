namespace NES.WFA
{
    partial class FormAnalysis
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnalysis));
            lvByCategory = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            lvByMeal = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            lvCompare = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            rdbWeekly = new RadioButton();
            rdbMonthly = new RadioButton();
            label4 = new Label();
            label1 = new Label();
            cmbxMeals = new ComboBox();
            cmbxNutrientCategory = new ComboBox();
            rdbCompareMonthly = new RadioButton();
            rdbCompareWeekly = new RadioButton();
            panel1 = new Panel();
            chckbxAllMeals = new CheckBox();
            btnCompare = new Button();
            cmbxCompareMeals = new ComboBox();
            guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            label5 = new Label();
            panel1.SuspendLayout();
            guna2CustomGradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lvByCategory
            // 
            lvByCategory.BackColor = Color.White;
            lvByCategory.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader13, columnHeader14, columnHeader16 });
            lvByCategory.FullRowSelect = true;
            lvByCategory.Location = new Point(12, 399);
            lvByCategory.Name = "lvByCategory";
            lvByCategory.Size = new Size(526, 233);
            lvByCategory.TabIndex = 2;
            lvByCategory.UseCompatibleStateImageBehavior = false;
            lvByCategory.View = View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "No";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Nutrient Name";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Total User Quantity";
            columnHeader14.Width = 120;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Total User Calories";
            columnHeader16.Width = 120;
            // 
            // lvByMeal
            // 
            lvByMeal.BackColor = Color.White;
            lvByMeal.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader15 });
            lvByMeal.FullRowSelect = true;
            lvByMeal.Location = new Point(12, 122);
            lvByMeal.Name = "lvByMeal";
            lvByMeal.Size = new Size(526, 237);
            lvByMeal.TabIndex = 3;
            lvByMeal.UseCompatibleStateImageBehavior = false;
            lvByMeal.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "No";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Nutrient Name";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Total User Quantity";
            columnHeader11.Width = 120;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Total User Calories";
            columnHeader15.Width = 120;
            // 
            // lvCompare
            // 
            lvCompare.BackColor = Color.White;
            lvCompare.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4, columnHeader1, columnHeader5 });
            lvCompare.FullRowSelect = true;
            lvCompare.Location = new Point(11, 91);
            lvCompare.Name = "lvCompare";
            lvCompare.Size = new Size(565, 510);
            lvCompare.TabIndex = 4;
            lvCompare.UseCompatibleStateImageBehavior = false;
            lvCompare.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nutrient Name";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Your Calories";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Average Calories";
            columnHeader4.Width = 110;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Your Quantity";
            columnHeader1.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Average Quantity";
            columnHeader5.Width = 110;
            // 
            // rdbWeekly
            // 
            rdbWeekly.AutoSize = true;
            rdbWeekly.Checked = true;
            rdbWeekly.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rdbWeekly.ForeColor = Color.White;
            rdbWeekly.Location = new Point(220, 92);
            rdbWeekly.Name = "rdbWeekly";
            rdbWeekly.Size = new Size(78, 24);
            rdbWeekly.TabIndex = 9;
            rdbWeekly.TabStop = true;
            rdbWeekly.Text = "Weekly";
            rdbWeekly.UseVisualStyleBackColor = true;
            // 
            // rdbMonthly
            // 
            rdbMonthly.AutoSize = true;
            rdbMonthly.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rdbMonthly.ForeColor = Color.White;
            rdbMonthly.Location = new Point(304, 92);
            rdbMonthly.Name = "rdbMonthly";
            rdbMonthly.Size = new Size(86, 24);
            rdbMonthly.TabIndex = 10;
            rdbMonthly.Text = "Monthly";
            rdbMonthly.UseVisualStyleBackColor = true;
            rdbMonthly.CheckedChanged += rdbMonthly_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 94);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 11;
            label4.Text = "By Meal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 371);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 12;
            label1.Text = "By Category";
            // 
            // cmbxMeals
            // 
            cmbxMeals.BackColor = Color.Black;
            cmbxMeals.ForeColor = Color.White;
            cmbxMeals.FormattingEnabled = true;
            cmbxMeals.Location = new Point(396, 92);
            cmbxMeals.Name = "cmbxMeals";
            cmbxMeals.Size = new Size(142, 23);
            cmbxMeals.TabIndex = 15;
            cmbxMeals.SelectedIndexChanged += cmbxMeals_SelectedIndexChanged_1;
            // 
            // cmbxNutrientCategory
            // 
            cmbxNutrientCategory.BackColor = Color.Black;
            cmbxNutrientCategory.ForeColor = Color.White;
            cmbxNutrientCategory.FormattingEnabled = true;
            cmbxNutrientCategory.Location = new Point(396, 370);
            cmbxNutrientCategory.Name = "cmbxNutrientCategory";
            cmbxNutrientCategory.Size = new Size(142, 23);
            cmbxNutrientCategory.TabIndex = 16;
            cmbxNutrientCategory.SelectedIndexChanged += cmbxNutrientCategory_SelectedIndexChanged;
            // 
            // rdbCompareMonthly
            // 
            rdbCompareMonthly.AutoSize = true;
            rdbCompareMonthly.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rdbCompareMonthly.ForeColor = Color.White;
            rdbCompareMonthly.Location = new Point(95, 3);
            rdbCompareMonthly.Name = "rdbCompareMonthly";
            rdbCompareMonthly.Size = new Size(86, 24);
            rdbCompareMonthly.TabIndex = 17;
            rdbCompareMonthly.Text = "Monthly";
            rdbCompareMonthly.UseVisualStyleBackColor = true;
            // 
            // rdbCompareWeekly
            // 
            rdbCompareWeekly.AutoSize = true;
            rdbCompareWeekly.Checked = true;
            rdbCompareWeekly.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rdbCompareWeekly.ForeColor = Color.White;
            rdbCompareWeekly.Location = new Point(11, 3);
            rdbCompareWeekly.Name = "rdbCompareWeekly";
            rdbCompareWeekly.Size = new Size(78, 24);
            rdbCompareWeekly.TabIndex = 18;
            rdbCompareWeekly.TabStop = true;
            rdbCompareWeekly.Text = "Weekly";
            rdbCompareWeekly.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lvCompare);
            panel1.Controls.Add(chckbxAllMeals);
            panel1.Controls.Add(btnCompare);
            panel1.Controls.Add(cmbxCompareMeals);
            panel1.Controls.Add(rdbCompareWeekly);
            panel1.Controls.Add(rdbCompareMonthly);
            panel1.Location = new Point(544, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 611);
            panel1.TabIndex = 19;
            // 
            // chckbxAllMeals
            // 
            chckbxAllMeals.AutoSize = true;
            chckbxAllMeals.ForeColor = Color.White;
            chckbxAllMeals.Location = new Point(11, 37);
            chckbxAllMeals.Name = "chckbxAllMeals";
            chckbxAllMeals.Size = new Size(74, 19);
            chckbxAllMeals.TabIndex = 21;
            chckbxAllMeals.Text = "All Meals";
            chckbxAllMeals.UseVisualStyleBackColor = true;
            // 
            // btnCompare
            // 
            btnCompare.BackColor = Color.White;
            btnCompare.FlatStyle = FlatStyle.Flat;
            btnCompare.Font = new Font("Segoe UI", 14.25F);
            btnCompare.ForeColor = Color.Black;
            btnCompare.Location = new Point(333, 38);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(212, 47);
            btnCompare.TabIndex = 20;
            btnCompare.Text = "Compare";
            btnCompare.UseVisualStyleBackColor = false;
            btnCompare.Click += btnCompare_Click;
            // 
            // cmbxCompareMeals
            // 
            cmbxCompareMeals.BackColor = Color.Black;
            cmbxCompareMeals.ForeColor = Color.White;
            cmbxCompareMeals.FormattingEnabled = true;
            cmbxCompareMeals.Location = new Point(11, 62);
            cmbxCompareMeals.Name = "cmbxCompareMeals";
            cmbxCompareMeals.Size = new Size(142, 23);
            cmbxCompareMeals.TabIndex = 20;
            // 
            // guna2CustomGradientPanel2
            // 
            guna2CustomGradientPanel2.Controls.Add(label5);
            guna2CustomGradientPanel2.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel2.FillColor = Color.Black;
            guna2CustomGradientPanel2.FillColor2 = Color.Black;
            guna2CustomGradientPanel2.FillColor3 = Color.Black;
            guna2CustomGradientPanel2.FillColor4 = Color.Maroon;
            guna2CustomGradientPanel2.Location = new Point(12, 12);
            guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel2.Size = new Size(218, 56);
            guna2CustomGradientPanel2.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 9);
            label5.Name = "label5";
            label5.Size = new Size(143, 37);
            label5.TabIndex = 17;
            label5.Text = "ANALYSIS";
            // 
            // FormAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1130, 866);
            Controls.Add(guna2CustomGradientPanel2);
            Controls.Add(panel1);
            Controls.Add(cmbxMeals);
            Controls.Add(cmbxNutrientCategory);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(rdbMonthly);
            Controls.Add(rdbWeekly);
            Controls.Add(lvByMeal);
            Controls.Add(lvByCategory);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAnalysis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += FormAnalysis_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            guna2CustomGradientPanel2.ResumeLayout(false);
            guna2CustomGradientPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvByCategory;
        private ListView lvByMeal;
        private ListView lvCompare;
        private RadioButton rdbWeekly;
        private RadioButton rdbMonthly;
        private Label label4;
        private Label label1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader15;
        private ComboBox cmbxMeals;
        private ComboBox cmbxNutrientCategory;
        private RadioButton rdbCompareMonthly;
        private RadioButton rdbCompareWeekly;
        private Panel panel1;
        private ComboBox cmbxCompareMeals;
        private Button btnCompare;
        private CheckBox chckbxAllMeals;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader5;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Label label5;
    }
}