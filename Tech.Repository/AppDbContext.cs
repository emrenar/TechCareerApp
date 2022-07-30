using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tech.Core.Concrete;

namespace Tech.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Post>().HasData(
                new Post { PostId = 1, UserId = 1, Title = "Title 1 ", Body = "Body 1", CreateDate = DateTime.Now },
                new Post { PostId = 2, UserId = 2, Title = "Title 2 ", Body = "Body 2", CreateDate = DateTime.Now },
                new Post { PostId = 3, UserId = 1, Title = "Title 3 ", Body = "Body 3", CreateDate = DateTime.Now }

                );

        }
    }
}
