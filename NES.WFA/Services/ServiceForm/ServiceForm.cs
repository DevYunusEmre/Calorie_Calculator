using NES_Core_CalorieCalculator.DAL.Concretes;
using NES_Core_CalorieCalculator.DataCore.Abstracts;
using NES_Core_CalorieCalculator.DataCore.Concretes;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using NES_Core_CalorieCalculator.Service.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace NES_Core_CalorieCalculator.WFUI.Services.ServiceForm
{
    /*
     
     */
    public class ServiceForm : IServiceForm
    {
        #region kullanılmıyor


        public static void InitializeListView(ListView listview, IDTO dTO)
        {
            List<string> propertyNamesOfSelectedDTO = ServiceCustom.GetPropertyNamesByDTOClass(dTO);
            propertyNamesOfSelectedDTO.ForEach(propertyName => listview.Columns.Add(new ColumnHeader { Text = propertyName, Width = 80 }));
        }

        public static void ShowGetAllOnListview<T>(ListView listview, IList<T> DTOs)
        {
            listview.Items.Clear();
            foreach (T dto in DTOs)
            {
                ListViewItem item = new ListViewItem();
                int propertyCounter = 0;
                var s = typeof(T).GetProperties().ToList();
                foreach (var property in typeof(T).GetProperties().ToList())
                {
                    if (propertyCounter == 0)
                    {
                        if (property.GetValue(dto) is not null)
                            item.Text = property.GetValue(dto).ToString();
                        else
                            item.Text = "";
                        propertyCounter++;
                    }
                    else
                    {
                        if (property.GetValue(dto) is not null)
                        {
                            if (property.GetValue(dto) is DateTime)
                            {
                                DateTime dt = (DateTime)property.GetValue(dto);
                                item.SubItems.Add(dt.ToString("dd.MM.yyyy"));
                            }
                            else
                            {
                                item.SubItems.Add(property.GetValue(dto).ToString());
                            }
                        }
                        else
                            item.Text = "";
                    }
                }
                listview.Items.Add(item);
            }
        }




        #endregion

        /// <summary>
        /// nutrition search sayfasında bulunan nutrientlerin hepsini dizerken burayı kullanırız 
        /// </summary>
        /// <param name="listview"></param>
        /// <param name="dTONutrients"></param>
        public static void ShowNutrientsListview(ListView listview, IList<DTONutrient> dTONutrients)
        {
            int counter = 0;
            listview.Items.Clear();
            foreach (DTONutrient item in dTONutrients)
            {
                ListViewItem listViewItem = new ListViewItem();
                if (counter % 2 == 0)
                    listViewItem.BackColor = Color.White;
                else
                    listViewItem.BackColor = Color.Gainsboro;

                listViewItem.Text = item.Name;
                listViewItem.SubItems.Add(item.NutrientCategoryName);
                listViewItem.SubItems.Add($"{item.Calorie.ToString("0")} cal");

                listViewItem.Tag = item;
                listview.Items.Add(listViewItem);

                counter++;
            }
        }



        public static void ShowMeals_NutrientsListview(ListView listview, DTONutritionDiary dTONutritionDiary, ref int counter)
        {
            ListViewItem listViewItem = new ListViewItem();

            if (counter % 2 == 0)
                listViewItem.BackColor = Color.White;
            else
                listViewItem.BackColor = Color.Gainsboro;

            listViewItem.Text = dTONutritionDiary.NutrientName;
            listViewItem.SubItems.Add(dTONutritionDiary.NutrientCategoryName);
            listViewItem.SubItems.Add($"{dTONutritionDiary.Quantity.ToString("0")} gr");
            listViewItem.SubItems.Add($"{dTONutritionDiary.Calorie.ToString("0")} cal");

            listViewItem.Tag = dTONutritionDiary;
            listview.Items.Add(listViewItem);

        }

        /// <summary>
        /// todaysDTONutritionDiaries buraya ilgili güne göre nutritiondiary listesi ekle
        /// </summary>
        /// <param name="breaktfastListview"></param>
        /// <param name="lunchListview"></param>
        /// <param name="dinnerListview"></param>
        /// <param name="othersListview"></param>
        /// <param name="todaysDTONutritionDiaries"></param>
        public static void ShowNutrientsOnMealListview(ListView breaktfastListview, ListView lunchListview, ListView dinnerListview, ListView othersListview, IList<DTONutritionDiary> todaysDTONutritionDiaries)
        {
            breaktfastListview.Items.Clear();
            lunchListview.Items.Clear();
            dinnerListview.Items.Clear();
            othersListview.Items.Clear();

            int counterBreakfast = 0;
            int counterLunch = 0;
            int counterDinner = 0;
            int counterOther = 0;

            foreach (DTONutritionDiary item in todaysDTONutritionDiaries)
            {
                if (item.MealId == 1)
                {
                    ShowMeals_NutrientsListview(breaktfastListview, item, ref counterBreakfast);
                    counterBreakfast++;
                }
                else if (item.MealId == 2)
                {
                    ShowMeals_NutrientsListview(lunchListview, item, ref counterLunch);
                    counterLunch++;
                }
                else if (item.MealId == 3)
                {
                    ShowMeals_NutrientsListview(dinnerListview, item, ref counterDinner);
                    counterDinner++;
                }
                else if (item.MealId == 4)
                {
                    ShowMeals_NutrientsListview(othersListview, item, ref counterOther);
                    counterOther++;
                }
            }
        }

        public static void RefreshNutritionDiaryMealLists(ListView lvMorning, ListView lvNoon, ListView lvEvenin)
        {

        }

        public static void RefreshHistoryListview(ListView lvHistory, IList<DTONutritionDiaryHistory> dTONutritionDiaryHistories)
        {
            int counter = 0;
            lvHistory.Items.Clear();
            foreach (DTONutritionDiaryHistory item in dTONutritionDiaryHistories)
            {
                ListViewItem listViewItem = new ListViewItem();

                if (counter % 2 == 0)
                    listViewItem.BackColor = Color.White;
                else
                    listViewItem.BackColor = Color.Gainsboro;

                listViewItem.Text = item.Date.ToString("dd.MM.yyyy");
                listViewItem.SubItems.Add($"{item.TotalQuantity.ToString("0")} gr");
                listViewItem.SubItems.Add($"{item.TotalCalorie.ToString("0")} cal");

                listViewItem.Tag = item;
                lvHistory.Items.Add(listViewItem);

                counter++;
            }

        }


    }
}
