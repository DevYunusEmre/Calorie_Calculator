namespace NES.WFA
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label3 = new Label();
            label2 = new Label();
            chckShow = new CheckBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lnkAccount = new LinkLabel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(513, 332);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 20;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(513, 226);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 19;
            label2.Text = "E-Mail";
            // 
            // chckShow
            // 
            chckShow.AutoSize = true;
            chckShow.BackColor = Color.Transparent;
            chckShow.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chckShow.ForeColor = Color.White;
            chckShow.Location = new Point(577, 435);
            chckShow.Name = "chckShow";
            chckShow.Size = new Size(161, 29);
            chckShow.TabIndex = 18;
            chckShow.Text = "Show Password";
            chckShow.UseVisualStyleBackColor = false;
            chckShow.CheckedChanged += chckShow_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Gainsboro;
            txtPassword.Location = new Point(513, 360);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Please type your password";
            txtPassword.Size = new Size(305, 37);
            txtPassword.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.Location = new Point(513, 254);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Please type your e-mail";
            txtEmail.Size = new Size(305, 37);
            txtEmail.TabIndex = 16;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gainsboro;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(513, 490);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(305, 42);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(513, 426);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(452, 360);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(452, 254);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(577, 133);
            label1.Name = "label1";
            label1.Size = new Size(135, 50);
            label1.TabIndex = 11;
            label1.Text = "LOGIN";
            // 
            // lnkAccount
            // 
            lnkAccount.AutoSize = true;
            lnkAccount.BackColor = Color.Transparent;
            lnkAccount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lnkAccount.LinkColor = Color.Red;
            lnkAccount.Location = new Point(634, 549);
            lnkAccount.Name = "lnkAccount";
            lnkAccount.Size = new Size(63, 20);
            lnkAccount.TabIndex = 56;
            lnkAccount.TabStop = true;
            lnkAccount.Text = "Sign Up";
            lnkAccount.LinkClicked += lnkAccount_LinkClicked;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1390, 12);
            button2.Name = "button2";
            button2.Size = new Size(33, 34);
            button2.TabIndex = 57;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1435, 898);
            Controls.Add(button2);
            Controls.Add(lnkAccount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(chckShow);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private CheckBox chckShow;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnLogin;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private LinkLabel lnkAccount;
        private Button button2;
    }
}