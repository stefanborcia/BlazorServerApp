using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.Data
{
    public class TodoDbContext:DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
        }
        public DbSet<TodoItem> Todos { get; set; }
    }
}
