using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DepartementAspCore.Models
{
    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
       
    }
}
