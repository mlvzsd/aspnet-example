using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TodoAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
          : base(options) {}
        
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
        public void SeedDb()
        {
            TodoItems.AddRange(GetSeedingTodoItems());
            SaveChanges();
        }
        public static List<TodoItem> GetSeedingTodoItems()
        {
          return new List<TodoItem>()
          {
            new TodoItem(){ Id = 1, Name = "Comer queijo",           IsComplete = true },
            new TodoItem(){ Id = 2, Name = "Alimentar o peixe",      IsComplete = false},
            new TodoItem(){ Id = 3, Name = "Passear com o cachorro", IsComplete = false}
          };
        }
    }
}