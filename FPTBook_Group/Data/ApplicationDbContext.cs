using FPTBook_Group.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FPTBook_Group.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

<<<<<<< Updated upstream
        public DbSet<Category> Categories { get; set; }
=======
        /*  public DbSet<Category> Categories { get; set; }

          public DbSet<PublishCompany> PublishCompanies { get; set; }*/
        public DbSet<Book> Books { get; set; }

>>>>>>> Stashed changes
    }
}