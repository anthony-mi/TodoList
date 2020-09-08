using Microsoft.EntityFrameworkCore;
using TodoList.Models.Entities;

namespace TodoList.Models
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Todo.db");
        }
    }
}
