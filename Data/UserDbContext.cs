using Microsoft.EntityFrameworkCore;
using webapp.Models;

namespace webapp.Data
{
    public class UserDbContext :DbContext
    {
         
       // public UserDbContext() { }
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }

}
