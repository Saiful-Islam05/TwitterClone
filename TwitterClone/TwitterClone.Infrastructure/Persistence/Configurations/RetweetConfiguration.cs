using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Infrastructure.Persistence.Configurations
{
    public class RetweetConfiguration : IEntityTypeConfiguration<Retweet>
    {
        public void Configure(EntityTypeBuilder<Retweet> builder)
        {
            builder.ToTable("retweets");
            builder.HasKey(r => r.Id);

            builder.Property(r => r.UserId).HasField("_userId").IsRequired();
            builder.Property(r => r.TweetId).HasField("_tweetId").IsRequired();
            builder.Property(r => r.RetweetedAt).HasField("_retweetedAt").IsRequired();
            builder.Property(r => r.Comment).HasField("_comment").HasMaxLength(200);

            builder.HasOne(r => r.User).WithMany().HasForeignKey(r => r.UserId).IsRequired();
            builder.HasOne(r => r.Tweet).WithMany().HasForeignKey(r => r.TweetId).IsRequired();

            builder.HasIndex(r => new { r.UserId, r.TweetId }).IsUnique();
        }
    }
}