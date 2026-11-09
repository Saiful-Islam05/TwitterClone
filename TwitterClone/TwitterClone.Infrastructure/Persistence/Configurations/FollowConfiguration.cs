using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Infrastructure.Persistence.Configurations
{
    public class FollowConfiguration : IEntityTypeConfiguration<Follow>
    {
        public void Configure(EntityTypeBuilder<Follow> builder)
        {
            builder.ToTable("follows");
            builder.HasKey(f => f.Id);

            builder.Property(f => f.FollowerId).IsRequired();
            builder.Property(f => f.FollowingId).IsRequired();

            builder.HasOne(f => f.Follower).WithMany().HasForeignKey(f => f.FollowerId).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(f => f.Following).WithMany().HasForeignKey(f => f.FollowingId).IsRequired().OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(f => new { f.FollowerId, f.FollowingId }).IsUnique();
        }
    }
}