using Microsoft.EntityFrameworkCore;
using SocialNetwork.Models;
namespace SocialNetwork.Data
{
    public class SocialNetworkDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public SocialNetworkDbContext(DbContextOptions<SocialNetworkDbContext> options)
        : base(options)
        {
        }
    }
}
