using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Services
{
    public class ServiceCustom
    {
        public static string AssemblyName = "NES_Core_CalorieCalculator.Service";
        public static string PathOfDTOs = "NES_Core_CalorieCalculator.Service.Concretes.DTOs";

        public static string GetImplementingClassNameByIDTO(IDTO dTO)
        {
            List<string> result = new List<string>();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            List<string> matchingClasNames = new List<string>();
            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes();
                var implementingClasses = types.Where(t => typeof(IDTO).IsAssignableFrom(t) && t.IsClass);

                foreach (var implementingClass in implementingClasses)
                {
                    matchingClasNames.Add(implementingClass.Name);
                }
            }
            Type type = dTO.GetType();
            string NameOfDtoClassName = type.Name;

            foreach (string item in matchingClasNames)
            {
                if (item == NameOfDtoClassName)
                {
                    return item;
                }
            }
            return null;
        }

        public static List<string> GetPropertyNamesByDTOClass(IDTO dTO)
        {
            string dTOClassName = GetImplementingClassNameByIDTO(dTO);


            List<string> propertyNames = new List<string>(); 

            Type type = Type.GetType($"{PathOfDTOs}.{dTOClassName}, {AssemblyName}");

            if (type != null)
            {
                // Type.GetProperties() metodu ile sınıfın tüm property'lerini alıyoruz
                PropertyInfo[] properties = type.GetProperties();

                // Her bir property'nin adını yazdırıyoruz
                foreach (var property in properties)
                {
                    propertyNames.Add(property.Name); 
                }
                return propertyNames;
            }
            else
                throw new Exception("Unexpected Error");

        }
         
    }
}
