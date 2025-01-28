using Microsoft.EntityFrameworkCore;

namespace Personal_profiling_and_Assistance.Data
{
    public class MyDbContext : DbContext // to use entity framework 
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)  // ask mena what is this code 
        { 
        
        }

    }
}
