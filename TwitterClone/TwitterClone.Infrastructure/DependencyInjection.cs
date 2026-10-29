using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TwitterClone.Application.Interfaces;
using TwitterClone.Infrastructure.Persistence;
using TwitterClone.Infrastructure.Repositories;

namespace TwitterClone.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
           var connectionString = configuration.GetConnectionString("DefaultConnection");

            if(string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Connection string 'DefaultConnection' not found in configuration.");
            }


            services.AddDbContext<TwitterCloneDbContext>(options =>
            {
                options.UseNpgsql("Host=ep-red-wind-ax849eok-pooler.c-4.us-east-2.aws.neon.tech; Database=TwitterTest; Username=neondb_owner; Password=npg_Q4It5cJpfGzR; SSL Mode=VerifyFull; Channel Binding=Require;");
            });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITweetRepository, TweetRepository>();
            services.AddScoped<IBookmarkRepository, BookmarkRepository>();
            services.AddScoped<IFollowRepository, FollowRepository>();
            services.AddScoped<ILikeRepository, LikeRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IRetweetRepository, RetweetRepository>();

            return services;
        }
    }
}