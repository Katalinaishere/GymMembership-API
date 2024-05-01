using FitnessApp;
using Membership.ProAPI.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Membership.ProAPI
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Member> Members { get; set; }
        public DbSet<Models.Membership> Memberships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the Price property to use the appropriate SQL server column type
            modelBuilder.Entity<Models.Membership>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18, 2)");
        }

        internal object AddMember(PostMemberDto payload)
        {
            throw new NotImplementedException();
        }

        internal object GetMembers()
        {
            throw new NotImplementedException();
        }
    }
}