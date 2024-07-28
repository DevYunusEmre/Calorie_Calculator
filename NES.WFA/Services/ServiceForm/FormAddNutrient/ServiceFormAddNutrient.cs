using NES.WFA.Services.ServiceForm.FormDiary;
using NES_Core_CalorieCalculator.DAL.Concretes;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using NES_Core_CalorieCalculator.Service.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES.WFA.Services.ServiceForm.FormAddNutrient
{
    public class ServiceFormAddNutrient
    {
        public static void ShowNutrientsListview(ref ListView listview, IList<DTONutrient> dTONutrients)
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

                listViewItem.Text = item.Id.ToString();
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.NutrientCategoryName);
                listViewItem.SubItems.Add(item.Calorie.ToString());

                listViewItem.Tag = item;
                listview.Items.Add(listViewItem);

                counter++;
            }
        }

        public static void GetSelectedNutrientInfoFromNutrientListview(ListView lvNutritionAdd, TextBox txtNutrientName, TextBox txtNutrientCalorie, ComboBox cmbxNutrientCategory, PictureBox pcrAddNutrition, ServiceAll serviceAll)
        {
            try
            {
                DTONutrient dTONutrient = lvNutritionAdd.SelectedItems[0].Tag as DTONutrient;
                txtNutrientName.Text = dTONutrient.Name;
                txtNutrientCalorie.Text = dTONutrient.Calorie.ToString();
                DTONutrientCategory dTONutrientCategory = serviceAll.serviceNutrientCategory.GetById(dTONutrient.NutrientCategoryId);
                cmbxNutrientCategory.SelectedIndex = dTONutrientCategory.Id - 1;
                ServiceFormDiary.GetSelectedNutrientImage(lvNutritionAdd, pcrAddNutrition);
            }
            catch { }
        }

        public static void NutrientUpdate(ServiceAll serviceAll, ListView lvNutritionAdd, TextBox txtNutrientName, ComboBox cmbxNutrientCategory)
        {
            try
            {
                DTONutrient dTONutrient = lvNutritionAdd.SelectedItems[0].Tag as DTONutrient;
                serviceAll.serviceNutrient.Update(new DTONutrient()
                {
                    Id = dTONutrient.Id,
                    Name = txtNutrientName.Text,
                    Calorie = dTONutrient.Calorie,
                    NutrientCategoryId = (int)cmbxNutrientCategory.SelectedValue
                });
            }
            catch { }
        }
        public static void NutrientDelete(ServiceAll serviceAll, ListView lvNutritionAdd)
        {
            try
            {
                DTONutrient deletedDTONutrient = lvNutritionAdd.SelectedItems[0].Tag as DTONutrient;
                serviceAll.serviceNutrient.Delete(deletedDTONutrient);
            }
            catch { }
        }

    }
}
