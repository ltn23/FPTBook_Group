using FPTBook_Group.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace FPTBook_Group.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
<<<<<<< HEAD
        public DbSet<Book> Books { get; set; }

        public DbSet<PublishCompany> PublishCompanies { get; set; }



=======
        public DbSet<PublishCompany>PublishCompanies {  get; set; }  
        public DbSet<Book> Books { get; set; }  
>>>>>>> master


    }
}