using NES_Core_CalorieCalculator.DataCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.DataCore.Abstracts
{
    /// <summary>
    /// Ortak özelliklerin bulunduğu Base. Abstract çünkü nesne oluşturulması istenmiyor.
    /// </summary>
    public abstract class Base
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? DropDate { get; set; }
        public Status Status { get; set; } = Status.Created;
    }
}
