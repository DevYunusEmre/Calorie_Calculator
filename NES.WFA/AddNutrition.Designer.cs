namespace NES.WFA
{
    partial class FormAddNutrition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNutrition));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox1 = new GroupBox();
            btnNutritionDelete = new Button();
            btnNutritionUpdate = new Button();
            btnNutritionAdd = new Button();
            cmbxNutrientCategory = new ComboBox();
            label4 = new Label();
            txtNutrientCalorie = new TextBox();
            label2 = new Label();
            txtNutrientName = new TextBox();
            label1 = new Label();
            pcrAddNutrition = new PictureBox();
            lvNutritionAdd = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcrAddNutrition).BeginInit();
            guna2CustomGradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNutritionDelete);
            groupBox1.Controls.Add(btnNutritionUpdate);
            groupBox1.Controls.Add(btnNutritionAdd);
            groupBox1.Controls.Add(cmbxNutrientCategory);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNutrientCalorie);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNutrientName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pcrAddNutrition);
            groupBox1.Location = new Point(23, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 522);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnNutritionDelete
            // 
            btnNutritionDelete.FlatStyle = FlatStyle.Flat;
            btnNutritionDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNutritionDelete.ForeColor = Color.White;
            btnNutritionDelete.Location = new Point(258, 391);
            btnNutritionDelete.Name = "btnNutritionDelete";
            btnNutritionDelete.Size = new Size(75, 59);
            btnNutritionDelete.TabIndex = 9;
            btnNutritionDelete.Text = "Delete";
            btnNutritionDelete.UseVisualStyleBackColor = true;
            btnNutritionDelete.Click += btnNutritionDelete_Click;
            // 
            // btnNutritionUpdate
            // 
            btnNutritionUpdate.FlatStyle = FlatStyle.Flat;
            btnNutritionUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNutritionUpdate.ForeColor = Color.White;
            btnNutritionUpdate.Location = new Point(141, 391);
            btnNutritionUpdate.Name = "btnNutritionUpdate";
            btnNutritionUpdate.Size = new Size(75, 59);
            btnNutritionUpdate.TabIndex = 8;
            btnNutritionUpdate.Text = "Update";
            btnNutritionUpdate.UseVisualStyleBackColor = true;
            btnNutritionUpdate.Click += btnNutritionUpdate_Click;
            // 
            // btnNutritionAdd
            // 
            btnNutritionAdd.FlatStyle = FlatStyle.Flat;
            btnNutritionAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnNutritionAdd.ForeColor = Color.White;
            btnNutritionAdd.Location = new Point(24, 391);
            btnNutritionAdd.Name = "btnNutritionAdd";
            btnNutritionAdd.Size = new Size(75, 59);
            btnNutritionAdd.TabIndex = 7;
            btnNutritionAdd.Text = "Add";
            btnNutritionAdd.UseVisualStyleBackColor = true;
            btnNutritionAdd.Click += btnNutritionAdd_Click;
            // 
            // cmbxNutrientCategory
            // 
            cmbxNutrientCategory.FormattingEnabled = true;
            cmbxNutrientCategory.Location = new Point(144, 303);
            cmbxNutrientCategory.Name = "cmbxNutrientCategory";
            cmbxNutrientCategory.Size = new Size(202, 23);
            cmbxNutrientCategory.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 306);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 5;
            label4.Text = "Category:";
            // 
            // txtNutrientCalorie
            // 
            txtNutrientCalorie.Location = new Point(146, 250);
            txtNutrientCalorie.Name = "txtNutrientCalorie";
            txtNutrientCalorie.Size = new Size(200, 23);
            txtNutrientCalorie.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 253);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Calorie:";
            // 
            // txtNutrientName
            // 
            txtNutrientName.Location = new Point(146, 197);
            txtNutrientName.Name = "txtNutrientName";
            txtNutrientName.Size = new Size(200, 23);
            txtNutrientName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 200);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Nutrition Name:";
            // 
            // pcrAddNutrition
            // 
            pcrAddNutrition.BackColor = Color.Black;
            pcrAddNutrition.Image = (Image)resources.GetObject("pcrAddNutrition.Image");
            pcrAddNutrition.Location = new Point(127, 34);
            pcrAddNutrition.Name = "pcrAddNutrition";
            pcrAddNutrition.Size = new Size(110, 97);
            pcrAddNutrition.SizeMode = PictureBoxSizeMode.StretchImage;
            pcrAddNutrition.TabIndex = 0;
            pcrAddNutrition.TabStop = false;
            // 
            // lvNutritionAdd
            // 
            lvNutritionAdd.BackColor = Color.White;
            lvNutritionAdd.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvNutritionAdd.ForeColor = Color.Black;
            lvNutritionAdd.FullRowSelect = true;
            lvNutritionAdd.Location = new Point(406, 83);
            lvNutritionAdd.Name = "lvNutritionAdd";
            lvNutritionAdd.Size = new Size(683, 522);
            lvNutritionAdd.TabIndex = 10;
            lvNutritionAdd.UseCompatibleStateImageBehavior = false;
            lvNutritionAdd.View = View.Details;
            lvNutritionAdd.SelectedIndexChanged += lvNutritionAdd_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nutrition ID";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nutrition Name";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nutrition Category";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Calorie";
            columnHeader4.Width = 120;
            // 
            // guna2CustomGradientPanel2
            // 
            guna2CustomGradientPanel2.Controls.Add(label5);
            guna2CustomGradientPanel2.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel2.FillColor = Color.Black;
            guna2CustomGradientPanel2.FillColor2 = Color.Black;
            guna2CustomGradientPanel2.FillColor3 = Color.Black;
            guna2CustomGradientPanel2.FillColor4 = Color.Maroon;
            guna2CustomGradientPanel2.Location = new Point(21, 12);
            guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel2.Size = new Size(239, 56);
            guna2CustomGradientPanel2.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(233, 37);
            label5.TabIndex = 17;
            label5.Text = "ADD NUTRIENTS";
            // 
            // FormAddNutrition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1101, 644);
            Controls.Add(guna2CustomGradientPanel2);
            Controls.Add(lvNutritionAdd);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddNutrition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            Load += FormAddNutrition_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcrAddNutrition).EndInit();
            guna2CustomGradientPanel2.ResumeLayout(false);
            guna2CustomGradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtNutrientName;
        private Label label1;
        private PictureBox pcrAddNutrition;
        private Button btnNutritionDelete;
        private Button btnNutritionUpdate;
        private Button btnNutritionAdd;
        private ComboBox cmbxNutrientCategory;
        private Label label4;
        private TextBox txtNutrientCalorie;
        private Label label2;
        private ListView lvNutritionAdd;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Label label5;
    }
}