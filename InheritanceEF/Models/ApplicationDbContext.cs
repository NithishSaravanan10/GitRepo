// // Data/ApplicationDbContext.cs
// using Microsoft.EntityFrameworkCore;

// public class ApplicationDbContext : DbContext
// {
//     public DbSet<Person> People { get; set; }

//     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//         : base(options)
//     {
//     }

//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         modelBuilder.Entity<Person>()
//             .HasDiscriminator<string>("PersonType")
//             .HasValue<Student>("Student")
//             .HasValue<Teacher>("Teacher");
//     }
// }


// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Person>()
        .HasDiscriminator<string>("PersonType")
        .HasValue<Student>("Student")
        .HasValue<Teacher>("Teacher");

    modelBuilder.Entity<Student>().HasData(
        new Student { PersonId = 1, Name = "John Doe", StudentId = "ABC123", Grade = 11 }
    );

    modelBuilder.Entity<Teacher>().HasData(
        new Teacher { PersonId = 2, Name = "Jane Smith", TeacherId = "XYZ456", Subject = "History" }
    );
}

}
