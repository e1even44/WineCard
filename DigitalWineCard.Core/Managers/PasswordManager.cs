using System.Security.Cryptography;

namespace DigitalWineCard.Core.Managers
{
    public class PasswordManager
    {
        /// <summary>
        /// generates a hashed representation of the specified password along with an unique salt
        /// </summary>
        /// <remarks>The method uses the PBKDF2 (Password-Based Key Derivation Function 2) algorithm with
        /// SHA-256  as the hash function and 10,000 iterations to derive the hash. The salt is randomly generated  for
        /// each invocation to ensure uniqueness.</remarks>
        /// <param name="password">The plain-text password to hash that cannot be null or empty.</param>
        /// <returns>The first item is the base64-encoded
        /// hash, and the second item is the base64-encoded saltT</returns>
        public static (string PasswordHash, string Salt) HashPassword(string password)
        {
            // salting: creating a random number and storing its' bytes in the byte array 
            byte[] saltBytes = new byte[16];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(saltBytes);

            // hashing: deriving the key using password, saltbytes, 10000 iterations and the hash algorithm SHA256 and storying the key's bytes in byte array
            using var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000, HashAlgorithmName.SHA256);
            byte[] hashBytes = pbkdf2.GetBytes(32);

            return (Convert.ToBase64String(hashBytes), Convert.ToBase64String(saltBytes));
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);

            using var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 100000, HashAlgorithmName.SHA256);
            byte[] enteredHash = pbkdf2.GetBytes(32);

            return Convert.ToBase64String(enteredHash) == storedHash;
        }
    }
}
