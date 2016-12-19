using System;
using Microsoft.Owin.Hosting;

namespace Rest.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:8000/";

            using (var server = new Server(baseAddress))
            {
                server.Start();
                Console.WriteLine($"Server {baseAddress} runing...");
                Console.ReadLine();
                server.Stop();
            }
        }
    }
}
