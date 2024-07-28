using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NES_Core_CalorieCalculator.DataCore.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DAL.Configuration
{
    public class ConfigNutritionDiary : IEntityTypeConfiguration<NutritionDiary>
    {
        public void Configure(EntityTypeBuilder<NutritionDiary> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(x => x.Date)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(x => x.MealId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(x => x.NutrientId)
                .IsRequired()
                .HasColumnType("int");
            builder.Property(x => x.UserInfoId)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(x => x.Status)
                .IsRequired(true)
                .HasColumnType("nvarchar(10)");

            builder.Property(x => x.Calorie)
                .IsRequired(true)
                .HasColumnType("decimal(8,2)");

            builder.Property(x => x.Quantity)
                .IsRequired(true)
                .HasColumnType("decimal(8,2)");

            builder.Property(x => x.CreateDate)
                .IsRequired(true)
                .HasColumnType("date");

            builder.Property(x => x.DropDate)
                .IsRequired(false)
                .HasColumnType("date");
        }
    }
}
