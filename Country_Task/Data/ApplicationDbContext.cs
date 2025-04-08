using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<City> Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure relationships
        modelBuilder.Entity<User>()
            .HasOne(u => u.Country)
            .WithMany()
            .HasForeignKey(u => u.CountryId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<User>()
            .HasOne(u => u.State)
            .WithMany()
            .HasForeignKey(u => u.StateId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<User>()
            .HasOne(u => u.City)
            .WithMany()
            .HasForeignKey(u => u.CityId)
            .OnDelete(DeleteBehavior.Restrict);

        // Seed Countries
        modelBuilder.Entity<Country>().HasData(
            new Country { Id = 1, Name = "United States" },
            new Country { Id = 2, Name = "India" },
            new Country { Id = 3, Name = "United Arab Emirates" }
        );

        // Seed States
        modelBuilder.Entity<State>().HasData(
            new State { Id = 1, Name = "California", CountryId = 1 },
            new State { Id = 2, Name = "Texas", CountryId = 1 },
            new State { Id = 3, Name = "Maharashtra", CountryId = 2 },
            new State { Id = 4, Name = "Karnataka", CountryId = 2 },
            new State { Id = 5, Name = "Dubai", CountryId = 3 },
            new State { Id = 6, Name = "Abu Dhabi", CountryId = 3 }
        );

        // Seed Cities
        modelBuilder.Entity<City>().HasData(
            new City { Id = 1, Name = "Los Angeles", StateId = 1 },
            new City { Id = 2, Name = "San Francisco", StateId = 1 },
            new City { Id = 3, Name = "Houston", StateId = 2 },
            new City { Id = 4, Name = "Austin", StateId = 2 },
            new City { Id = 5, Name = "Mumbai", StateId = 3 },
            new City { Id = 6, Name = "Pune", StateId = 3 },
            new City { Id = 7, Name = "Bengaluru", StateId = 4 },
            new City { Id = 8, Name = "Mysuru", StateId = 4 },
            new City { Id = 9, Name = "Deira", StateId = 5 },
            new City { Id = 10, Name = "Jumeirah", StateId = 5 },
            new City { Id = 11, Name = "Al Khalidiyah", StateId = 6 },
            new City { Id = 12, Name = "Al Reem Island", StateId = 6 }
        );
    }


}
