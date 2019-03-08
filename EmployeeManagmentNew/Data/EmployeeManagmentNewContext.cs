using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagmentNew.Models;

namespace EmployeeManagmentNew.Models
{
    public class EmployeeManagmentNewContext : DbContext
    {
        public EmployeeManagmentNewContext (DbContextOptions<EmployeeManagmentNewContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManagmentNew.Models.Department> Department { get; set; }

        public DbSet<EmployeeManagmentNew.Models.Employee> Employee { get; set; }
    }
}
