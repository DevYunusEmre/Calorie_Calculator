using NES_Core_CalorieCalculator.DAL.Context;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Services.ServiceNutrient
{
    public interface IServiceNutrient
    {
        int Create(DTONutrient model);
        int Update(DTONutrient model);
        int Delete(DTONutrient model);
        DTONutrient GetById(int id);
        IList<DTONutrient> GetAll();
        IList<DTONutrient> GetAllActive();
        IList<DTONutrient> GetByName(string name);
         
    }
}
