using NES_Core_CalorieCalculator.DataCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Concretes.DTOs
{
    public class DTOUserInfo : IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double? Bmi { get; set; }
    }
}
