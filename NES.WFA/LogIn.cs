using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using NES_Core_CalorieCalculator.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NES.WFA
{
    public partial class FormLogin : Form
    {
        public ServiceAll serviceAll;
        public FormHome home;
        public FormLogin(ServiceAll _serviceAll, FormHome home)
        {
            InitializeComponent();
            serviceAll = _serviceAll;
            this.home = home;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (serviceAll.serviceUserInfo.Login(txtEmail.Text, txtPassword.Text, ref home.currentUser))
            {
                DTOUserInfo userInfo = home.currentUser;
                home.lblCurrentUser.Text = $"{userInfo.Name} {userInfo.Surname}";
                home.lblCurrentUser.Tag = userInfo;
                this.Close();
            }
            else
                MessageBox.Show("Email or Password is wrong!.");

        }

        private void chckShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chckShow.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';


        }

        private void lnkAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp(serviceAll, home);
            formSignUp.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
