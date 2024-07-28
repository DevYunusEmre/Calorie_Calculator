using NES_Core_CalorieCalculator.DataCore.Abstracts;
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
    public class NutrientCategory : Base, IBase
    {
        //Properties 
        public string Name { get; set; }

        //Navigation Property

        //Nutrient
        public int NutrientId { get; set; }
        public virtual ICollection<Nutrient> Nutrients { get; set; }

    }
}
