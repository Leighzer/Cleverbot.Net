using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleverbot.Net
{
    public interface ICleverbotSession
    {
        Task<CleverbotSession> GetResponseAsync(string message);
    }

    public class CleverbotSession
    {
        private static readonly HttpClient s_httpClient = new HttpClient();
        private readonly string _apiKey;
        private string _cleverbotState { get; set; }

        public CleverbotSession(string apiKey, string cleverBotState)
        {
            _apiKey = apiKey;
            _cleverbotState = cleverBotState;
        }

        public async Task<CleverbotResponse?> GetResponseAsync(string message)
        {
            // pass along entire encoded history state to clever bot to pick up convo from
            string cleverbotState = (string.IsNullOrWhiteSpace(_cleverbotState) ? string.Empty : $"&cs={_cleverbotState}");

            string result = await s_httpClient.GetStringAsync($"https://www.cleverbot.com/getreply?key={_apiKey}&input={message}{cleverbotState}").ConfigureAwait(false);
            try
            {
                CleverbotResponse response = JsonConvert.DeserializeObject<CleverbotResponse>(result);
                if (response != null)
                {
                    response.RawResponse = result;
                    response.CreateInteractionsList();
                    _cleverbotState = response.CleverBotState;
                }
                return response;
            }
            catch
            {
                return null;
            }
        }
    }
}
