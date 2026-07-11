using System;

namespace Visual.Programming.Project.Grey
{
    internal static class Session
    {
        // Holds the username of the currently logged-in user (if any)
        public static string Username { get; set; } = string.Empty;

        public static bool IsLoggedIn => !string.IsNullOrWhiteSpace(Username);
    }
}
