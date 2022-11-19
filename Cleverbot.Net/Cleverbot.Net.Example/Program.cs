using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Text;

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

            var apiKey = configuration.GetValue<string>("API_KEY");

            CleverbotSession cleverbotSession = new CleverbotSession(apiKey, string.Empty);

            Console.WriteLine("Hello in the Cleverbot.Net test app, please type your message.\n");

            string? msg;
            CleverbotResponse response;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                msg = Console.ReadLine();
                Console.Write("...");
                response = await cleverbotSession.GetResponseAsync(msg);                
                Console.CursorLeft = 0;
                Console.WriteLine(response.Output);
                Console.WriteLine(response.RawResponse);
                Console.WriteLine(response.Interaction_1);
                Console.WriteLine(response.Interaction_1_Other);
                Console.WriteLine(response.Interaction_Count);
            }
        }
    }
}