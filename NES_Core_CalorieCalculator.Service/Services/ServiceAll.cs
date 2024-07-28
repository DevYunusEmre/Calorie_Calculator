using NES_Core_CalorieCalculator.DAL.Concretes;
using NES_Core_CalorieCalculator.DAL.Context;
using NES_Core_CalorieCalculator.Service.Services.ServiceMeal;
using NES_Core_CalorieCalculator.Service.Services.ServiceNutrient;
using NES_Core_CalorieCalculator.Service.Services.ServiceNutrientCategory;
using NES_Core_CalorieCalculator.Service.Services.ServiceNutritionDiary;
using NES_Core_CalorieCalculator.Service.Services.ServiceUserInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Services
{
    public class ServiceAll
    {
        private readonly AppDbContext context;

        public RepoNutritionDiary repoNutritionDiary;
        public IServiceNutritionDiary serviceNutritionDiary;

        public RepoUserInfo repoUserInfo;
        public IServiceUserInfo serviceUserInfo;

        public RepoMeal repoMeal;
        public IServiceMeal serviceMeal;

        public RepoNutrient repoNutrient;
        public IServiceNutrient serviceNutrient;

        public RepoNutrientCategory repoNutrientCategory;
        public IServiceNutrientCategory serviceNutrientCategory;

        public ServiceAll(AppDbContext _context)
        {
            this.context = _context;

            repoMeal = new RepoMeal(context);
            repoUserInfo = new RepoUserInfo(context);
            repoNutrientCategory = new RepoNutrientCategory(context);
            repoNutrient = new RepoNutrient(context);
            repoNutritionDiary = new RepoNutritionDiary(context);


            serviceMeal = new ServiceMeal
                .ServiceMeal
                (
                context,
                repoUserInfo,
                repoNutritionDiary,
                repoMeal,
                repoNutrient,
                repoNutrientCategory
                );


            serviceUserInfo = new ServiceUserInfo
                .ServiceUserInfo
                (
                context,
                repoUserInfo,
                repoNutritionDiary,
                repoMeal,
                repoNutrient,
                repoNutrientCategory
                );

            serviceNutrientCategory = new ServiceNutrientCategory
                .ServiceNutrientCategory
                 (
                context,
                repoUserInfo,
                repoNutritionDiary,
                repoMeal,
                repoNutrient,
                repoNutrientCategory
                );

            serviceNutrient = new ServiceNutrient
                .ServiceNutrient
                (
                context,
                repoUserInfo,
                repoNutritionDiary,
                repoMeal,
                repoNutrient,
                repoNutrientCategory
                );

            serviceNutritionDiary = new ServiceNutritionDiary
                .ServiceNutritionDiary
                (
                context,
                repoUserInfo,
                repoNutritionDiary,
                repoMeal,
                repoNutrient,
                repoNutrientCategory
                );
        }
    }
}
