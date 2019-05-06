using System;
using tamtambotapi;
using System.Net.Http;
using System.IO;

namespace tamtambottest
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpc = new HttpClient();
            var s = File.ReadAllText("apikey.config");
            tamtamclient cli = new tamtamclient(httpc, s);
            try
            {
                var r = cli.GetMyInfoAsync().Result;
                Console.WriteLine($"Hello from bot {r.Username}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }



    }
}
