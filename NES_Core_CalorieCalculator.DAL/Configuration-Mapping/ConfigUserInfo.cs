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
    public class ConfigUserInfo : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            builder.Property(x => x.Surname)
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            builder.Property(x => x.BirthDate)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(x => x.Gender)
                .IsRequired()
                .HasColumnType("nvarchar(10)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(x => x.Password)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(x => x.Height)
                .IsRequired(true)
                .HasColumnType("decimal(5,2)");

            builder.Property(x => x.Weight)
                .IsRequired(true)
                .HasColumnType("decimal(5,2)");

            builder.Property(x => x.Bmi)
                .IsRequired(false)
                .HasColumnType("decimal(5,2)");

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
                    new UserInfo { Id = 1, Name = "Yunus Emre", Surname = "Bulut", Gender = Gender.Male , BirthDate = Convert.ToDateTime("1996.04.11"), Email = "yunuzbaba@gmail.com", Password = "abc123", Height = 177, Weight = 90, Status = Status.Created },
                    new UserInfo { Id = 2, Name = "Semih", Surname = "Önol", Gender = Gender.Male , BirthDate = Convert.ToDateTime("1999.08.17"), Email = "kral@gmail.com", Password = "wxy123", Height = 175, Weight = 80, Status = Status.Created },
                    new UserInfo { Id = 3, Name = "Güneş", Surname = "Bahar", Gender = Gender.Female , BirthDate = Convert.ToDateTime("1997.02.24"), Email = "dataPatlatan@gmail.com", Password = "cokGizli123", Height = 170, Weight = 50, Status = Status.Created }
                );
        }
    }
}
