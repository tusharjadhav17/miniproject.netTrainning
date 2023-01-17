// See https://aka.ms/new-console-template for more information
using ConsoleAppSSH;

Console.WriteLine("Hello, World!");



List<string> usernames = System.IO.File.ReadAllLines(@"D:\WorkSpace\Tushar\.NET\Example\ConsoleAppSSH\UserName.txt").ToList();

Parallel.ForEach(usernames, user =>
{
    Console.WriteLine("Connecting to " + user);
    SFTP_Connect obj = new SFTP_Connect();
    obj.sftpconnection(user);
});
