using System;
using tamtambotapi;
using System.Net.Http;
using System.IO;
using System.Threading;

namespace tamtambottest
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpc = new HttpClient();
            string token = File.ReadAllText("token.config");
            TamTamBotClient cli = new TamTamBotClient(token);

            try
            {
                var r = cli.GetMyInfoAsync(CancellationToken.None).Result;
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
