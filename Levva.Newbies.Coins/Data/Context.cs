using Levva.Newbies.Coins.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Levva.Newbies.Coins.Data
{
    public class Context : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Category> Category { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
