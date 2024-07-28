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
    public class RepoNutrient : RepoBase<Nutrient>,IRepoNutrient
    {
        
        public RepoNutrient(AppDbContext _context) : base(_context)
        {
             
        }
         
    }
}
