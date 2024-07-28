using NES_Core_CalorieCalculator.DataCore.Abstracts;
using NES_Core_CalorieCalculator.DataCore.Concretes.Composites;
using NES_Core_CalorieCalculator.DataCore.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DataCore.Concretes
{
    /// <summary>
    /// Base: Birçok sınıfta bulunan ortak property'ler kalıtım alınmıştır.
    /// IBase: İşaretleme yapmak için bir Interface'den kalıtım alınmıştır.
    /// </summary>
    public class UserInfo : Base, IBase
    {
        //Fields
        private string name;
        private string surname;
        private DateTime birthDate;
        private string email;
        private string password;
        private double height;
        private double weight;

        //Properties 
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; } 

         public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get;
            set;
        }
        public double Height
        {
            get;
            set;
        }
        public double Weight
        {
            get;
            set;
        }
        public double? Bmi { get; set; }//Body mass index

        //Navigation Property

        //UserInfoNutrientDiary 
        public virtual ICollection<UserInfoNutrientDiary> UserInfoNutrientDiaries { get; set; }



    }
}
