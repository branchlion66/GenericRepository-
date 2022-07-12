using BaseRepo.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
    }
}
