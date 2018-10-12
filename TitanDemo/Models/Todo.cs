namespace TitanDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TodoEntities : DbContext
    {
        public TodoEntities()
            : base("name=Todo")
        {
        }

        public virtual DbSet<Todo> Todos { get; set; }
    }

    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}