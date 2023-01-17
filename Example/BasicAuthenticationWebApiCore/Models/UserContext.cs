using Microsoft.EntityFrameworkCore;

namespace BasicAuthenticationWebApiCore.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users
        {
            get;
            set;
        }
    }
}
