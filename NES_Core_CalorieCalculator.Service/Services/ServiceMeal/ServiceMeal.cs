using NES_Core_CalorieCalculator.DAL.Context;
using NES_Core_CalorieCalculator.DAL.Interfaces;
using NES_Core_CalorieCalculator.DataCore.Concretes;
using NES_Core_CalorieCalculator.DataCore.Enums;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Services.ServiceMeal
{
    public class ServiceMeal : IServiceMeal
    {
        private readonly AppDbContext context;

        private readonly IRepoUserInfo repoUserInfo;
        private readonly IRepoNutritionDiary repoNutritionDiary;
        private readonly IRepoMeal repoMeal;
        private readonly IRepoNutrient repoNutrient;
        private readonly IRepoNutrientCategory repoNutrientCategory;

        public ServiceMeal
            (
            AppDbContext _context,
                IRepoUserInfo _repoUserInfo,
               IRepoNutritionDiary _repoNutritionDiary,
               IRepoMeal _repoMeal,
               IRepoNutrient _repoNutrient,
               IRepoNutrientCategory _repoNutrientCategory
            )
        {
            this.context = _context;
            this.repoUserInfo = _repoUserInfo;
            this.repoNutritionDiary = _repoNutritionDiary;
            this.repoMeal = _repoMeal;
            this.repoNutrient = _repoNutrient;
            this.repoNutrientCategory = _repoNutrientCategory;
        }

        public int Create(DTOMeal model)
        {
            try
            {
                Meal meal = new Meal();
                meal.Id = model.Id;
                meal.Name = model.Name;
                return repoMeal.Create(meal);
            }
            catch (Exception ex)
            {
                throw new Exception($"Beklenmeyen bir hata oluştur. Hata: {ex.Message} ");
            }
        }
        public int Update(DTOMeal model)
        {
            Meal updatedMeal = repoMeal.GetById(model.Id);
            updatedMeal.Name = model.Name;
            return repoMeal.Update(updatedMeal);
        }

        public int Delete(DTOMeal model)
        {
            int id = model.Id;
            Meal deletedMeal = repoMeal.GetById(id);
            return repoMeal.Delete(deletedMeal);
        }

        public DTOMeal GetById(int id)
        {
            Meal meal = repoMeal.GetById(id);
            return new DTOMeal { Id = id, Name = meal.Name };
        }

        public IList<DTOMeal> GetAll()
        {
            return repoMeal
                .GetFilteredList
                (
                select: x => new DTOMeal { Id = x.Id, Name = x.Name }
                ).ToList();
        }

        public IList<DTOMeal> GetAllActive()
        {
            return repoMeal
                .GetFilteredList
                (
                    select: x => new DTOMeal { Id = x.Id, Name = x.Name },
                    //where: x => x.Status != Status.Dropped.ToString()
                    where: x => x.Status != Status.Dropped
                ).ToList();
        }


        public IList<DTOMeal> GetByName(string name)
        {
            return repoMeal
                .GetFilteredList
                (
                    select: x => new DTOMeal { Id = x.Id, Name = x.Name },
                    where: x => x.Name.Contains(name)
                ).ToList();
        }

    }
}
