namespace MobileShop
{
    // Simple session holder for currently logged in user
    public static class Session
    {
        // 0 means no user logged in
        public static int UserId { get; set; } = 0;

        // Optional: store user's display name
        public static string UserName { get; set; } = string.Empty;

        // Optional: store user's role (e.g., Admin, User)
        public static string Role { get; set; } = string.Empty;
    }
}
