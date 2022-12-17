using Microsoft.EntityFrameworkCore;
using PracticalExam.Models;

namespace PracticalExam.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

    }
}
