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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NES.WFA
{
    public partial class FormDiary : Form
    {
        public ServiceAll serviceAll;

        public FormDiary(ServiceAll _serviceAll)
        {
            InitializeComponent();
            serviceAll = _serviceAll;
        }

        private void FormDiary_Load(object sender, EventArgs e)
        {
            InitializeComboboxItems();

            LoadNutrientListview();
            //Show today's nutrients on Meals listviews
            RefreshMealsListviews();
        }

        private void txtDiarySearch_TextChanged(object sender, EventArgs e)
        {
            LoadNutrientListview();
        }

        private void btnDiaryAdd_Click(object sender, EventArgs e)
        {
            AddNutrientToMeals();
            RefreshMealsListviews();
        }

        private void btnDiaryDelete_Click(object sender, EventArgs e)
        {
            DeleteNutrientFromMeals();
        }
        private void lstvDiaryNutritions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceFormDiary.GetSelectedNutrientImage(lvDiaryNutritions, pcrNutrient);
        }

        #region Methods 

        public void RefreshMealsListviews()
        {
            DTOUserInfo currentUserInfo = (this.MdiParent as FormHome).currentUser;
            IList<DTONutritionDiary> todaysDTONutritionDiaries = serviceAll.serviceNutritionDiary.GetByDate(DateTime.Now, currentUserInfo);
            ServiceForm.ShowNutrientsOnMealListview(lstvDiaryBreakfast, lstvDiaryLunch, lstvDiaryDinner, lstvDiaryOther, todaysDTONutritionDiaries);

            lblDiaryTotalCalorie.Text = $"{serviceAll.serviceNutritionDiary.GetTotalCaloriesByDay(DateTime.Now, currentUserInfo).ToString("0")} cal";
        }
        public void LoadNutrientListview()
        {
            //load nutrient listview
            IList<DTONutrient> dTONutrients = serviceAll.serviceNutrient.GetByName(txtDiarySearch.Text);
            ServiceForm.ShowNutrientsListview(lvDiaryNutritions, dTONutrients);
        }
        public void InitializeComboboxItems()
        {
            //Initialize ComboboxItems (meals)
            IList<DTOMeal> dTOMeals = serviceAll.serviceMeal.GetAll();
            ServiceFormDiary.InitializeMealsComboboxItems(ref cmbMeal, dTOMeals);
        }
        public void AddNutrientToMeals()
        {
            //Current User Info
            DTOUserInfo currentUserInfo = (this.MdiParent as FormHome).currentUser;

            //Nutrient adding from todays meals
            DTONutritionDiary CreatingDTONutritionDiary = ServiceFormDiary.CreateNutritionDiary(currentUserInfo, lvDiaryNutritions, cmbMeal, txtQuantity.Text);

            if (serviceAll.serviceNutritionDiary.Create(CreatingDTONutritionDiary) == 0)
                MessageBox.Show("Your nutrient could not add on your today's nutrients");
        }
        public void DeleteNutrientFromMeals()
        {
            //Nutrient deleting from todays meals
            DTONutritionDiary deletedDTONutritionDiary = ServiceFormDiary.GetSelectedNutrientOnMealsListview(lstvDiaryBreakfast, lstvDiaryLunch, lstvDiaryDinner, lstvDiaryOther);

            if (serviceAll.serviceNutritionDiary.Delete(deletedDTONutritionDiary) > 0)
                MessageBox.Show("Your selected nutrient deleted successfully");
            else
                MessageBox.Show("Your selected nutrient could not delete.");

            RefreshMealsListviews();
        }
        public void GenerateRandomValues()
        {
            DTOUserInfo currentUserInfo = (this.MdiParent as FormHome).currentUser;
            DateTime dt = DateTime.Now;
            for (int i = 0; i < 30; i++)
            {

                //
                DTONutritionDiary CreatingDTONutritionDiary = ServiceFormDiary.CreateRandomNutritionDiary(currentUserInfo, lvDiaryNutritions, cmbMeal, txtQuantity.Text, dt, serviceAll, 1);

                if (serviceAll.serviceNutritionDiary.Create(CreatingDTONutritionDiary) == 0)
                    MessageBox.Show("Your nutrient could not add on your today's nutrients");

                //
                CreatingDTONutritionDiary = ServiceFormDiary.CreateRandomNutritionDiary(currentUserInfo, lvDiaryNutritions, cmbMeal, txtQuantity.Text, dt, serviceAll, 2);

                if (serviceAll.serviceNutritionDiary.Create(CreatingDTONutritionDiary) == 0)
                    MessageBox.Show("Your nutrient could not add on your today's nutrients");

                //
                CreatingDTONutritionDiary = ServiceFormDiary.CreateRandomNutritionDiary(currentUserInfo, lvDiaryNutritions, cmbMeal, txtQuantity.Text, dt, serviceAll, 3);

                if (serviceAll.serviceNutritionDiary.Create(CreatingDTONutritionDiary) == 0)
                    MessageBox.Show("Your nutrient could not add on your today's nutrients");

                //
                CreatingDTONutritionDiary = ServiceFormDiary.CreateRandomNutritionDiary(currentUserInfo, lvDiaryNutritions, cmbMeal, txtQuantity.Text, dt, serviceAll, 4);

                if (serviceAll.serviceNutritionDiary.Create(CreatingDTONutritionDiary) == 0)
                    MessageBox.Show("Your nutrient could not add on your today's nutrients");

                dt = dt.AddDays(-1);
            }
        }

        #endregion


        private void pcrNutrient_Click(object sender, EventArgs e)
        {

        }
    }
}
