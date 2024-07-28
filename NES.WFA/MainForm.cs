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
    public partial class FormMainForm : Form
    {
        public ServiceAll serviceAll;
        public FormMainForm()
        {
            
        }
        public FormMainForm(ServiceAll _serviceAll)
        {
            InitializeComponent();
            serviceAll = _serviceAll;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
