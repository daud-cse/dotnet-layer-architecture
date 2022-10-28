using DAL.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contexts
{
    public class DotNetDbContext : DbContext
    {

        public DotNetDbContext(DbContextOptions<DotNetDbContext> options) : base(options)
        {

        }
        public DbSet<IncomeAndCost> IncomeAndCost { get; set; }
    }
}
