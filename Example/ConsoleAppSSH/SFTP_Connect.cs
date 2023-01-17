using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSSH
{
    internal class SFTP_Connect
    {
        public void sftpconnection(string UserName)
        {
            var host = "20.219.125.123";
            var port = 22022;
            var username = UserName;
            var passphrase = "client";
            var privateKeyLocalFilePath = @"C:\Users\tushar.laxman\Downloads\privatekeySSH";

            var remoteFolderPath = "/";
            //var localFolderPath = @"";
            
            var key = File.ReadAllText(privateKeyLocalFilePath);
            var buf = new MemoryStream(Encoding.UTF8.GetBytes(key));
            var privateKeyFile = new PrivateKeyFile(buf, passphrase);
            
            var connectionInfo = new ConnectionInfo(host, port, UserName,
                new PrivateKeyAuthenticationMethod(username, privateKeyFile));

           /* Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<int> integerList = Enumerable.Range(1, 10).ToList();*/

            using (var client = new SftpClient(connectionInfo))
            {
                try
                {
                    client.Connect();

                    var files = client.ListDirectory(remoteFolderPath);
                    foreach (var file in files)
                    {
                       /* var localFolferPath = Path.Combine(@"D:\WorkSpace\Data", UserName);

                        if (!Directory.Exists(localFolferPath))
                            Directory.CreateDirectory(localFolferPath);*/

                        Console.WriteLine(file.FullName + " ");
                        /*if (file.Name != "." && file.Name != "..")
                        {
                            using (var targetFile = new FileStream(Path.Combine(localFolferPath, file.Name), FileMode.Create))
                            {
                                client.DownloadFile(file.FullName, targetFile);
                                targetFile.Close();
                            }
                        }*/
                    }
                    
                }
                catch(Exception ex)
                {
                   Console.WriteLine("{0} --Error --{1}", username, ex.Message);

                }
                finally
                {
                    client.Disconnect();
                    Console.WriteLine("{0} --Disconnected To Server...{1}", DateTime.Now, username);
                   
                }
               
            }
        }
    }
}


















/*client.Connect();
                    var files = client.ListDirectory(remoteFolderPath);
                    *//*foreach (var file in files)
                    {
                        Console.WriteLine(file.FullName);
                    }*//*
                    Parallel.ForEach(files, file =>
                    {
                        Console.WriteLine(file.FullName);
                    });*/
