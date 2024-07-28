using NES_Core_CalorieCalculator.DAL.Context;
using NES_Core_CalorieCalculator.DAL.Interfaces;
using NES_Core_CalorieCalculator.DataCore.Concretes.Composites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DAL.Concretes
{
    public class RepoMealNutritionDiary : RepoBase<MealNutritionDiary>,IRepoMealNutritionDiary
    {
        public RepoMealNutritionDiary(AppDbContext _context) : base(_context)
        {
        }
    }
}
