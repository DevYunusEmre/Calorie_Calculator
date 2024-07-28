using NES_Core_CalorieCalculator.DataCore.Concretes;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Services.ServiceMeal
{
    public interface IServiceMeal
    {
        int Create(DTOMeal model);
        int Update(DTOMeal model);
        int Delete(DTOMeal model);
        DTOMeal GetById(int id);
        IList<DTOMeal> GetAll();
        IList<DTOMeal> GetAllActive();
        IList<DTOMeal> GetByName(string name);

    }
}
