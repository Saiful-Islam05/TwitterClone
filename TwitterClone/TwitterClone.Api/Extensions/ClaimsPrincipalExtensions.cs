using System.Security.Claims;
namespace TwitterClone.Api.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static Guid GetUserId(this ClaimsPrincipal user)
        {
            var value = user.FindFirstValue(ClaimTypes.NameIdentifier)
                        ?? user.FindFirstValue("sub");

            if (value is null || !Guid.TryParse(value, out var userId))
                throw new UnauthorizedAccessException("User id claim is missing or invalid.");

            return userId;
        }
    }
}
