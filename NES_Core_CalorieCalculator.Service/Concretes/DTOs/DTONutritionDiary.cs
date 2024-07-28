using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Concretes.DTOs
{
    public class DTONutritionDiary : IDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserInfoId { get; set; }
        public int MealId { get; set; }
        public int NutrientId { get; set; }
        public int NutrientCategoryId { get; set; }
        public double Calorie { get; set; }
        public double Quantity { get; set; }

        public string MealName { get; set; }
        public string UserName { get; set; }
        public string NutrientName { get; set; }
        public string NutrientCategoryName { get; set; }
    }
}
