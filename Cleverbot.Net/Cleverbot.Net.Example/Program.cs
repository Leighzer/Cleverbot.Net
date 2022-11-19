using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;


namespace Cleverbot.Net.Example
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                                                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                                .AddCommandLine(args)
                                                .Build();

            CleverbotSession cleverbotSession = new CleverbotSession("api_key_here", string.Empty);

            Console.WriteLine("Hello in the Cleverbot.Net test app, please type your message.\n");

            string msg;
            CleverbotResponse r;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                msg = Console.ReadLine();
                Console.Write("...");
                r = await cleverbotSession.GetResponseAsync(msg);                
                Console.CursorLeft = 0;
                Console.WriteLine(cleverbotSession.LastRawResponse);
                Console.WriteLine(r.Response);
            }
        }
    }
}