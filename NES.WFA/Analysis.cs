using NES.WFA.Services.ServiceForm.FormAnalysis;
using NES.WFA.Services.ServiceForm.FormDiary;
using NES_Core_CalorieCalculator.DataCore.Concretes;
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
    public partial class FormAnalysis : Form
    {
        public ServiceAll serviceAll;

        public FormAnalysis(ServiceAll _serviceAll)
        {
            InitializeComponent();
            this.serviceAll = _serviceAll;
        }

        private void FormAnalysis_Load(object sender, EventArgs e)
        {
            InitializeComboboxItemsMeals();
            InitializeComboboxItemsNutrientCategory();
        }

        private void cmbxMeals_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowListviewByMeal();
        }

        private void cmbxNutrientCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowListviewByCategory();
        }

        public void InitializeComboboxItemsMeals()
        {
            //Initialize ComboboxItems (meals)
            IList<DTOMeal> dTOMeals = serviceAll.serviceMeal.GetAll();
            ServiceFormDiary.InitializeMealsComboboxItems(ref cmbxMeals, dTOMeals);

            IList<DTOMeal> dTOMeals2 = serviceAll.serviceMeal.GetAll();
            ServiceFormDiary.InitializeMealsComboboxItems(ref cmbxCompareMeals, dTOMeals2);
        }

        public void InitializeComboboxItemsNutrientCategory()
        {
            IList<DTONutrientCategory> dTONutrientCategories = serviceAll.serviceNutrientCategory.GetAll();
            ServiceFormDiary.InitializeNutrientCategoryComboboxItems(ref cmbxNutrientCategory, dTONutrientCategories);

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            ShowCompareListview();
        }
        private void rdbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            ShowListviewByMeal();
        }
        #region Methods

        public void ShowListviewByMeal()
        {
            int mealId = (int)cmbxMeals.SelectedValue;
            IList<DTONutrientDiaryAnalysis> dTONutrientDiaryAnalysis;

            if (rdbWeekly.Checked)
                dTONutrientDiaryAnalysis = serviceAll.serviceNutritionDiary.GetWeeklyAnalysisByMeal(mealId);
            else
                dTONutrientDiaryAnalysis = serviceAll.serviceNutritionDiary.GetMonthlyAnalysisByMeal(mealId);

            ServiceFormAnalysis.RefreshNutrientConsumptionListview(lvByMeal, dTONutrientDiaryAnalysis);
        }
        public void ShowListviewByCategory()
        {
            int nutrientCategoryId = (int)cmbxNutrientCategory.SelectedValue;
            IList<DTONutrientDiaryAnalysis> dTONutrientDiaryAnalysis;

            if (rdbWeekly.Checked)
                dTONutrientDiaryAnalysis = serviceAll.serviceNutritionDiary.GetWeeklyAnalysisByNutrientCategory(nutrientCategoryId);
            else
                dTONutrientDiaryAnalysis = serviceAll.serviceNutritionDiary.GetMonthlyAnalysisByNutrientCategory(nutrientCategoryId);

            ServiceFormAnalysis.RefreshNutrientConsumptionListview(lvByCategory, dTONutrientDiaryAnalysis);

        }
        public void ShowCompareListview()
        {
            DTOUserInfo currentDTOUserInfo = (this.MdiParent as FormHome).currentUser;

            int selectedMealId;
            if (chckbxAllMeals.Checked)
                selectedMealId = 5;//That means all meals...
            else
                selectedMealId = (int)cmbxCompareMeals.SelectedValue;

            IList<DTONutrientDiaryAnalysis> dTONutrientDiaryAnalyses = serviceAll.serviceNutritionDiary.GetWeeklyAnalysisAverageByMeal(selectedMealId);

            IList<DTONutrientDiaryAnalysis> currentUserAnalyze = serviceAll.serviceNutritionDiary.GetWeeklyAnalysisCurrentUserByMeal(selectedMealId, currentDTOUserInfo);

            ServiceFormAnalysis.RefreshCompareListview(lvCompare, dTONutrientDiaryAnalyses, currentUserAnalyze);

        }
        #endregion

 
    }
}
