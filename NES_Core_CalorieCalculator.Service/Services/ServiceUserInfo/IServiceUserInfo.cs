using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Services.ServiceUserInfo
{
    public interface IServiceUserInfo
    {
        int Create(DTOCreateUserInfo model);
        int Update(DTOUserInfo model);
        int Delete(DTOUserInfo model);
        DTOUserInfo GetByID(int id);
        IList<DTOUserInfo> GetAll();
        IList<DTOUserInfo> GetAllActive();
        IList<DTOUserInfo> GetByName(string name);
        bool Login(string email, string password, ref DTOUserInfo currentDTOUserInfo);
        DTOUserInfo GetByEmailAndPass(string email, string password);
        bool CheckName(string name);
        bool CheckEmail(string email);
        bool CheckPassword(string password);
        bool CheckBirthdate(DateTime birthdate);
        public bool CheckNumber(string valueString, double max);
        public bool CheckSignupInformation(DTOCreateUserInfo createdDTOUserInfo, bool radioButtonCheckedMale, bool radioButtonCheckedFemale);
    }
}
