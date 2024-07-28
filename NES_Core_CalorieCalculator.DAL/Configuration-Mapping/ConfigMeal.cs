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
    public class ConfigMeal : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired(true)
                .HasColumnType("int");

            builder.Property(x => x.Name)
                .IsRequired(true)
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


            //datetime status vs eklenecek

            //DataSeed
            builder.HasData
                (
                    new Meal { Id = 1, Name = "Breakfast", Status = Status.Created },
                    new Meal { Id = 2, Name = "Lunch", Status = Status.Created },
                    new Meal { Id = 3, Name = "Dinner", Status = Status.Created },
                    new Meal { Id = 4, Name = "Other", Status = Status.Created }
                );


        }
    }
}
