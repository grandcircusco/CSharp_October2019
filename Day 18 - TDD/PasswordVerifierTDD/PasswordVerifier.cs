using System;
using System.Text.RegularExpressions;

namespace PasswordVerifierTDD
{
    class PasswordVerifier
    {
        public static bool VerifyPassword(string password)
        {
            if (password.Length >= 8)
            {
                if (password.Contains("!") ||
                    password.Contains("@") ||
                    password.Contains("$"))
                {
                    if (Regex.IsMatch(password, @"(?=.*\d)"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
