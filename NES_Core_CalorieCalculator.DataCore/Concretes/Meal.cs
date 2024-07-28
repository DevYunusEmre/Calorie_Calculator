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
    public class Meal : Base, IBase
    {
        //Properties 
        public string Name { get; set; }

        //Navigation Properties 

        //MealNutritionDiary
        public virtual ICollection<MealNutritionDiary> MealNutritionDiaries { get; set; }
    }
}
