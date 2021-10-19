using BookManagerAPI.Entitys;
using Microsoft.EntityFrameworkCore;

namespace BookManagerAPI.Context
{
    public class BookManagerContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=BookManager;Trusted_Connection=True");
        }
    }
}
