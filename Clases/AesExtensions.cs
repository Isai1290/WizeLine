using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt.Clases
{
    public static class AesExtensions
    {
        static AesCryptoServiceProvider Cifrador = new AesCryptoServiceProvider();

        //private static string AesKey { get; } = "Tis0wosTbuEUQldRGhJJbQ1mmdqauOHLrMR0j/ZarwM=";
        //private static string AesIv { get; } = "jI42F/YEvzL7WqSQyATlmw==";

        /// <summary>        /// Decifra un texto encriptado con Aes
        /// </summary>       /// <param name="cipherText"></param>        
        ///                  /// <returns></returns>        
        public static string DecryptString(this string cipherText, string AesKey, string AesIv)
        {
            try
            {
                return Decrypt(cipherText, Convert.FromBase64String(AesKey), Convert.FromBase64String(AesIv));
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        private static string Decrypt(string cipherText, byte[] Key, byte[] IV)
        {
            try
            {
                Aes aesManaged = Aes.Create();
                ICryptoTransform transform = aesManaged.CreateDecryptor(Key, IV);
                var stream = new MemoryStream(Convert.FromBase64String(cipherText));
                var stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
                var streamReader = new StreamReader(stream2);
                return streamReader.ReadToEnd();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string EncryptString(this string cipherText, string AesKey, string AesIv)
        {
            try
            {
                return Encrypt(cipherText, Convert.FromBase64String(AesKey), Convert.FromBase64String(AesIv));
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static String Encrypt(String cadena, byte[] Key, byte[] IV)
        {
            try
            {
                ICryptoTransform transforma = Cifrador.CreateEncryptor(Key, IV);
                byte[] CadenaCifrada = transforma.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
                return Convert.ToBase64String(CadenaCifrada);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}