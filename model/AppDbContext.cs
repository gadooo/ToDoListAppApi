using Microsoft.EntityFrameworkCore;

namespace ToDoListAppApi.model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

        public DbSet<TaskModel> ToDoList { get; set; }
    }
}
