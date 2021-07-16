using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprout.Exam.WebApp.Models
{
    public class CalculateVM
    {

        public int Id { get; set; }
        public Decimal absentDays { get; set; }
        public Decimal workedDays { get; set; }
    }
}

