using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Infrastructure.Persistence.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("messages");
            builder.HasKey(m => m.Id);

            builder.Property(m => m.SenderId).HasField("_senderId").IsRequired();
            builder.Property(m => m.ReceiverId).HasField("_receiverId").IsRequired();
            builder.Property(m => m.Content).HasField("_content").IsRequired().HasMaxLength(1000);
            builder.Property(m => m.SentAt).HasField("_sentAt").IsRequired();
            builder.Property(m => m.IsRead).HasField("_isRead").IsRequired();

            builder.HasOne(m => m.Sender).WithMany().HasForeignKey(m => m.SenderId).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(m => m.Receiver).WithMany().HasForeignKey(m => m.ReceiverId).IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}