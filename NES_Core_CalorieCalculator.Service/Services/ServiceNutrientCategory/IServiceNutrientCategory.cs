using NES_Core_CalorieCalculator.DAL.Interfaces;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Services.ServiceNutrientCategory
{
    public interface IServiceNutrientCategory
    {
        int Create(DTONutrientCategory model);
        int Update(DTONutrientCategory model);
        int Delete(DTONutrientCategory model);
        DTONutrientCategory GetById(int id);
        IList<DTONutrientCategory> GetAll();
        IList<DTONutrientCategory> GetAllActive();
        IList<DTONutrientCategory> GetByName(string name);
          

    }
}
