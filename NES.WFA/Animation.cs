using NES_Core_CalorieCalculator.Service.Services;

namespace NES.WFA
{
    public partial class FormAnimation : Form
    {
        public ServiceAll serviceAll;
        public FormHome home;

        public FormAnimation(ServiceAll _serviceAll, FormHome home)
        {
            InitializeComponent();
            serviceAll = _serviceAll;
            this.home = home;
        }
        bool islem = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!islem)
            {
                this.Opacity += 0.004;
            }
            if (this.Opacity == 1.0)
            {
                islem = true;
            }
            if (islem)
            {
                this.Opacity -= 0.004;
                if (this.Opacity == 0.0)
                {
                    CloseThis();
                }
            }

        }

        public void CloseThis()
        {
            FormSignUp formSignUp = new FormSignUp(serviceAll, home);
            timer1.Enabled = false;
            this.Close();
            formSignUp.ShowDialog();
            
            
        }

    }
}
