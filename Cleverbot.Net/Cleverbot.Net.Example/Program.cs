using Microsoft.Extensions.Configuration;

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
            var cleverbotUrl = configuration.GetValue<string>("CleverbotUrl");

            CleverbotSession cleverbotSession = new CleverbotSession(apiKey, cleverbotUrl, string.Empty);

            Console.WriteLine("Hello welcome in the Cleverbot.Net test app, please type your message.\n");

            string? msg;
            CleverbotResponse cleverbotResponse;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                msg = Console.ReadLine();
                Console.Write("...");
                cleverbotResponse = await cleverbotSession.GetResponseAsync(msg);                
                Console.CursorLeft = 0;
                Console.WriteLine(cleverbotResponse.Output);
                Console.WriteLine(cleverbotResponse.RawResponse);
            }
        }
    }
}