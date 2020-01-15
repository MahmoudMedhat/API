using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DepartementAspCore.Models
{
    public class Departement
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public int EmpID { get; set; }
        [ForeignKey("EmpID")]
        public ICollection<Employees> departements { get; set; }
    }
}
