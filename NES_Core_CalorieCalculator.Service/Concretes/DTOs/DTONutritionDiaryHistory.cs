using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Concretes.DTOs
{
    public class DTONutritionDiaryHistory : IDTO
    { 
        public DateTime Date { get; set; }
        public int UserInfoId { get; set; }  
        public double TotalCalorie { get; set; }
        public double TotalQuantity { get; set; }
    }
}
