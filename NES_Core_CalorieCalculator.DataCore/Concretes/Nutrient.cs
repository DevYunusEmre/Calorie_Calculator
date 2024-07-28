using NES_Core_CalorieCalculator.DataCore.Abstracts;
using NES_Core_CalorieCalculator.DataCore.Concretes.Composites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DataCore.Concretes
{
    /// <summary>
    /// Base: Birçok sınıfta bulunan ortak property'ler kalıtım alınmıştır.
    /// IBase: İşaretleme yapmak için bir Interface'den kalıtım alınmıştır.
    /// </summary>
    public class Nutrient : Base, IBase
    {
        //Properties  
        public string Name { get; set; }
        public double Calorie { get; set; }//Per portion
        public string? Picture { get; set; }

        //Navigation Properties

        //NutrientCategory
        public int NutrientCategoryId { get; set; }
        public virtual NutrientCategory NutrientCategory { get; set; }

        //NutrientNutritionDiary
        public virtual ICollection<NutrientNutritionDiary> NutrientNutritionDiaries { get; set; }
         
    }
}
