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
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");


            EncryptDecrypt obj = new EncryptDecrypt();
            obj.EncryptDecryptTextByRsa();

          
        }
    }
}
