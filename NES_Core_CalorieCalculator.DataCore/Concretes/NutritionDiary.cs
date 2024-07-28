using NES_Core_CalorieCalculator.DataCore.Abstracts;
using NES_Core_CalorieCalculator.DataCore.Concretes.Composites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DataCore.Concretes
{
    /// <summary>
    /// Base: Birçok sınıfta bulunan ortak property'ler kalıtım alınmıştır.
    /// IBase: İşaretleme yapmak için bir Interface'den kalıtım alınmıştır.
    /// </summary>
    public class NutritionDiary : Base, IBase
    {
        //Properties 
        public DateTime Date { get; set; }
        public int MealId { get; set; }
        public int NutrientId { get; set; }
        public int UserInfoId { get; set; }
        public double Calorie { get; set; }
        public double Quantity { get; set; }
        //Navigation Properties
        [NotMapped]
        public UserInfo UserInfo { get; set; }
        [NotMapped]
        public Meal Meal { get; set; }
        [NotMapped]
        public Nutrient Nutrient { get; set; }

        //MealNutritionDiary
        public virtual ICollection<MealNutritionDiary> MealNutritionDiaries { get; set; }

        //NutrientNutritionDiary
        public virtual ICollection<NutrientNutritionDiary> NutrientNutritionDiaries { get; set; }

        //UserInfoNutrientDiary
        public virtual ICollection<UserInfoNutrientDiary> UserInfoNutrientDiaries { get; set; }
    }
}
