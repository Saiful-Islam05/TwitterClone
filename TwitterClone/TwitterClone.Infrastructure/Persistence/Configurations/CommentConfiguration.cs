using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Infrastructure.Persistence.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("comments");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.UserId).HasField("_userId").IsRequired();
            builder.Property(c => c.TweetId).HasField("_tweetId").IsRequired();
            builder.Property(c => c.Content).HasField("_content").IsRequired().HasMaxLength(200);

            builder.HasOne(c => c.User).WithMany().HasForeignKey(c => c.UserId).IsRequired();
            builder.HasOne(c => c.Tweet).WithMany().HasForeignKey(c => c.TweetId).IsRequired();
        }
    }
}