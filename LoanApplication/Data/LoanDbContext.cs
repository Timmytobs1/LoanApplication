using LoanApplication.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoanApplication.Data
{
    public class LoanDbContext : DbContext
    {
        public LoanDbContext(DbContextOptions<LoanDbContext> options) : base(options) 
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LoanDetails> LoanDetails { get; set; }
    }
}
