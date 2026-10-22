using EmployeeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{

        //}
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(18, 2);
        }

        //protected ApplicationDbContext()
        //{
        //}
    }
}
