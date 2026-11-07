using MyTillApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace TillsPOSSystem.api
{

    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserModel> Employees { get; set; }
    }
}
