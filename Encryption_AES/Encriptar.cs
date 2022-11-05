using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encryption_AES
{
    public class Encriptar
    {

        public string encrypt256 (string clear_text)
        {
            try
            {
                string key = "33L4V1DAESV3LLANO4CAM1B10XNAD488";
                string IV = "OSCAR742JUAN8742";
                byte[] bytesClaro = Encoding.Unicode.GetBytes(clear_text);

                byte[] textoEncriptado;

                using (Aes aes = Aes.Create())
                {
                    aes.KeySize = 256;
                    aes.Mode = CipherMode.ECB;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.BlockSize = 128;
                    aes.Key = Encoding.ASCII.GetBytes(key);
                    aes.IV = Encoding.ASCII.GetBytes(IV);

                    ICryptoTransform encryptor = aes.CreateEncryptor();
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                            {
                                streamWriter.Write(clear_text);
                            }
                            textoEncriptado = memoryStream.ToArray();
                        }
                    }
                    string str = Convert.ToBase64String(textoEncriptado);

                    return str;
                }
            }
            catch (Exception e)
            {
                return "Error al encriptar respuesta. " + e.Message;
            }
        }
        
        
        public string encrypt128 (string clear_text)
        {
            try
            {
                string key = "33L4V1DAESV3LLAN";
                string IV = "OSCAR742JUAN8742";
                byte[] bytesClaro = Encoding.Unicode.GetBytes(clear_text);

                byte[] textoEncriptado;

                using (Aes aes = Aes.Create())
                {
                    aes.KeySize = 128;
                    aes.Mode = CipherMode.ECB;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.BlockSize = 128;
                    aes.Key = Encoding.ASCII.GetBytes(key);
                    aes.IV = Encoding.ASCII.GetBytes(IV);

                    ICryptoTransform encryptor = aes.CreateEncryptor();
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                            {
                                streamWriter.Write(clear_text);
                            }
                            textoEncriptado = memoryStream.ToArray();
                        }
                    }
                    string str = Convert.ToBase64String(textoEncriptado);

                    return str;
                }
            }
            catch (Exception e)
            {
                return "Error al encriptar respuesta. " + e.Message;
            }
        }

        
    }
}
