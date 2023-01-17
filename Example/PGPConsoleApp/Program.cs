// See https://aka.ms/new-console-template for more information
using Org.BouncyCastle.Crypto.Modes;
using PGPConsoleApp;

Console.WriteLine("Hello, World!");


Pgp.EncryptFile(@"D:\WorkSpace\Data\Outputs\output.txt", @"D:\WorkSpace\Data\Outputs\input.txt", @"D:\WorkSpace\Data\Pgpkey\publickey.asc", true, true);

Pgp.DecryptFile(@"D:\WorkSpace\Data\Outputs\output.txt", @"D:\WorkSpace\Data\Pgpkey\privatekey.asc", "password".ToCharArray(), @"D:\WorkSpace\Data\Outputs\defalut.txt");