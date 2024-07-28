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
    public class ConfigNutrientNutritionDiary : IEntityTypeConfiguration<NutrientNutritionDiary>
    {
        public void Configure(EntityTypeBuilder<NutrientNutritionDiary> builder)
        {
            builder
                .HasKey(nnd => new { nnd.NutrientId, nnd.NutritionDiaryId });

            builder.Property(x => x.CreateDate)
                .IsRequired(true)
                .HasColumnType("date");

            builder.Property(x => x.DropDate)
                .IsRequired(false)
                .HasColumnType("date");

            //Relational Properties:
            //Nutrient - NutrientNutritionDiary
            builder
                .HasOne(nnd => nnd.Nutrient)
                .WithMany(n => n.NutrientNutritionDiaries)
                .HasForeignKey(nnd => nnd.NutrientId);

            //NutritionDiary - NutrientNutritionDiary
            builder
                .HasOne(nnd => nnd.NutritionDiary)
                .WithMany(nd => nd.NutrientNutritionDiaries)
                .HasForeignKey(nnd => nnd.NutritionDiaryId);

        }
    }
}
