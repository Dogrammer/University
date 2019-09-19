using Microsoft.EntityFrameworkCore;
using University.Model.Models;

namespace University.Infrastructure.DB
{
    public class CollegeContext : DbContext
    {
        public CollegeContext(DbContextOptions<CollegeContext> options) :base(options)
        {
            
        }

        public DbSet<College> Colleges { get; set; }
        public DbSet<CollegeType> CollegeTypes { get; set; }

    }
}