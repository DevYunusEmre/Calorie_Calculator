using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NES_Core_CalorieCalculator.DataCore.Concretes;
using NES_Core_CalorieCalculator.DataCore.Concretes.Composites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DAL.Configuration
{
    public class ConfigMealNutritionDiary : IEntityTypeConfiguration<MealNutritionDiary>
    {
        public void Configure(EntityTypeBuilder<MealNutritionDiary> builder)
        {
            builder
                .HasKey(mnd => new { mnd.MealId, mnd.NutritionDiaryId });

            builder.Property(x => x.CreateDate)
                .IsRequired(true)
                .HasColumnType("date");

            builder.Property(x => x.DropDate)
                .IsRequired(false)
                .HasColumnType("date");

            //Relational Properties:
            //meal - MealNutritionDiary
            builder
                .HasOne(mnd => mnd.Meal)
                .WithMany(m => m.MealNutritionDiaries)
                .HasForeignKey(mnd => mnd.MealId);

            //NutritionDiary - MealNutritionDiary 
            builder
                .HasOne(mnd => mnd.NutritionDiary)
                .WithMany(nd => nd.MealNutritionDiaries)
                .HasForeignKey(mnd => mnd.NutritionDiaryId);

        }
    }
}
