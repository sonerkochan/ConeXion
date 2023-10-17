using ConeXion.Infrastructure.Data.Configuration;
using ConeXion.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using static ConeXion.Infrastructure.Data.Constants.GlobalConstants;

namespace ConeXion.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }


            builder.Entity<Like>()
                .HasKey(x => new { x.UserID, x.PostID });

            builder.Entity<Comment>()
                .HasKey(x => new { x.UserID, x.PostID });


            builder.Entity<User>()
              .Property(u => u.UserName)
              .HasMaxLength(UserNameMaxLength)
              .IsRequired();


            builder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(EmailMaxLength)
                .IsRequired();

            builder.ApplyConfiguration(new RoleConfigration());

            base.OnModelCreating(builder);
        }
    }
}