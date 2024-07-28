using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NES_Core_CalorieCalculator.DataCore.Concretes;
using NES_Core_CalorieCalculator.DataCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DAL.Configuration
{
    public class ConfigNutrientCategory : IEntityTypeConfiguration<NutrientCategory>
    {
        public void Configure(EntityTypeBuilder<NutrientCategory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(x => x.Status)
                .IsRequired(true)
                .HasColumnType("nvarchar(10)");

            builder.Property(x => x.CreateDate)
                .IsRequired(true)
                .HasColumnType("date");

            builder.Property(x => x.DropDate)
                .IsRequired(false)
                .HasColumnType("date");

            //DataSeed
            builder.HasData
                ( 
                 new NutrientCategory { Id = 1, Name = "Vegetable", Status = Status.Created},
                 new NutrientCategory { Id = 2, Name = "Fruit", Status = Status.Created },
                 new NutrientCategory { Id = 3, Name = "Soft Drink", Status = Status.Created },
                 new NutrientCategory { Id = 4, Name = "Alcohol", Status = Status.Created },
                 new NutrientCategory { Id = 5, Name = "Snack", Status = Status.Created },
                 new NutrientCategory { Id = 6, Name = "Dessert", Status = Status.Created },
                 new NutrientCategory { Id = 7, Name = "Salad", Status = Status.Created },
                 new NutrientCategory { Id = 8, Name = "Dairy", Status = Status.Created },
                 new NutrientCategory { Id = 9, Name = "Fish and Seafood", Status = Status.Created },
                 new NutrientCategory { Id = 10, Name = "Fast Food", Status = Status.Created },
                 new NutrientCategory { Id = 11, Name = "Meat or Poultry", Status = Status.Created },
                 new NutrientCategory { Id = 12, Name = "Grain, Bean and Nuts", Status = Status.Created },
                 new NutrientCategory { Id = 13, Name = "Others", Status = Status.Created }
                 );
        }
    }
}
