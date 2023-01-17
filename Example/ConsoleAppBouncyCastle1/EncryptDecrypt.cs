using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Security.Cryptography;

namespace ConsoleAppBouncyCastle1
{
    public class EncryptDecrypt
    {
        public void EncryptDecryptTextByRsa()
        {
            try
            {
                string plain = "tushar";
                BlockRsaEngine blockRsaEngine = new BlockRsaEngine(Encoding.UTF8);

                //Generate new private/public key.
                //var generatedKeys = blockRsaEngine.GenerateKeys();

                // use existing private/public key.
                AsymmetricKeyParameter publicKey = blockRsaEngine.ReadPublicKey(@"C:\Users\tushar.laxman\Desktop\key\combine.txt");
                AsymmetricKeyParameter privateKey = blockRsaEngine.ReadPrivateKey(@"C:\Users\tushar.laxman\Desktop\key\combine.txt");

                Console.WriteLine("*******************************Encryption******************************");

                var encryptedPlain = blockRsaEngine.Encrypt(plain, publicKey);
                Console.WriteLine($"Encrypted text : {plain} - by publicKey is :");
                Console.WriteLine($"For Hex : {Environment.NewLine}{encryptedPlain.Item2.ToLower()}");
                Console.WriteLine($"For Base64 : {Environment.NewLine}{encryptedPlain.Item1}");

                Console.WriteLine("*******************************Decryption*******************************");

                string decryptedPlain = blockRsaEngine.Decrypt(encryptedPlain.Item1, privateKey).ToLower();
                Console.WriteLine($"Decrypted base64 : {encryptedPlain.Item1}, by privateKey is : {decryptedPlain}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
