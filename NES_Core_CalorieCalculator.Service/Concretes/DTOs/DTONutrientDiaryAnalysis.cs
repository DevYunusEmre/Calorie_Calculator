using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Concretes.DTOs
{
    public class DTONutrientDiaryAnalysis : IDTO
    {
        public DateTime Date { get; set; }
        public int NutrientId { get; set; }
        public string NutrientName { get; set; }
        public int NutrientCategoryId { get; set; }
        public string NutrientCategoryName { get; set; } 
        public double TotalConsumptionCalorie { get; set; }
        public double AverageConsumptionCalorie { get; set; }
        public double TotalConsumptionQuantity { get; set; }
        public double AverageConsumptionQuantity { get; set; }
    }
}
