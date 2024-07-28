﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Concretes.DTOs
{
    public class DTONutrient : IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Calorie { get; set; }
        public int NutrientCategoryId { get; set; }
        public string NutrientCategoryName { get; set; }
    }
}