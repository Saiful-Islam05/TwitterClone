using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Infrastructure.Persistence.Configurations
{
    public class LikeConfiguration : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.ToTable("likes");
            builder.HasKey(l => l.Id);

            builder.Property(l => l.UserId).HasField("_userId").IsRequired();
            builder.Property(l => l.TweetId).HasField("_tweetId").IsRequired();
            builder.Property(l => l.LikedAt).HasField("_likedAt").IsRequired();

            builder.HasOne(l => l.user).WithMany().HasForeignKey(l => l.UserId).IsRequired();
            builder.HasOne(l => l.tweet).WithMany().HasForeignKey(l => l.TweetId).IsRequired();

            builder.HasIndex(l => new { l.UserId, l.TweetId }).IsUnique();
        }
    }
}