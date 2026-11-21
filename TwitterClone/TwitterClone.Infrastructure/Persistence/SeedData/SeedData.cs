using System;
using TwitterClone.Domain.Constants;

namespace TwitterClone.Infrastructure.Persistence.SeedData
{
    public static class SeedData
    {
        private static readonly Guid SystemUserId = Guid.Parse("00000000-0000-0000-0000-000000000001");
        private static readonly DateTime SeedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        // Role Ids
        public static readonly Guid AdminRoleId = Guid.Parse("11111111-1111-1111-1111-111111111111");
        public static readonly Guid UserRoleId = Guid.Parse("22222222-2222-2222-2222-222222222222");
        public static readonly Guid ModeratorRoleId = Guid.Parse("33333333-3333-3333-3333-333333333333");

        // Permission Ids
        public static readonly Guid UsersReadId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");
        public static readonly Guid UsersDeleteId = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb");
        public static readonly Guid RolesManageId = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc");

        public static object[] Roles() => new object[]
        {
            new { Id = AdminRoleId,     Name = RoleNames.Admin,     CreatedAt = SeedDate, CreatedBy = SystemUserId },
            new { Id = UserRoleId,      Name = RoleNames.User,      CreatedAt = SeedDate, CreatedBy = SystemUserId },
            new { Id = ModeratorRoleId, Name = RoleNames.Moderator, CreatedAt = SeedDate, CreatedBy = SystemUserId }
        };

        public static object[] Permissions() => new object[]
        {
            new { Id = UsersReadId,   Name = PermissionNames.UsersRead,   CreatedAt = SeedDate, CreatedBy = SystemUserId },
            new { Id = UsersDeleteId, Name = PermissionNames.UsersDelete, CreatedAt = SeedDate, CreatedBy = SystemUserId },
            new { Id = RolesManageId, Name = PermissionNames.RolesManage, CreatedAt = SeedDate, CreatedBy = SystemUserId }
        };

        public static object[] RolePermissions() => new object[]
        {
            // Admin:All permission
            new { Id = Guid.Parse("a0000000-0000-0000-0000-000000000001"), RoleId = AdminRoleId, PermissionId = UsersReadId,   CreatedAt = SeedDate, CreatedBy = SystemUserId },
            new { Id = Guid.Parse("a0000000-0000-0000-0000-000000000002"), RoleId = AdminRoleId, PermissionId = UsersDeleteId, CreatedAt = SeedDate, CreatedBy = SystemUserId },
            new { Id = Guid.Parse("a0000000-0000-0000-0000-000000000003"), RoleId = AdminRoleId, PermissionId = RolesManageId, CreatedAt = SeedDate, CreatedBy = SystemUserId },

            // Moderator: users read ও delete
            new { Id = Guid.Parse("b0000000-0000-0000-0000-000000000001"), RoleId = ModeratorRoleId, PermissionId = UsersReadId,   CreatedAt = SeedDate, CreatedBy = SystemUserId },
            new { Id = Guid.Parse("b0000000-0000-0000-0000-000000000002"), RoleId = ModeratorRoleId, PermissionId = UsersDeleteId, CreatedAt = SeedDate, CreatedBy = SystemUserId }
        };
    }
}