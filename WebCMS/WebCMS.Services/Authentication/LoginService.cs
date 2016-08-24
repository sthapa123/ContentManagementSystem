using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebCMS.Entities;

namespace WebCMS.Services.Authentication
{
    public interface ILoginService
    {
        int? Login(string emailAddress, string password);
    }
    public class LoginService : ILoginService
    {
        #region Dependencies
        private readonly WebEntityModel _context;

        public LoginService(WebEntityModel context)
        {
            _context = context;
        }

        #endregion
        public int? Login(string emailAddress, string password)
        {
            var userAccount = _context.Users.FirstOrDefault(x => x.EmailAddress.Equals(emailAddress, System.StringComparison.OrdinalIgnoreCase));

            if (userAccount == null) return null;

            if (!CompareSecurePassword(password, userAccount.Password)) return null;

            return userAccount.UserId;
        }

        public static bool CompareSecurePassword(string passwordAttempt, string passwordActual)
        {
            var savedPasswordHash = passwordActual;
            var hashBytes = Convert.FromBase64String(savedPasswordHash);
            var salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            using (var pbkdf2 = new Rfc2898DeriveBytes(passwordAttempt, salt, 10000))
            {
                var hash = pbkdf2.GetBytes(20);
                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash[i])
                        return false;
                return true;
            }
        }
    }
}
