using Microsoft.EntityFrameworkCore;
using NES_Core_CalorieCalculator.DataCore.Concretes;
using NES_Core_CalorieCalculator.DataCore.Concretes.Composites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<NutrientCategory> NutrientCategories { get; set; }
        public DbSet<NutritionDiary> NutritionDiaries { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<MealNutritionDiary> MealNutritionDiaries { get; set; }
        public DbSet<NutrientNutritionDiary> NutrientNutritionDiaries { get; set; }
        public DbSet<UserInfoNutrientDiary> UserInfoNutrientDiaries { get; set; }
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //lazyLoad eklenebilir...            
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4810D6L\\SQLEXPRESS;Initial Catalog=NES_Core_CalorieCalculator;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
             
            base.OnModelCreating(modelBuilder);
        }

    }
}
