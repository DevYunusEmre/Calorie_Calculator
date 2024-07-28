namespace NES.WFA
{
    partial class FormDiary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiary));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lvDiaryNutritions = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lstvDiaryOther = new ListView();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            label1 = new Label();
            txtDiarySearch = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblDiaryTotalCalorie = new Label();
            label4 = new Label();
            cmbMeal = new ComboBox();
            btnDiaryDelete = new Button();
            btnDiaryAdd = new Button();
            lstvDiaryDinner = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            lstvDiaryLunch = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            lstvDiaryBreakfast = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            label5 = new Label();
            txtQuantity = new TextBox();
            label3 = new Label();
            pcrNutrient = new PictureBox();
            guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcrNutrient).BeginInit();
            guna2CustomGradientPanel3.SuspendLayout();
            guna2CustomGradientPanel1.SuspendLayout();
            guna2CustomGradientPanel2.SuspendLayout();
            guna2CustomGradientPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // lvDiaryNutritions
            // 
            lvDiaryNutritions.BackColor = Color.White;
            lvDiaryNutritions.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvDiaryNutritions.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lvDiaryNutritions.FullRowSelect = true;
            lvDiaryNutritions.Location = new Point(24, 231);
            lvDiaryNutritions.Name = "lvDiaryNutritions";
            lvDiaryNutritions.Size = new Size(550, 475);
            lvDiaryNutritions.TabIndex = 0;
            lvDiaryNutritions.UseCompatibleStateImageBehavior = false;
            lvDiaryNutritions.View = View.Details;
            lvDiaryNutritions.SelectedIndexChanged += lstvDiaryNutritions_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Category";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Calorie";
            columnHeader3.Width = 120;
            // 
            // lstvDiaryOther
            // 
            lstvDiaryOther.BackColor = Color.White;
            lstvDiaryOther.Columns.AddRange(new ColumnHeader[] { columnHeader16, columnHeader17, columnHeader18, columnHeader19 });
            lstvDiaryOther.Font = new Font("Segoe UI", 11.25F);
            lstvDiaryOther.FullRowSelect = true;
            lstvDiaryOther.Location = new Point(644, 399);
            lstvDiaryOther.Name = "lstvDiaryOther";
            lstvDiaryOther.Size = new Size(467, 125);
            lstvDiaryOther.TabIndex = 4;
            lstvDiaryOther.UseCompatibleStateImageBehavior = false;
            lstvDiaryOther.View = View.Details;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Name";
            columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Category";
            columnHeader17.Width = 120;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Quantity";
            columnHeader18.Width = 100;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Total Calories";
            columnHeader19.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 12);
            label1.Name = "label1";
            label1.Size = new Size(138, 37);
            label1.TabIndex = 5;
            label1.Text = "Nutrients";
            // 
            // txtDiarySearch
            // 
            txtDiarySearch.BackColor = Color.White;
            txtDiarySearch.Location = new Point(64, 193);
            txtDiarySearch.Name = "txtDiarySearch";
            txtDiarySearch.Size = new Size(218, 23);
            txtDiarySearch.TabIndex = 6;
            txtDiarySearch.TextChanged += txtDiarySearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 17);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 8;
            label2.Text = "Total Calorie (cal)";
            // 
            // lblDiaryTotalCalorie
            // 
            lblDiaryTotalCalorie.BackColor = Color.White;
            lblDiaryTotalCalorie.Font = new Font("Segoe UI", 14.25F);
            lblDiaryTotalCalorie.ForeColor = Color.Black;
            lblDiaryTotalCalorie.Location = new Point(229, 17);
            lblDiaryTotalCalorie.Name = "lblDiaryTotalCalorie";
            lblDiaryTotalCalorie.Size = new Size(218, 25);
            lblDiaryTotalCalorie.TabIndex = 9;
            lblDiaryTotalCalorie.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 97);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 10;
            label4.Text = "Meal:";
            // 
            // cmbMeal
            // 
            cmbMeal.BackColor = Color.White;
            cmbMeal.ForeColor = Color.Black;
            cmbMeal.FormattingEnabled = true;
            cmbMeal.Location = new Point(229, 98);
            cmbMeal.Name = "cmbMeal";
            cmbMeal.Size = new Size(218, 23);
            cmbMeal.TabIndex = 11;
            // 
            // btnDiaryDelete
            // 
            btnDiaryDelete.BackColor = Color.White;
            btnDiaryDelete.FlatStyle = FlatStyle.Flat;
            btnDiaryDelete.Font = new Font("Segoe UI", 14.25F);
            btnDiaryDelete.ForeColor = Color.Black;
            btnDiaryDelete.Location = new Point(19, 136);
            btnDiaryDelete.Name = "btnDiaryDelete";
            btnDiaryDelete.Size = new Size(171, 40);
            btnDiaryDelete.TabIndex = 12;
            btnDiaryDelete.Text = "Delete";
            btnDiaryDelete.UseVisualStyleBackColor = false;
            btnDiaryDelete.Click += btnDiaryDelete_Click;
            // 
            // btnDiaryAdd
            // 
            btnDiaryAdd.BackColor = Color.White;
            btnDiaryAdd.FlatStyle = FlatStyle.Flat;
            btnDiaryAdd.Font = new Font("Segoe UI", 14.25F);
            btnDiaryAdd.ForeColor = Color.Black;
            btnDiaryAdd.Location = new Point(276, 136);
            btnDiaryAdd.Name = "btnDiaryAdd";
            btnDiaryAdd.Size = new Size(171, 40);
            btnDiaryAdd.TabIndex = 13;
            btnDiaryAdd.Text = "Add";
            btnDiaryAdd.UseVisualStyleBackColor = false;
            btnDiaryAdd.Click += btnDiaryAdd_Click;
            // 
            // lstvDiaryDinner
            // 
            lstvDiaryDinner.BackColor = Color.White;
            lstvDiaryDinner.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader13, columnHeader14, columnHeader15 });
            lstvDiaryDinner.Font = new Font("Segoe UI", 11.25F);
            lstvDiaryDinner.FullRowSelect = true;
            lstvDiaryDinner.Location = new Point(644, 268);
            lstvDiaryDinner.Name = "lstvDiaryDinner";
            lstvDiaryDinner.Size = new Size(467, 125);
            lstvDiaryDinner.TabIndex = 14;
            lstvDiaryDinner.UseCompatibleStateImageBehavior = false;
            lstvDiaryDinner.View = View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Name";
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Category";
            columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Quantity";
            columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Total Calories";
            columnHeader15.Width = 150;
            // 
            // lstvDiaryLunch
            // 
            lstvDiaryLunch.BackColor = Color.White;
            lstvDiaryLunch.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            lstvDiaryLunch.Font = new Font("Segoe UI", 11.25F);
            lstvDiaryLunch.FullRowSelect = true;
            lstvDiaryLunch.Location = new Point(644, 137);
            lstvDiaryLunch.Name = "lstvDiaryLunch";
            lstvDiaryLunch.Size = new Size(467, 125);
            lstvDiaryLunch.TabIndex = 15;
            lstvDiaryLunch.UseCompatibleStateImageBehavior = false;
            lstvDiaryLunch.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Name";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Category";
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Quantity";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Total Calories";
            columnHeader11.Width = 150;
            // 
            // lstvDiaryBreakfast
            // 
            lstvDiaryBreakfast.BackColor = Color.White;
            lstvDiaryBreakfast.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lstvDiaryBreakfast.Font = new Font("Segoe UI", 11.25F);
            lstvDiaryBreakfast.ForeColor = Color.Black;
            lstvDiaryBreakfast.FullRowSelect = true;
            lstvDiaryBreakfast.Location = new Point(644, 6);
            lstvDiaryBreakfast.Name = "lstvDiaryBreakfast";
            lstvDiaryBreakfast.Size = new Size(467, 125);
            lstvDiaryBreakfast.TabIndex = 16;
            lstvDiaryBreakfast.UseCompatibleStateImageBehavior = false;
            lstvDiaryBreakfast.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Name";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Category";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Quantity";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Total Calories";
            columnHeader7.Width = 150;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(56, 9);
            label5.Name = "label5";
            label5.Size = new Size(99, 37);
            label5.TabIndex = 17;
            label5.Text = "DIARY";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.White;
            txtQuantity.ForeColor = Color.Black;
            txtQuantity.Location = new Point(229, 58);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(218, 23);
            txtQuantity.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 57);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 19;
            label3.Text = "Quantity (gr):";
            // 
            // pcrNutrient
            // 
            pcrNutrient.BackColor = Color.Black;
            pcrNutrient.Image = (Image)resources.GetObject("pcrNutrient.Image");
            pcrNutrient.Location = new Point(12, 10);
            pcrNutrient.Name = "pcrNutrient";
            pcrNutrient.Size = new Size(252, 197);
            pcrNutrient.SizeMode = PictureBoxSizeMode.StretchImage;
            pcrNutrient.TabIndex = 20;
            pcrNutrient.TabStop = false;
            pcrNutrient.Click += pcrNutrient_Click;
            // 
            // guna2CustomGradientPanel3
            // 
            guna2CustomGradientPanel3.Controls.Add(pcrNutrient);
            guna2CustomGradientPanel3.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel3.FillColor = Color.Black;
            guna2CustomGradientPanel3.FillColor2 = Color.Black;
            guna2CustomGradientPanel3.FillColor3 = Color.Black;
            guna2CustomGradientPanel3.FillColor4 = Color.Maroon;
            guna2CustomGradientPanel3.Location = new Point(299, 9);
            guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel3.Size = new Size(275, 216);
            guna2CustomGradientPanel3.TabIndex = 21;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(label1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel1.FillColor = Color.Black;
            guna2CustomGradientPanel1.FillColor2 = Color.Black;
            guna2CustomGradientPanel1.FillColor3 = Color.Black;
            guna2CustomGradientPanel1.FillColor4 = Color.Maroon;
            guna2CustomGradientPanel1.Location = new Point(64, 131);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel1.Size = new Size(218, 56);
            guna2CustomGradientPanel1.TabIndex = 22;
            // 
            // guna2CustomGradientPanel2
            // 
            guna2CustomGradientPanel2.Controls.Add(label5);
            guna2CustomGradientPanel2.CustomizableEdges = customizableEdges5;
            guna2CustomGradientPanel2.FillColor = Color.Black;
            guna2CustomGradientPanel2.FillColor2 = Color.Black;
            guna2CustomGradientPanel2.FillColor3 = Color.Black;
            guna2CustomGradientPanel2.FillColor4 = Color.Maroon;
            guna2CustomGradientPanel2.Location = new Point(12, 9);
            guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CustomGradientPanel2.Size = new Size(218, 56);
            guna2CustomGradientPanel2.TabIndex = 23;
            // 
            // guna2CustomGradientPanel4
            // 
            guna2CustomGradientPanel4.Controls.Add(label2);
            guna2CustomGradientPanel4.Controls.Add(lblDiaryTotalCalorie);
            guna2CustomGradientPanel4.Controls.Add(label4);
            guna2CustomGradientPanel4.Controls.Add(cmbMeal);
            guna2CustomGradientPanel4.Controls.Add(label3);
            guna2CustomGradientPanel4.Controls.Add(btnDiaryDelete);
            guna2CustomGradientPanel4.Controls.Add(txtQuantity);
            guna2CustomGradientPanel4.Controls.Add(btnDiaryAdd);
            guna2CustomGradientPanel4.CustomizableEdges = customizableEdges7;
            guna2CustomGradientPanel4.FillColor = Color.Black;
            guna2CustomGradientPanel4.FillColor2 = Color.Black;
            guna2CustomGradientPanel4.FillColor3 = Color.Black;
            guna2CustomGradientPanel4.FillColor4 = Color.Maroon;
            guna2CustomGradientPanel4.Location = new Point(644, 530);
            guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            guna2CustomGradientPanel4.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2CustomGradientPanel4.Size = new Size(467, 191);
            guna2CustomGradientPanel4.TabIndex = 26;
            // 
            // FormDiary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1133, 722);
            Controls.Add(guna2CustomGradientPanel4);
            Controls.Add(guna2CustomGradientPanel2);
            Controls.Add(guna2CustomGradientPanel3);
            Controls.Add(lstvDiaryBreakfast);
            Controls.Add(lstvDiaryLunch);
            Controls.Add(lstvDiaryDinner);
            Controls.Add(pictureBox1);
            Controls.Add(txtDiarySearch);
            Controls.Add(lstvDiaryOther);
            Controls.Add(lvDiaryNutritions);
            Controls.Add(guna2CustomGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDiary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += FormDiary_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcrNutrient).EndInit();
            guna2CustomGradientPanel3.ResumeLayout(false);
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            guna2CustomGradientPanel2.ResumeLayout(false);
            guna2CustomGradientPanel2.PerformLayout();
            guna2CustomGradientPanel4.ResumeLayout(false);
            guna2CustomGradientPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvDiaryNutritions;
        private ListView lstvDiaryOther;
        private Label label1;
        private TextBox txtDiarySearch;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblDiaryTotalCalorie;
        private Label label4;
        private ComboBox cmbMeal;
        private Button btnDiaryDelete;
        private Button btnDiaryAdd;
        private ListView lstvDiaryDinner;
        private ListView lstvDiaryLunch;
        private ListView lstvDiaryBreakfast;
        private Label label5;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtQuantity;
        private Label label3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private PictureBox pcrNutrient;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
    }
}