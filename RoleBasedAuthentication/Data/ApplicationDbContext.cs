using Microsoft.EntityFrameworkCore;
namespace RoleBasedAuthentication.Models;


public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
    {

    }

    public DbSet<User> UserList{get; set;}
}