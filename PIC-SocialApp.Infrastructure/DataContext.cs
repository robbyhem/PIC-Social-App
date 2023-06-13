using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PIC_SocialApp.Domain.Assembly.PostAssembly;
using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;
using PIC_SocialApp.Infrastructure.Configurations;

namespace PIC_SocialApp.Infrastructure
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new PostCommentConfig());
            builder.ApplyConfiguration(new PostInteractionConfig());
            builder.ApplyConfiguration(new UserProfileConfig());
        }
    }
}
