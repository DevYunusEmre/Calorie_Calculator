using NES_Core_CalorieCalculator.DataCore.Concretes;
using NES_Core_CalorieCalculator.DataCore.Enums;
using NES_Core_CalorieCalculator.DataCore.Services;
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
    public partial class FormSignUp : Form
    {
        public ServiceAll serviceAll;
        public FormHome home;

        public FormSignUp(ServiceAll _serviceAll, FormHome home)
        {
            InitializeComponent();
            serviceAll = _serviceAll;
            this.home = home;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            DTOCreateUserInfo dTOCreateUserInfo = new DTOCreateUserInfo()
            {
                Name = txtFirstName.Text,
                Surname = txtLastName.Text,
                BirthDate = dtBirthdate.Value,
                Gender = rdbMale.Checked ? Gender.Male : Gender.Female,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Height = txtHeight.Text,
                Weight = txtWeight.Text
            };
            try
            {
                serviceAll.serviceUserInfo.CheckSignupInformation(dTOCreateUserInfo, rdbMale.Checked, rdbFemale.Checked);

                if (serviceAll.serviceUserInfo.Create(dTOCreateUserInfo) > 0)
                {
                    home.currentUser = serviceAll.serviceUserInfo.GetByEmailAndPass(dTOCreateUserInfo.Email, dTOCreateUserInfo.Password);
                    home.lblCurrentUser.Text = $"{home.currentUser.Name} {home.currentUser.Surname}";
                    home.lblCurrentUser.Tag = home.currentUser;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unexpected error.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnkAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin formLogin = new FormLogin(serviceAll, home);
            formLogin.ShowDialog();
            this.Close();

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

            if (Encapsulation.NameControl(txtFirstName.Text))
                txtFirstName.ForeColor = Color.Green;
            else txtFirstName.ForeColor = Color.Red;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (Encapsulation.PassControl(txtPassword.Text))
                txtPassword.ForeColor = Color.Green;
            else txtPassword.ForeColor = Color.Red;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (Encapsulation.NameControl(txtLastName.Text))
                txtLastName.ForeColor = Color.Green;
            else txtLastName.ForeColor = Color.Red;
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (Encapsulation.NumberControl(txtHeight.Text, 300))
                txtHeight.ForeColor = Color.Green;
            else txtHeight.ForeColor = Color.Red;
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if (Encapsulation.NumberControl(txtWeight.Text, 300))
                txtWeight.ForeColor = Color.Green;
            else txtWeight.ForeColor = Color.Red;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (Encapsulation.EmailControl(txtEmail.Text))
                txtEmail.ForeColor = Color.Green;
            else txtEmail.ForeColor = Color.Red;
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
