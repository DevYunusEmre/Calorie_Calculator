using Microsoft.EntityFrameworkCore;
using NES_Core_CalorieCalculator.DAL.Context;
using NES_Core_CalorieCalculator.DAL.Interfaces;
using NES_Core_CalorieCalculator.DataCore.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace NES_Core_CalorieCalculator.DAL.Concretes
{
    public class RepoNutritionDiary : RepoBase<NutritionDiary>,IRepoNutritionDiary
    { 
        private readonly AppDbContext context;
        private readonly DbSet<NutritionDiary> table;
        public RepoNutritionDiary(AppDbContext _context) : base(_context)
        {
            this.context = _context;
            this.table = context.NutritionDiaries;
             
        }
         


    }
}
