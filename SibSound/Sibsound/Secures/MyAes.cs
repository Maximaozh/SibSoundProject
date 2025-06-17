using System;
using System.Security.Cryptography;
using System.Text;

namespace Sibsound.Secures
{
    // Доработай чтобы здесь работало шифрование от имени в ключе!
    internal class MyAes
    {
        static public byte[] Crypt(string key, string data)
        {
            byte[] encryptedBytes;
            using (Aes aes = Aes.Create())
            {
                var toHash = Encoding.UTF8.GetBytes("ywrxYjaI60GDfNce" + key + "HVAkOxXiY+ERKDlx");

                SHA256 sha256 = SHA256.Create();
                byte[] aesKey = sha256.ComputeHash(toHash);

                aes.Key = aesKey;
                aes.IV = Encoding.UTF8.GetBytes("ywrxYjaI60GDfNce");
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(data);
                        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                    }
                    encryptedBytes = msEncrypt.ToArray();
                }
            }
            return encryptedBytes;
        }
        static public string Decrypt(string key, byte[] data)
        {
            try
            {

                byte[] decryptedBytes;
                using (Aes aes = Aes.Create())
                {
                    var toHash = Encoding.UTF8.GetBytes("ywrxYjaI60GDfNce" + key + "HVAkOxXiY+ERKDlx");

                    SHA256 sha256 = SHA256.Create();
                    byte[] aesKey = sha256.ComputeHash(toHash);

                    aes.Key = aesKey;
                    aes.IV = Encoding.UTF8.GetBytes("ywrxYjaI60GDfNce");
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                    using (var msDecrypt = new System.IO.MemoryStream(data))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var msPlain = new System.IO.MemoryStream())
                            {
                                csDecrypt.CopyTo(msPlain);
                                decryptedBytes = msPlain.ToArray();
                            }
                        }
                    }
                }

                return Encoding.UTF8.GetString(decryptedBytes);
            }catch(Exception ex)
            {
                return "";
            }
        }
    }
}
