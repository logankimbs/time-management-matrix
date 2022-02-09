using System;
using Microsoft.EntityFrameworkCore;
using time_management_matrix.Models;

namespace time_management_matrix.Models
{
    public class TaskFormContext : DbContext
    {
        public TaskFormContext(DbContextOptions<TaskFormContext> options) : base(options)
        {

        }
        public DbSet<TaskForm> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
               new Category { CategoryId = 1, CategoryName = "Home" },
               new Category { CategoryId = 2, CategoryName = "School" },
               new Category { CategoryId = 3, CategoryName = "Work" },
               new Category { CategoryId = 4, CategoryName = "Church" }
               );
            mb.Entity<TaskForm>().HasData(

                new TaskForm
                {
                    TaskID = 1,
                    CategoryId = 1,
                    Task = "Mission 6",
                    DueDate = new DateTime(2022, 01, 09),
                    Quadrant = 1,

                    Completed = false
                }

             );
    }
}
}
