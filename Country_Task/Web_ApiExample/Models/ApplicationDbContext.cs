
using Microsoft.EntityFrameworkCore;
using Web_ApiExample.Models;

public class ApplicationDbContext : DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "cat1", Description = "Cat1Desc" },
            new Category { Id=2 ,Name="Cat2", Description="Cat2Desc"}
            );
    }
}



