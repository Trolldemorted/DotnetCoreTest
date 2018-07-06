using System;
using System.Net;
using System.Net.Security;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace DotnetCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Init = Task.Run(async () =>
            {
                await Task.Delay(1000);
            });
            var TaskB = Task.Run(async () =>
            {
                await Init;
                Console.WriteLine("B finished waiting");
                await Task.Delay(5000);
            });
            var TaskC = Task.Run(async () =>
            {
                await Init;
                Console.WriteLine("C finished waiting");
                while (true) { }
            });
            Console.ReadKey();            
        }
    }
}
