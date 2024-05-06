using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace Odon.Track.Application.Crypto
{
    public static class PasswordSaltHasher
    {
        public static void CreatePasswordSaltHasher(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if(string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(password));

            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] hash, byte[] salt)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(password));

            using(var hmac = new HMACSHA512(salt))
            {
                var comptedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for(int i = 0; i < comptedHash.Length; i++)
                {
                    if (comptedHash[i] != hash[i])
                        return false;
                }
            }

            return true;
        }


        public static void CreatePasswordHashAndSalt(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var generator = RandomNumberGenerator.Create())
            {
                var salt = new byte[16];
                generator.GetBytes(salt);
                passwordSalt = salt;
            }

            using (var hmac = new HMACSHA512(passwordSalt))
            {
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
