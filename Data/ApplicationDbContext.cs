using Microsoft.EntityFrameworkCore;
using PocketBook.Models;
namespace PocketBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<User> User{get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options)
        {
            
        }
    }
}