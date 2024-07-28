using NES_Core_CalorieCalculator.DAL.Context;
using NES_Core_CalorieCalculator.DAL.Interfaces;
using NES_Core_CalorieCalculator.DataCore.Concretes;
using NES_Core_CalorieCalculator.DataCore.Enums;
using NES_Core_CalorieCalculator.DataCore.Services;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Services.ServiceUserInfo
{
    public class ServiceUserInfo : IServiceUserInfo
    {
        private readonly AppDbContext context;

        private readonly IRepoUserInfo repoUserInfo;
        private readonly IRepoNutritionDiary repoNutritionDiary;
        private readonly IRepoMeal repoMeal;
        private readonly IRepoNutrient repoNutrient;
        private readonly IRepoNutrientCategory repoNutrientCategory;

        public ServiceUserInfo
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
        public int Create(DTOCreateUserInfo model)
        {
            UserInfo createdUserInfo = new UserInfo();
            if (double.TryParse(model.Height, out var height) && double.TryParse(model.Weight, out var weight))
            {
                createdUserInfo.Name = model.Name;
                createdUserInfo.Surname = model.Surname;
                createdUserInfo.BirthDate = model.BirthDate;
                createdUserInfo.Gender = model.Gender;
                createdUserInfo.Email = model.Email;
                createdUserInfo.Password = model.Password;
                createdUserInfo.Height = height;
                createdUserInfo.Weight = weight;
            }
            return repoUserInfo.Create(createdUserInfo);
        }
        public int Update(DTOUserInfo model)
        {
            UserInfo updatedUserInfo = repoUserInfo.GetById(model.Id);
            updatedUserInfo.Name = model.Name;
            updatedUserInfo.Surname = model.Surname;
            updatedUserInfo.BirthDate = model.BirthDate;
            updatedUserInfo.Gender = model.Gender;
            updatedUserInfo.Email = model.Email;
            updatedUserInfo.Password = model.Password;
            updatedUserInfo.Height = model.Height;
            updatedUserInfo.Weight = model.Weight;
            updatedUserInfo.Bmi = model.Bmi;
            return repoUserInfo.Update(updatedUserInfo);
        }

        public int Delete(DTOUserInfo model)
        {
            UserInfo deletedUserInfo = repoUserInfo.GetById(model.Id);
            return repoUserInfo.Delete(deletedUserInfo);
        }

        public IList<DTOUserInfo> GetAll()
        {
            return repoUserInfo
               .GetFilteredList
               (
                    select: x => new DTOUserInfo
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Surname = x.Surname,
                        BirthDate = x.BirthDate,
                        Gender = x.Gender,
                        Email = x.Email,
                        Password = x.Password,
                        Height = x.Height,
                        Weight = x.Weight,
                        Bmi = x.Bmi
                    }
                );
        }

        public IList<DTOUserInfo> GetAllActive()
        {
            return repoUserInfo
               .GetFilteredList
               (
                    select: x => new DTOUserInfo
                    {
                        Name = x.Name,
                        Surname = x.Surname,
                        BirthDate = x.BirthDate,
                        Gender = x.Gender,
                        Email = x.Email,
                        Password = x.Password,
                        Height = x.Height,
                        Weight = x.Weight,
                        Bmi = x.Bmi
                    },
                    where: x => x.Status != Status.Dropped
                );
        }

        public DTOUserInfo GetByID(int id)
        {
            UserInfo userInfo = repoUserInfo.GetById(id);
            return new DTOUserInfo
            {
                Name = userInfo.Name,
                Surname = userInfo.Surname,
                BirthDate = userInfo.BirthDate,
                Gender = userInfo.Gender,
                Email = userInfo.Email,
                Password = userInfo.Password,
                Height = userInfo.Height,
                Weight = userInfo.Weight,
                Bmi = userInfo.Bmi
            };
        }

        public IList<DTOUserInfo> GetByName(string name)
        {
            return repoUserInfo
              .GetFilteredList
              (
                   select: x => new DTOUserInfo
                   {
                       Name = x.Name,
                       Surname = x.Surname,
                       BirthDate = x.BirthDate,
                       Gender = x.Gender,
                       Email = x.Email,
                       Password = x.Password,
                       Height = x.Height,
                       Weight = x.Weight,
                       Bmi = x.Bmi
                   },
                   where: x => x.Name.Contains(name)
               );
        }

        public bool Login(string email, string password, ref DTOUserInfo dTOUserInfo)
        {
            if (repoUserInfo.GetAny(x => x.Email == email && x.Password == password))
            {
                dTOUserInfo = repoUserInfo
                .GetFilteredListFirstOrDefault
                (
                    select: x => new DTOUserInfo()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Surname = x.Surname,
                        BirthDate = x.BirthDate,
                        Gender = x.Gender,
                        Email = x.Email,
                        Password = x.Password,
                        Height = x.Height,
                        Weight = x.Weight
                    },
                    where: x => x.Email == email && x.Password == password
                );
                return true;
            }
            else
                return false;
        }
        public bool CheckName(string name) => Encapsulation.NameControl(name);
        public bool CheckEmail(string email) => Encapsulation.EmailControl(email);
        public bool CheckPassword(string password) => Encapsulation.PassControl(password);
        public bool CheckBirthdate(DateTime birthdate) => Encapsulation.BirthDateControl(birthdate);
        public bool CheckNumber(string valueString, double max) => Encapsulation.NumberControl(valueString, max);

        public DTOUserInfo GetByEmailAndPass(string email, string password)
        { 
            return repoUserInfo
                    .GetFilteredListFirstOrDefault
                    (
                        select: x => new DTOUserInfo()
                        {
                            Id = x.Id,
                            Name = x.Name,
                            Surname = x.Surname,
                            BirthDate = x.BirthDate,
                            Gender = x.Gender,
                            Email = x.Email,
                            Password = x.Password,
                            Height = x.Height,
                            Weight = x.Weight
                        },
                        where: x => x.Email == email && x.Password == password
                    );
        }

        public bool CheckSignupInformation(DTOCreateUserInfo createdDTOUserInfo, bool radioButtonCheckedMale, bool radioButtonCheckedFemale)
        {
            double maxHeight = 300;
            double maxWeight = 300;

            if (!Encapsulation.NameControl(createdDTOUserInfo.Name))
                throw new Exception("Your name must consist of letters only and can't be null!");

            if (!Encapsulation.NameControl(createdDTOUserInfo.Surname))
                throw new Exception("Your surname must consist of letters only and can't be null!");

            if (!Encapsulation.BirthDateControl(createdDTOUserInfo.BirthDate))
                throw new Exception("Wrong birthdate!");

            if (!Encapsulation.NumberControl(createdDTOUserInfo.Height, maxHeight))
                throw new Exception($"Your height must be between 0 and {maxHeight} cm and can't be null!");

            if (!Encapsulation.NumberControl(createdDTOUserInfo.Weight, maxWeight))
                throw new Exception($"Your weight must be between 0 and {maxWeight} kg and can't be null!");

            if (!Encapsulation.EmailControl(createdDTOUserInfo.Email))
                throw new Exception("Your email address is not valid!");

            if (!Encapsulation.PassControl(createdDTOUserInfo.Password))
                throw new Exception("Your password must contain at least one lower characte, upper character, number and can't be null!");

            if (!radioButtonCheckedMale && !radioButtonCheckedFemale)
                throw new Exception("You did not select your gender!");

            DTOUserInfo notUsed = new DTOUserInfo();
            if (repoUserInfo.GetAny(x => x.Email == createdDTOUserInfo.Email))
                throw new Exception("This email is used from another user.");

            return true;

        }
    }
}
