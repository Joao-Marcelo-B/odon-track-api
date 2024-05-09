using System.Security.Cryptography;
using System.Text;

namespace Odon.Track.Application.Crypto
{
    public static class PasswordSaltHasher
    {
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(password));

            using(var hmac = new HMACSHA512(passwordSalt))
            {
                var comptedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for(int i = 0; i < comptedHash.Length; i++)
                {
                    if (comptedHash[i] != passwordHash[i])
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
