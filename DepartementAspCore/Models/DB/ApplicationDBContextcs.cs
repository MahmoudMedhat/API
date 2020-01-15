using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartementAspCore.Models.DB
{
    public class ApplicationDBContextcs : DbContext
    {
        public ApplicationDBContextcs(DbContextOptions<ApplicationDBContextcs> options)
            : base(options)
        {

        }
        public DbSet<Departement> departements { get; set; }
        public DbSet<Employees> Employees { get; set; }
        
    }
}
