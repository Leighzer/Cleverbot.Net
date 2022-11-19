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
        private string _conversationId { get; set; }
        private string _cleverbotState { get; set; }
        


        public CleverbotSession(string apiKey, string cleverBotState)
        {
            _apiKey = apiKey;
            _cleverbotState = cleverBotState;
        }

        public async Task<CleverbotResponse> GetResponseAsync(string message)
        {
            string conversationLine = (string.IsNullOrWhiteSpace(_cleverbotState) ? "" : $"&cs={_cleverbotState}");

            string result = await s_httpClient.GetStringAsync($"https://www.cleverbot.com/getreply?key={_apiKey}&input={message}{conversationLine}").ConfigureAwait(false);
            try
            {
                CleverbotResponse response = JsonConvert.DeserializeObject<CleverbotResponse>(result);
                response.RawResponse = result;
                response.CreateInteractionsList();

                _conversationId = response.Conversation_Id;
                _cleverbotState = response.CleverBotState;
                return response;
            }
            catch
            {
                return null;
            }
        }
    }
}
