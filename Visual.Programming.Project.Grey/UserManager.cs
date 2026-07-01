using System;
using System.Collections.Generic;

namespace Visual.Programming.Project.Grey
{
    internal static class UserManager
    {
        // In-memory user store for session; persisted to Excel as requested
        public static readonly List<User> Users = new();

        public static void SaveUser(User user)
        {
            if (user == null) return;
            Users.Add(user);
            // Persist to Excel using helper
            try
            {
                Helpers.ExcelHelper.AppendCredential(user.Name, user.Email, user.Password);
            }
            catch
            {
                // Swallow for now - do not crash UI on persistence error
            }
        }
    }

    internal class User
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; // per user choice: plain text (not recommended)
    }
}
