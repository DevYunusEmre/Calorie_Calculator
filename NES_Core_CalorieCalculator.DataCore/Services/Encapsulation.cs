using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NES_Core_CalorieCalculator.DataCore.Services
{
    public class Encapsulation
    {
        public static bool NameControl(string name)
        {
            if (name.Count() == 0) return false;

            foreach (char ch in name)
            {
                if (char.IsDigit(ch))
                    return false;
            }
            return true;
        }
        public static bool PassControl(string sifre)
        {
            if (sifre.Count() == 0) return false;

            if (!string.IsNullOrWhiteSpace(sifre))
            {
                foreach (char s in sifre)
                {
                    if (sifre.All(char.IsLetter) || sifre.All(char.IsDigit))
                        return false;
                    else
                        return true;
                }
                return false;
            }
            else
                return false;
        }
        //public static bool PassControl(string password)
        //{
        //    if (string.IsNullOrEmpty(password))
        //    {
        //        return false;
        //    }
        //    //(?=.*[a-z]): En az bir küçük harf içermesi gerektiğini belirtir.
        //    //(?=.*[A-Z]): En az bir büyük harf içermesi gerektiğini belirtir.
        //    //(?=.*\d): En az bir rakam içermesi gerektiğini belirtir.
        //    //(?=.*[\W_]): En az bir özel karakter içermesi gerektiğini belirtir.
        //    //.+$: Satırın tamamında en az bir karakter bulunmasını belirtir.
        //    string pattern = @"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[\W_]).+$";
        //    //Bu metod, password değişkeninin pattern regex deseni ile eşleşip eşleşmediğini kontrol eder. Eşleşirse true, eşleşmezse false döner.
        //    return Regex.IsMatch(password, pattern);
        //}

        public static bool NumberControl(string valuestring, double max)
        {
            double valuedouble;
            if (double.TryParse(valuestring, out valuedouble))
            {
                if (valuedouble > 0 && valuedouble <= max)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public static bool EmailControl(string email)
        {
            if (email.Count() == 0) return false; 

            if (string.IsNullOrWhiteSpace(email))
                return false;
            if (!email.Contains("@") || email.Contains(" "))
                return false;

            if (!email.EndsWith(".com"))
                return false;

            if (email.Split('@').Length > 2)
                return false;

            if (email.Split(".com").Length > 2)
                return false;

            return true;
        }
        public static bool BirthDateControl(DateTime birthdate)
        {
            if (birthdate < DateTime.Now)
                return true;
            else
                return false;
        }

    }
}
