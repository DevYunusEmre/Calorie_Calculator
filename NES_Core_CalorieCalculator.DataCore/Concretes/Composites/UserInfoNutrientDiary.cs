using NES_Core_CalorieCalculator.DataCore.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DataCore.Concretes.Composites
{
    public class UserInfoNutrientDiary : Base, IBase
    {
        public int UserInfoId { get; set; }
        public int NutrientDiaryId { get; set; }
        public virtual UserInfo UserInfo { get; set; }
        public virtual NutritionDiary NutritionDiary { get; set; }

    }
}
