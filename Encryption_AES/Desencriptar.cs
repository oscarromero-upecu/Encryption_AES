using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Encryption_AES
{
    public class Desencriptar
    {


        public string Descrypt256 (string cipher_text)
        {
            int keySize = 256;
            var cipherMode = CipherMode.ECB;
            var key = Encoding.ASCII.GetBytes("33L4V1DAESV3LLANO4CAM1B10XNAD488");

            try
            {
                var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipher_text);
                var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(keySize / 8).Take(keySize / 8).ToArray();
                //string plainText = null;
                using (Aes aes = Aes.Create())
                {
                    aes.KeySize = keySize;
                    aes.Mode = cipherMode;
                    aes.Padding = PaddingMode.PKCS7;

                    ICryptoTransform decryptor = aes.CreateDecryptor(key, null);
                    byte[] enc_bytes = Convert.FromBase64String(cipher_text);

                    byte[] descrypted_byte = decryptor.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);

                    string str = ASCIIEncoding.ASCII.GetString(descrypted_byte);

                    return str;
                }
                
            }
            catch (Exception e)
            {
                return "Error al descifrar respuesta. " + e.Message;
            }
        } 
        
        public string Descrypt128 (string cipher_text)
        {
            int keySize = 128;
            var cipherMode = CipherMode.ECB;
            var key = Encoding.ASCII.GetBytes("33L4V1DAESV3LLAN");

            try
            {
                var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipher_text);
                var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(keySize / 8).Take(keySize / 8).ToArray();
                //string plainText = null;
                using (Aes aes = Aes.Create())
                {
                    aes.KeySize = keySize;
                    aes.Mode = cipherMode;
                    aes.Padding = PaddingMode.PKCS7;

                    ICryptoTransform decryptor = aes.CreateDecryptor(key, null);
                    byte[] enc_bytes = Convert.FromBase64String(cipher_text);

                    byte[] descrypted_byte = decryptor.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);

                    string str = ASCIIEncoding.ASCII.GetString(descrypted_byte);

                    return str;
                }
                
            }
            catch (Exception e)
            {
                return "Error al descifrar respuesta. " + e.Message;
            }
        }

    }
}
