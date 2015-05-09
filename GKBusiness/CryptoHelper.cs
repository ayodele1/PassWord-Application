using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GKBusiness
{
    public static class CryptoHelper
    {
        #region ConstantVariables
        private static byte[] key = { 123, 217, 19, 11, 24, 26, 85, 45, 114, 184, 27, 162, 37, 112, 222, 209, 241, 24, 175, 144, 173, 53, 196, 29, 24, 26, 17, 218, 131, 236, 53, 209 };
        private static byte[] vector = { 146, 64, 191, 111, 23, 3, 113, 119, 231, 121, 221, 112, 79, 32, 114, 156 };
        #endregion

        //Encrypts a byte array from the memory stream
        public static byte[] Encrypt(byte[] buffer)
        {
            byte[] encryptedDocument = AesEncrypt(buffer, key, vector);
            return encryptedDocument;
        }
        public static byte[] Decrypt(byte[] buffer)
        {
            byte[] decryptedDocument = AesDecrypt(buffer, key, vector);
            return decryptedDocument;
        }

        #region Private Methods
        private static byte[] AesEncrypt(byte[] buffer, byte[] Key, byte[] IV)
        {
            byte[] encryptedByte;
            Aes aesAlg = Aes.Create();
            using (aesAlg)
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(Key, IV);

                MemoryStream msEncrypt = new MemoryStream();
                using (msEncrypt)
                {
                    CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
                    using (csEncrypt)
                    {
                        csEncrypt.Write(buffer, 0, buffer.Length);
                        csEncrypt.FlushFinalBlock();
                    }
                    encryptedByte = msEncrypt.ToArray();
                }
            }
            return encryptedByte;
        }

        private static byte[] AesDecrypt(byte[] cipherbuffer, byte[] key, byte[] IV)
        {
            byte[] decryptedBytes;
            Aes aesAlg = Aes.Create();
            using (aesAlg)
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(key, IV);

                MemoryStream msDecrypt = new MemoryStream();
                using (msDecrypt)
                {
                    CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write);
                    using (csDecrypt)
                    {
                        try
                        {
                            csDecrypt.Write(cipherbuffer, 0, cipherbuffer.Length);
                            csDecrypt.FlushFinalBlock();
                        }
                        catch (CryptographicException)
                        {
                            throw new CryptographicException();
                        }

                    }
                }
                decryptedBytes = msDecrypt.ToArray();
            }
            return decryptedBytes;
        }
        #endregion
    }
}
