namespace NES.WFA
{
    partial class FormHome
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblCurrentUser = new Label();
            btnAddNutrient = new Button();
            btnAnalysis = new Button();
            pictureBox1 = new PictureBox();
            btnHistory = new Button();
            btnDiary = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            label1 = new Label();
            button2 = new Button();
            lblTime = new Label();
            guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            lblTime2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2CustomGradientPanel1.SuspendLayout();
            guna2CustomGradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.BackColor = Color.Black;
            lblCurrentUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblCurrentUser.ForeColor = Color.White;
            lblCurrentUser.Location = new Point(30, 57);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(219, 49);
            lblCurrentUser.TabIndex = 1;
            lblCurrentUser.Text = "HOME";
            lblCurrentUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddNutrient
            // 
            btnAddNutrient.FlatStyle = FlatStyle.Flat;
            btnAddNutrient.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddNutrient.ForeColor = Color.White;
            btnAddNutrient.Location = new Point(60, 684);
            btnAddNutrient.Name = "btnAddNutrient";
            btnAddNutrient.Size = new Size(158, 67);
            btnAddNutrient.TabIndex = 6;
            btnAddNutrient.Text = "Add Nutrient";
            btnAddNutrient.UseVisualStyleBackColor = true;
            btnAddNutrient.Click += btnAddNutrion_Click;
            // 
            // btnAnalysis
            // 
            btnAnalysis.FlatStyle = FlatStyle.Flat;
            btnAnalysis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAnalysis.ForeColor = Color.White;
            btnAnalysis.Location = new Point(60, 571);
            btnAnalysis.Name = "btnAnalysis";
            btnAnalysis.Size = new Size(158, 67);
            btnAnalysis.TabIndex = 5;
            btnAnalysis.Text = "Analysis";
            btnAnalysis.UseVisualStyleBackColor = true;
            btnAnalysis.Click += btnAnalysis_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnHistory
            // 
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(60, 458);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(158, 67);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnDiary
            // 
            btnDiary.FlatStyle = FlatStyle.Flat;
            btnDiary.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDiary.ForeColor = Color.White;
            btnDiary.Location = new Point(60, 345);
            btnDiary.Name = "btnDiary";
            btnDiary.Size = new Size(158, 67);
            btnDiary.TabIndex = 0;
            btnDiary.Text = "Diary";
            btnDiary.UseVisualStyleBackColor = true;
            btnDiary.Click += btnDiary_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(label1);
            guna2CustomGradientPanel1.Controls.Add(button2);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.Dock = DockStyle.Top;
            guna2CustomGradientPanel1.FillColor = Color.Black;
            guna2CustomGradientPanel1.FillColor2 = Color.Black;
            guna2CustomGradientPanel1.FillColor3 = Color.Black;
            guna2CustomGradientPanel1.FillColor4 = Color.Maroon;
            guna2CustomGradientPanel1.Location = new Point(283, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(1152, 49);
            guna2CustomGradientPanel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(571, 30);
            label1.TabIndex = 11;
            label1.Text = "Calorie Calculator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1107, 10);
            button2.Name = "button2";
            button2.Size = new Size(33, 34);
            button2.TabIndex = 8;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblTime
            // 
            lblTime.AccessibleRole = AccessibleRole.None;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(21, 4);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(228, 30);
            lblTime.TabIndex = 9;
            lblTime.Text = "Time";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2CustomGradientPanel2
            // 
            guna2CustomGradientPanel2.Controls.Add(lblTime2);
            guna2CustomGradientPanel2.Controls.Add(lblTime);
            guna2CustomGradientPanel2.Controls.Add(button1);
            guna2CustomGradientPanel2.Controls.Add(lblCurrentUser);
            guna2CustomGradientPanel2.Controls.Add(btnAddNutrient);
            guna2CustomGradientPanel2.Controls.Add(pictureBox1);
            guna2CustomGradientPanel2.Controls.Add(btnAnalysis);
            guna2CustomGradientPanel2.Controls.Add(btnDiary);
            guna2CustomGradientPanel2.Controls.Add(btnHistory);
            guna2CustomGradientPanel2.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel2.Dock = DockStyle.Left;
            guna2CustomGradientPanel2.FillColor = Color.Black;
            guna2CustomGradientPanel2.FillColor2 = Color.Black;
            guna2CustomGradientPanel2.FillColor3 = Color.Maroon;
            guna2CustomGradientPanel2.FillColor4 = Color.Black;
            guna2CustomGradientPanel2.Location = new Point(0, 0);
            guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel2.Size = new Size(283, 898);
            guna2CustomGradientPanel2.TabIndex = 11;
            // 
            // lblTime2
            // 
            lblTime2.AccessibleRole = AccessibleRole.None;
            lblTime2.BackColor = Color.Transparent;
            lblTime2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTime2.ForeColor = Color.White;
            lblTime2.Location = new Point(21, 34);
            lblTime2.Name = "lblTime2";
            lblTime2.Size = new Size(228, 30);
            lblTime2.TabIndex = 10;
            lblTime2.Text = "Time";
            lblTime2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(60, 797);
            button1.Name = "button1";
            button1.Size = new Size(158, 67);
            button1.TabIndex = 7;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1435, 898);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(guna2CustomGradientPanel2);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnHistory;
        private Button btnDiary;
        private PictureBox pictureBox1;
        private Button btnAddNutrient;
        private Button btnAnalysis;
        public Label lblCurrentUser;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Button button1;
        private Button button2;
        private Label lblTime;
        private Label lblTime2;
        private Label label1;
    }
}