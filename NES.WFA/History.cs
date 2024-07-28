using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using NES_Core_CalorieCalculator.Service.Services;
using NES_Core_CalorieCalculator.Service.Services.ServiceNutritionDiary;
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
    public partial class FormHistory : Form
    {
        public ServiceAll serviceAll;

        public FormHistory(ServiceAll _serviceAll)
        {
            InitializeComponent();
            serviceAll = _serviceAll;
        }
        private void FormHistory_Load(object sender, EventArgs e)
        {

        }

        private void lvHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMealsListview();
        }
         

        #region Methods

        public void RefreshMealsListview()
        {
            DTOUserInfo currentUserInfo = (this.MdiParent as FormHome).currentUser;

            //Refresh MealsListview
            if (lvHistory.SelectedItems.Count > 0)
            {
                DTONutritionDiaryHistory selectedDTONutritionDiaryHistory = lvHistory.SelectedItems[0].Tag as DTONutritionDiaryHistory;
                DateTime selectedDateOnListviewHistory = selectedDTONutritionDiaryHistory.Date;

                IList<DTONutritionDiary> todaysDTONutritionDiaries = serviceAll.serviceNutritionDiary.GetByDate(selectedDateOnListviewHistory, currentUserInfo);

                ServiceForm.ShowNutrientsOnMealListview(lvHistoryBreakfast, lvHistoryLunch, lvHistoryDinner, lvHistoryOther, todaysDTONutritionDiaries);

                lblHistoryTotalCalorie.Text = serviceAll.serviceNutritionDiary.GetTotalCaloriesByDay(selectedDateOnListviewHistory, currentUserInfo).ToString("0");

            }
        }

        public void RefreshAllListviews()
        {
            DTOUserInfo currentUserInfo = (this.MdiParent as FormHome).currentUser;

            //Refresh HistoryListview
            IList<DTONutritionDiaryHistory> history = serviceAll.serviceNutritionDiary.GetCurrentUserHistory(currentUserInfo);

            ServiceForm.RefreshHistoryListview(lvHistory, history);

            RefreshMealsListview();
        }
        #endregion

    }
}
