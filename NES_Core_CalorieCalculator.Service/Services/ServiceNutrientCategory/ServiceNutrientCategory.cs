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

namespace NES_Core_CalorieCalculator.Service.Services.ServiceNutrientCategory
{
    public class ServiceNutrientCategory : IServiceNutrientCategory
    {
        private readonly AppDbContext context;

        private readonly IRepoUserInfo repoUserInfo;
        private readonly IRepoNutritionDiary repoNutritionDiary;
        private readonly IRepoMeal repoMeal;
        private readonly IRepoNutrient repoNutrient;
        private readonly IRepoNutrientCategory repoNutrientCategory;

        public ServiceNutrientCategory
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

        public int Create(DTONutrientCategory model)
        {
            NutrientCategory createdNutrientCategory = new NutrientCategory() { Name = model.Name };
            return repoNutrientCategory.Create(createdNutrientCategory);
        }
        public int Update(DTONutrientCategory model)
        {
            NutrientCategory updatedNutrientCategory = repoNutrientCategory.GetById(model.Id);
            updatedNutrientCategory.Name = model.Name;
            return repoNutrientCategory.Update(updatedNutrientCategory);

        }

        public int Delete(DTONutrientCategory model)
        {
            NutrientCategory deletedNutrientCategory = repoNutrientCategory.GetById(model.Id);
            return repoNutrientCategory.Delete(deletedNutrientCategory);
        }

        public IList<DTONutrientCategory> GetAll()
        {
            return repoNutrientCategory
                .GetFilteredList
                (
                    select: x => new DTONutrientCategory { Id = x.Id, Name = x.Name }
                ).ToList();
        }

        public IList<DTONutrientCategory> GetAllActive()
        {
            return repoNutrientCategory
               .GetFilteredList
               (
                    select: x => new DTONutrientCategory { Id = x.Id, Name = x.Name },
                    where: x => x.Status != Status.Dropped
                ).ToList();
        }

        public DTONutrientCategory GetById(int id)
        {
            NutrientCategory nutrientCategory = repoNutrientCategory.GetById(id);
            return new DTONutrientCategory { Id = nutrientCategory.Id, Name = nutrientCategory.Name };
        }

        public IList<DTONutrientCategory> GetByName(string name)
        {
            return repoNutrientCategory
                .GetFilteredList
                (
                    select: x => new DTONutrientCategory { Id = x.Id, Name = x.Name },
                    //where: x => x.Status != Status.Dropped.ToString()
                    where: x => x.Status != Status.Dropped
                ).ToList();
        }


    }
}
