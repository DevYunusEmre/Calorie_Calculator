using NES.WFA.Services.ServiceForm.FormAddNutrient;
using NES.WFA.Services.ServiceForm.FormDiary;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using NES_Core_CalorieCalculator.Service.Services;
using NES_Core_CalorieCalculator.WFUI.Services.ServiceForm;
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
    public partial class FormAddNutrition : Form
    {
        public ServiceAll serviceAll;

        public FormAddNutrition(ServiceAll _serviceAll)
        {
            InitializeComponent();
            serviceAll = _serviceAll;
        }
        private void FormAddNutrition_Load(object sender, EventArgs e)
        {
            LoadNutrientCategoryCombobox();
            RefreshNutrientListview();
        }

        private void btnNutritionAdd_Click(object sender, EventArgs e)
        {
            int nutrientCategoryId = (int)cmbxNutrientCategory.SelectedValue;

            if (ServiceFormDiary.CreateNutrient(txtNutrientName.Text, cmbxNutrientCategory, txtNutrientCalorie.Text, out DTONutrient createdDTONutrient))
            {
                if (serviceAll.serviceNutrient.Create(createdDTONutrient) == 0)
                    MessageBox.Show("Your nutrient could not be add");
            }

            //Load nutrientListview
            IList<DTONutrient> dTONutrients = serviceAll.serviceNutrient.GetAllActive();
            ServiceForm.ShowNutrientsListview(lvNutritionAdd, dTONutrients);
        }

        private void lvNutritionAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceFormAddNutrient.GetSelectedNutrientInfoFromNutrientListview(lvNutritionAdd, txtNutrientName, txtNutrientCalorie, cmbxNutrientCategory, pcrAddNutrition, serviceAll);

        }

        private void btnNutritionUpdate_Click(object sender, EventArgs e)
        {
            ServiceFormAddNutrient.NutrientUpdate(serviceAll, lvNutritionAdd, txtNutrientName, cmbxNutrientCategory);
            RefreshNutrientListview();
        }

        public void LoadNutrientCategoryCombobox()
        {
            IList<DTONutrientCategory> dTONutrientCategories = serviceAll.serviceNutrientCategory.GetAll();
            ServiceFormDiary.InitializeNutrientCategoryComboboxItems(ref cmbxNutrientCategory, dTONutrientCategories);
        }

        public void RefreshNutrientListview()
        {
            //Load nutrientListview
            IList<DTONutrient> dTONutrients = serviceAll.serviceNutrient.GetAllActive();
            ServiceFormAddNutrient.ShowNutrientsListview(ref lvNutritionAdd, dTONutrients);
        }

        private void btnNutritionDelete_Click(object sender, EventArgs e)
        {
            ServiceFormAddNutrient.NutrientDelete(serviceAll, lvNutritionAdd);
            RefreshNutrientListview();
        }
    }
}
