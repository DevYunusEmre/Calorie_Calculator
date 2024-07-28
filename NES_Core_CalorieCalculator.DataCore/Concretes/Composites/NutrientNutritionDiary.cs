using NES_Core_CalorieCalculator.DataCore.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DataCore.Concretes.Composites
{
    public class NutrientNutritionDiary : Base, IBase
    {
        public int NutrientId { get; set; }
        public int NutritionDiaryId { get; set; }
        public virtual Nutrient Nutrient { get; set; }
        public virtual NutritionDiary NutritionDiary { get; set; }
    }
}
