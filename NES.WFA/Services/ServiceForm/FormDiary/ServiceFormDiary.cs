using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using NES_Core_CalorieCalculator.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES.WFA.Services.ServiceForm.FormDiary
{
    public class ServiceFormDiary
    {
        private static double portionQuantity = 100;//100 gr
        public static void InitializeMealsComboboxItems(ref ComboBox comboBox, IList<DTOMeal> dTOMeals)
        {
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            comboBox.DataSource = dTOMeals;
        }
        public static void InitializeNutrientCategoryComboboxItems(ref ComboBox comboBox, IList<DTONutrientCategory> dTONutrientCategories)
        {
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            comboBox.DataSource = dTONutrientCategories;
        }

        public static DTONutritionDiary CreateNutritionDiary(DTOUserInfo currentUserInfo, ListView lstvDiaryNutritions, ComboBox cmbMeal, string quantityString)
        {
            ListViewItem listViewItem = lstvDiaryNutritions.SelectedItems[0];
            DTONutrient selectedDTONutrient = listViewItem.Tag as DTONutrient;

            int userInfoId = currentUserInfo.Id;
            int nutrientId = selectedDTONutrient.Id;
            int mealId = (int)cmbMeal.SelectedValue;
            double quantity = 0;

            try
            {
                quantity = double.Parse(quantityString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error. Error: {ex.Message}");
                return null;
            }
            return new DTONutritionDiary()
            {
                Date = DateTime.Now,
                MealId = mealId,
                UserInfoId = userInfoId,
                NutrientId = nutrientId,
                Quantity = quantity,
                Calorie = selectedDTONutrient.Calorie * quantity / portionQuantity
            };
        }

        public static DTONutritionDiary CreateRandomNutritionDiary(DTOUserInfo currentUserInfo, ListView lstvDiaryNutritions, ComboBox cmbMeal, string quantityString,DateTime rndDateTime,ServiceAll serviceAll,int mealId)
        {
            Random rnd = new Random();

             int nutrientId = rnd.Next(1, 254);
            DTONutrient selectedDTONutrient = serviceAll.serviceNutrient.GetById(nutrientId);



            int userInfoId = currentUserInfo.Id; 
            double quantity = 0;

            try
            {
                quantity = rnd.Next(25,120);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error. Error: {ex.Message}");
                return null;
            }
            return new DTONutritionDiary()
            {
                Date = rndDateTime,
                MealId = mealId,
                UserInfoId = userInfoId,
                NutrientId = nutrientId,
                Quantity = quantity,
                Calorie = selectedDTONutrient.Calorie * quantity / portionQuantity
            };
        }

        public static bool CreateNutrient(string txtNutrientName, ComboBox cmbxNutrientCategory, string calorieString, out DTONutrient createdDTONutrient)
        {
            createdDTONutrient = new DTONutrient();
            double calorie = 0;
            try
            {
                calorie = double.Parse(calorieString);
            }
            catch
            {
                MessageBox.Show("Calorie must be number.");
                return false;
            }

            createdDTONutrient = new DTONutrient()
            {
                Name = txtNutrientName,
                NutrientCategoryId = (int)cmbxNutrientCategory.SelectedValue,
                Calorie = calorie
            };
            return true;
        }

        public static DTONutritionDiary GetSelectedNutrientOnMealsListview(ListView lstvDiaryBreakfast, ListView lstvDiaryLunch, ListView lstvDiaryDinner, ListView lstvDiaryOther)
        {
            if (lstvDiaryBreakfast.SelectedItems.Count > 0)
            {
                DTONutritionDiary deletedDTONutritionDiary = lstvDiaryBreakfast.SelectedItems[0].Tag as DTONutritionDiary;
                return deletedDTONutritionDiary;
            }
            else if (lstvDiaryLunch.SelectedItems.Count > 0)
            {
                DTONutritionDiary deletedDTONutritionDiary = lstvDiaryLunch.SelectedItems[0].Tag as DTONutritionDiary;
                return deletedDTONutritionDiary;

            }
            else if (lstvDiaryDinner.SelectedItems.Count > 0)
            {
                DTONutritionDiary deletedDTONutritionDiary = lstvDiaryDinner.SelectedItems[0].Tag as DTONutritionDiary;
                return deletedDTONutritionDiary;

            }
            else if (lstvDiaryOther.SelectedItems.Count > 0)
            {
                DTONutritionDiary deletedDTONutritionDiary = lstvDiaryOther.SelectedItems[0].Tag as DTONutritionDiary;
                return deletedDTONutritionDiary;
            }
            else
                return null;
        }

        public static void GetSelectedNutrientImage(ListView lvDiaryNutritions, PictureBox pcrNutrient)
        {
            try
            {
                DTONutrient selectedDTONutrient = lvDiaryNutritions.SelectedItems[0].Tag as DTONutrient;
                int nutrientId = selectedDTONutrient.Id;
                pcrNutrient.ImageLocation = Application.StartupPath + $"\\ImagesNutrient\\{nutrientId}.jpg";
            }
            catch { }

        }


    }
}
