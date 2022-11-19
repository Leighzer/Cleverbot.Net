using Newtonsoft.Json;
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
        public string ConversationId { get; set; }
        public string CleverbotState { get; set; }
        public string LastRawResponse { get; set; }


        public CleverbotSession(string apiKey, string cleverBotState)
        {
            _apiKey = apiKey;
            CleverbotState = cleverBotState;
        }

        public async Task<CleverbotResponse> GetResponseAsync(string message)
        {
            string conversationLine = (string.IsNullOrWhiteSpace(CleverbotState) ? "" : $"&cs={CleverbotState}");

            string result = await s_httpClient.GetStringAsync($"https://www.cleverbot.com/getreply?key={_apiKey}&input={message}{conversationLine}").ConfigureAwait(false);
            LastRawResponse = result;
            CleverbotResponse response = JsonConvert.DeserializeObject<CleverbotResponse>(result);
            ConversationId = response.ConversationId;
            CleverbotState = response.cleverBotState;
            if (response == null)
            {
                return null;
            }
            response.CreateInteractionsList();

            return response;
        }
    }
}
