using System.Text.Json;

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
        private readonly string _cleverbotUrl;
        private string _cleverbotState { get; set; }

        public CleverbotSession(string apiKey, string cleverBotBaseUrl, string cleverBotState)
        {
            _apiKey = apiKey;
            _cleverbotUrl = cleverBotBaseUrl;
            _cleverbotState = cleverBotState;
        }

        public async Task<CleverbotResponse> GetResponseAsync(string message)
        {
            // pass along entire encoded history state to clever bot to pick up convo from
            // if we have it
            string cleverbotState = (string.IsNullOrWhiteSpace(_cleverbotState) ? string.Empty : $"&cs={_cleverbotState}");

            string result = await s_httpClient.GetStringAsync($"{_cleverbotUrl}?key={_apiKey}&input={message}{cleverbotState}").ConfigureAwait(false);
            try
            {
                CleverbotResponse response = JsonSerializer.Deserialize<CleverbotResponse>(result);
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
