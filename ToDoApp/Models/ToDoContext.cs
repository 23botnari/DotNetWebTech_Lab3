using System.Data.Entity;

namespace ToDoApp.Models
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
