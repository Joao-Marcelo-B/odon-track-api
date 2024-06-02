using System.Security.Cryptography;
using System.Text;

namespace Odon.Track.Application.Crypto
{
    public class EncryptionHelper
    {
        public readonly string key = "796Y%r5v67f5S=3X4243xaz$685GB798M090-=k98M0=7N5v6#b8f4C563D34ec6586B7@7n08mh908M7JNH76b=#8g5745VD";
        public string Encrypt(string text)
        {
            byte[] plainBytes = Encoding.ASCII.GetBytes(text);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.KeySize = 256;
                aesAlg.Key = new ASCIIEncoding().GetBytes(key.Substring(8, 16));
                aesAlg.IV = new ASCIIEncoding().GetBytes(key.Substring(8, 16));

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using MemoryStream memory = new MemoryStream();
                using CryptoStream cryptoStream = new CryptoStream(memory, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] ivAndEncryptedText = memory.ToArray();
                memory.Close();
                cryptoStream.Close();

                return Convert.ToBase64String(ivAndEncryptedText);
            }
        }

        public string Decrypt(string cipherText)
        {
            byte[] cipherBytesWithIV = Convert.FromBase64String(cipherText);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.KeySize = 256;
                aesAlg.Key = new ASCIIEncoding().GetBytes(key.Substring(8, 16));
                aesAlg.IV = new ASCIIEncoding().GetBytes(key.Substring(8, 16));

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using MemoryStream msDecrypt = new MemoryStream(cipherBytesWithIV);
                using CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
                using StreamReader srDecrypt = new StreamReader(csDecrypt);

                return srDecrypt.ReadLine();    
            }
        }

    }
}
