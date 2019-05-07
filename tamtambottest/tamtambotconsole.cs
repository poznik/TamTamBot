using System;
using System.Net.Http;
using System.IO;
using System.Threading;
using TamTamBot; 


namespace tamtambottest
{
    class Program
    {
        static void Main(string[] args)
        {
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
