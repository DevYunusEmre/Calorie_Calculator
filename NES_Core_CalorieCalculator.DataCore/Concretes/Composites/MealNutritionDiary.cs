using NES_Core_CalorieCalculator.DataCore.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DataCore.Concretes.Composites
{
    public class MealNutritionDiary : Base, IBase
    {
        public int MealId { get; set; }
        public int NutritionDiaryId { get; set; }
        public virtual Meal Meal { get; set; }
        public virtual NutritionDiary NutritionDiary { get; set; }

    }
}
