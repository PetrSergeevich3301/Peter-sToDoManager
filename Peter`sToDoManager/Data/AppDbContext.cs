using Microsoft.EntityFrameworkCore;

namespace Peter_sToDoManager
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        public DbSet<TaskModel> Tasks { get; set; }
    }
}
