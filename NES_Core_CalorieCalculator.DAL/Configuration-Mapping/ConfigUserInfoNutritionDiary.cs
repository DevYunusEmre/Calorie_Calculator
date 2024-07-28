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
    public class ConfigUserInfoNutritionDiary : IEntityTypeConfiguration<UserInfoNutrientDiary>
    {
        public void Configure(EntityTypeBuilder<UserInfoNutrientDiary> builder)
        {
            builder
                .HasKey(uind => new { uind.UserInfoId, uind.NutrientDiaryId });

            builder.Property(x => x.CreateDate)
                .IsRequired(true)
                .HasColumnType("date");

            builder.Property(x => x.DropDate)
                .IsRequired(false)
                .HasColumnType("date");

            //Relational Properties:
            //UserInfo - UserInfoNutritionDiary
            builder
                .HasOne(uind => uind.UserInfo)
                .WithMany(ui => ui.UserInfoNutrientDiaries)
                .HasForeignKey(uind => uind.UserInfoId);

            //NutritionDiary - UserInfoNutritionDiary
            builder
                .HasOne(uind => uind.NutritionDiary)
                .WithMany(nd => nd.UserInfoNutrientDiaries)
                .HasForeignKey(uind => uind.NutrientDiaryId);


        }
    }
}
