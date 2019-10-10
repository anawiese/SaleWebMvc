using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWbMvc.Models
{
    public class SalesWbMvcContext : DbContext
    {
        public SalesWbMvcContext (DbContextOptions<SalesWbMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWbMvc.Models.Department> Department { get; set; }
    }
}
