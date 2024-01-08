using LoginWithCrud.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LoginWithCrud.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Login> Logins { get; set; }
    }
}
