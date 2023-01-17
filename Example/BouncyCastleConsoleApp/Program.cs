using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncyCastleConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Class1 obj = new Class1();
            obj.EncryptDecryptTextByRsa();
           
            Console.ReadKey();
        }
    }
}
    