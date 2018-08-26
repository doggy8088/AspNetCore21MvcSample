using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace api2.Models
{
    public partial class Todo0826Context : DbContext
    {
        public Todo0826Context()
        { }

        public Todo0826Context(DbContextOptions<Todo0826Context> options) : base(options)
        { }

        public DbQuery<MyItem> MyItems { get; set; }

        public virtual DbSet<TodoItems> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Todo0826;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Query<MyItem>().ToView("View_BlogPostCounts");
        }
    }

    public class MyItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}