using Microsoft.EntityFrameworkCore;
using Personal_profiling_and_Assistance.Data.Models;

namespace Personal_profiling_and_Assistance.Data
{
    public class MyDbContext : DbContext // to use entity framework 
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)  // ask mena what is this code 
        { 
        
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }

    }
}
