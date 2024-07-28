using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES.WFA.Services.ServiceForm.FormAnalysis
{
    public class ServiceFormAnalysis
    {
        public static void RefreshNutrientConsumptionListview(ListView lvByMeal, IList<DTONutrientDiaryAnalysis> dTONutrientDiaryAnalyses)
        {
            int counter = 1;
            lvByMeal.Items.Clear();
            foreach (DTONutrientDiaryAnalysis item in dTONutrientDiaryAnalyses)
            {
                ListViewItem listViewItem = new ListViewItem();

                if (counter % 2 == 0)
                    listViewItem.BackColor = Color.White;
                else
                    listViewItem.BackColor = Color.Gainsboro;

                listViewItem.Text = counter.ToString();
                listViewItem.SubItems.Add(item.NutrientName);
                listViewItem.SubItems.Add($"{item.TotalConsumptionQuantity.ToString("0")} gr");
                listViewItem.SubItems.Add($"{item.TotalConsumptionCalorie.ToString("0")} cal");

                listViewItem.Tag = item;
                lvByMeal.Items.Add(listViewItem);
                counter++;
            }

        }

        public static void RefreshCompareListview(ListView lvCompare, IList<DTONutrientDiaryAnalysis> comparedDTONutrientDiaryAnalysis, IList<DTONutrientDiaryAnalysis> currentUserAnalyse)
        {
            int counter = 0;
            lvCompare.Items.Clear();
            foreach (DTONutrientDiaryAnalysis item in comparedDTONutrientDiaryAnalysis)
            {
                //If current user ate this nutrient then add listviewitem. cUA=currentUserAnalyse
                DTONutrientDiaryAnalysis cUA = currentUserAnalyse.FirstOrDefault(x => x.NutrientId == item.NutrientId);
                if (cUA != null)
                {
                    ListViewItem listViewItem = new ListViewItem();

                    if (counter % 2 == 0)
                        listViewItem.BackColor = Color.White;
                    else
                        listViewItem.BackColor = Color.Gainsboro;

                    listViewItem.Text = item.NutrientName;
                    listViewItem.SubItems.Add($"{cUA.TotalConsumptionCalorie.ToString("0")} cal");
                    listViewItem.SubItems.Add($"{item.AverageConsumptionCalorie.ToString("0")} cal");
                    listViewItem.SubItems.Add($"{cUA.TotalConsumptionQuantity.ToString("0")} gr");
                    listViewItem.SubItems.Add($"{item.AverageConsumptionQuantity.ToString("0")} gr");

                    listViewItem.Tag = item;
                    lvCompare.Items.Add(listViewItem);
                    counter++;
                }

            }
        }


    }
}
