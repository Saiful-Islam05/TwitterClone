using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwitterClone.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUserProfileFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookmarks_users_UserId",
                table: "bookmarks");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_users_UserId",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_follows_users_FollowerId",
                table: "follows");

            migrationBuilder.DropForeignKey(
                name: "FK_follows_users_FollowingId",
                table: "follows");

            migrationBuilder.DropForeignKey(
                name: "FK_likes_users_UserId",
                table: "likes");

            migrationBuilder.DropForeignKey(
                name: "FK_messages_users_ReceiverId",
                table: "messages");

            migrationBuilder.DropForeignKey(
                name: "FK_messages_users_SenderId",
                table: "messages");

            migrationBuilder.DropForeignKey(
                name: "FK_notifications_users_UserId",
                table: "notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_retweets_users_UserId",
                table: "retweets");

            migrationBuilder.DropForeignKey(
                name: "FK_tweets_users_UserId",
                table: "tweets");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_users_UserId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_users_Email",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.AddColumn<string>(
                name: "AvatarUrl",
                table: "Users",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Users",
                type: "character varying(160)",
                maxLength: 160,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookmarks_Users_UserId",
                table: "bookmarks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_Users_UserId",
                table: "comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_follows_Users_FollowerId",
                table: "follows",
                column: "FollowerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_follows_Users_FollowingId",
                table: "follows",
                column: "FollowingId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_likes_Users_UserId",
                table: "likes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_messages_Users_ReceiverId",
                table: "messages",
                column: "ReceiverId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_messages_Users_SenderId",
                table: "messages",
                column: "SenderId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_notifications_Users_UserId",
                table: "notifications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_retweets_Users_UserId",
                table: "retweets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tweets_Users_UserId",
                table: "tweets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookmarks_Users_UserId",
                table: "bookmarks");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_Users_UserId",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_follows_Users_FollowerId",
                table: "follows");

            migrationBuilder.DropForeignKey(
                name: "FK_follows_Users_FollowingId",
                table: "follows");

            migrationBuilder.DropForeignKey(
                name: "FK_likes_Users_UserId",
                table: "likes");

            migrationBuilder.DropForeignKey(
                name: "FK_messages_Users_ReceiverId",
                table: "messages");

            migrationBuilder.DropForeignKey(
                name: "FK_messages_Users_SenderId",
                table: "messages");

            migrationBuilder.DropForeignKey(
                name: "FK_notifications_Users_UserId",
                table: "notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_retweets_Users_UserId",
                table: "retweets");

            migrationBuilder.DropForeignKey(
                name: "FK_tweets_Users_UserId",
                table: "tweets");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AvatarUrl",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "users",
                newName: "IX_users_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookmarks_users_UserId",
                table: "bookmarks",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_users_UserId",
                table: "comments",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_follows_users_FollowerId",
                table: "follows",
                column: "FollowerId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_follows_users_FollowingId",
                table: "follows",
                column: "FollowingId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_likes_users_UserId",
                table: "likes",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_messages_users_ReceiverId",
                table: "messages",
                column: "ReceiverId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_messages_users_SenderId",
                table: "messages",
                column: "SenderId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_notifications_users_UserId",
                table: "notifications",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_retweets_users_UserId",
                table: "retweets",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tweets_users_UserId",
                table: "tweets",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
