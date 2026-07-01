using System.Text.RegularExpressions;

namespace Visual.Programming.Project.Grey
{
    internal static class ValidationHelper
    {
        private static readonly Regex EmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
        private static readonly Regex PhoneRegex = new Regex(@"^[0-9\-\+\s\(\)]{7,20}$", RegexOptions.Compiled);

        public static bool IsValidName(string name) => !string.IsNullOrWhiteSpace(name) && name.Length >= 2;
        public static bool IsValidEmail(string email) => !string.IsNullOrWhiteSpace(email) && EmailRegex.IsMatch(email);
        public static bool IsValidPhone(string phone) => !string.IsNullOrWhiteSpace(phone) && PhoneRegex.IsMatch(phone);
        public static bool IsValidAddress(string address) => !string.IsNullOrWhiteSpace(address) && address.Length >= 5;
        public static bool IsValidCardNumber(string card) => !string.IsNullOrWhiteSpace(card) && card.Length >= 12 && card.Length <= 19 && ulong.TryParse(card, out _);
    }
}
