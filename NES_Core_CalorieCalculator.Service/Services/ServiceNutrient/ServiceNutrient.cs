using NES_Core_CalorieCalculator.DAL.Context;
using NES_Core_CalorieCalculator.DAL.Interfaces;
using NES_Core_CalorieCalculator.DataCore.Concretes;
using NES_Core_CalorieCalculator.DataCore.Enums;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Services.ServiceNutrient
{
    public class ServiceNutrient : IServiceNutrient
    {
        private readonly AppDbContext context;

        private readonly IRepoNutritionDiary repoNutritionDiary;
        private readonly IRepoMeal repoMeal;
        private readonly IRepoNutrient repoNutrient;
        private readonly IRepoUserInfo repoUserInfo;
        private readonly IRepoNutrientCategory repoNutrientCategory;
        public ServiceNutrient
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
            this.repoNutritionDiary = _repoNutritionDiary;
            this.repoMeal = _repoMeal;
            this.repoNutrient = _repoNutrient;
            this.repoUserInfo = _repoUserInfo;
            this.repoNutrientCategory = _repoNutrientCategory;
        }
        public int Create(DTONutrient model)
        {
            Nutrient createdNutrient = new Nutrient { Name = model.Name, Calorie = model.Calorie, NutrientCategoryId = model.NutrientCategoryId };

            return repoNutrient.Create(createdNutrient);
        }
        public int Update(DTONutrient model)
        {
            Nutrient updatedNutrient = repoNutrient.GetById(model.Id);
            updatedNutrient.Name = model.Name;
            updatedNutrient.Calorie = model.Calorie;
            updatedNutrient.NutrientCategoryId = model.NutrientCategoryId;
            return repoNutrient.Update(updatedNutrient);
        }
        public int Delete(DTONutrient model)
        {
            int id = model.Id;
            Nutrient deletedNutrient = repoNutrient.GetById(id);
            return repoNutrient.Delete(deletedNutrient);
        }
        public DTONutrient GetById(int id)
        {
            Nutrient nutrient = repoNutrient.GetById(id);
            return new DTONutrient { Id = id, Name = nutrient.Name, Calorie = nutrient.Calorie, NutrientCategoryId = nutrient.NutrientCategoryId };
        }
        public IList<DTONutrient> GetAll()
        {
            return repoNutrient
                .GetFilteredList
                (
                select: x => new DTONutrient { Id = x.Id, Name = x.Name, Calorie = x.Calorie, NutrientCategoryId = x.NutrientCategoryId }
                ).ToList();
        }
        public IList<DTONutrient> GetAllActive()
        {
            return repoNutrient
                .GetFilteredList
                (
                    select: x => new DTONutrient
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Calorie = x.Calorie,
                        NutrientCategoryId = x.NutrientCategoryId,
                        NutrientCategoryName = x.NutrientCategory.Name
                    },
                    where: x => x.Status != Status.Dropped
                ).ToList();
        }
        public IList<DTONutrient> GetByName(string name)
        {
            IList<DTONutrient> dTONutrients = repoNutrient
                .GetFilteredList
                (
                    select: x => new DTONutrient { Id = x.Id, Name = x.Name, Calorie = x.Calorie, NutrientCategoryId = x.NutrientCategoryId },
                    where: x => x.Name.Contains(name)
                ).ToList();


            foreach (DTONutrient dTONutrient in dTONutrients)
            {
                dTONutrient.NutrientCategoryName = repoNutrientCategory.GetById(dTONutrient.NutrientCategoryId).Name;
            }
            return dTONutrients;

        }
    }
}
