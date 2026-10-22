using TwitterClone.Application.Interfaces;      
using TwitterClone.Application.Services;         
using TwitterClone.Infrastructure.Repositories;  

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


// repository registration

builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();   


builder.Services.AddSingleton<ITweetRepository, TweetRepository>();
builder.Services.AddScoped<ITweetService, TweetService>();


//  Like
builder.Services.AddSingleton<ILikeRepository, LikeRepository>();
builder.Services.AddScoped<ILikeService, LikeService>();

//  Retweet
builder.Services.AddSingleton<IRetweetRepository, RetweetRepository>();
builder.Services.AddScoped<IRetweetService, RetweetService>();

//  Message
builder.Services.AddSingleton<IMessageRepository, MessageRepository>();
builder.Services.AddScoped<IMessageService, MessageService>();

//  Bookmark
builder.Services.AddSingleton<IBookmarkRepository, BookmarkRepository>();
builder.Services.AddScoped<IBookmarkService, BookmarkService>();

//  Follow
builder.Services.AddSingleton<IFollowRepository, FollowRepository>();
builder.Services.AddScoped<IFollowService, FollowService>();

//  Notification
builder.Services.AddSingleton<INotificationRepository, NotificationRepository>();
builder.Services.AddScoped<INotificationService, NotificationService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();