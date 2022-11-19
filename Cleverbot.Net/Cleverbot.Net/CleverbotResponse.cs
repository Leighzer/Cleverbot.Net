using Newtonsoft.Json;
using System.Reflection;

namespace Cleverbot.Net
{   
    public class CleverbotResponse
    {
        [JsonProperty("cs")]
        public string CleverBotState { get; set; }
        public string InteractionCount { get; set; }
        public string Input { get; set; }
        public string InputOther { get; set; }
        public string InputLabel { get; set; }
        public string PredictedInput { get; set; }
        public string Accuracy { get; set; }
        public string OutputLabel { get; set; }
        public string Output { get; set; }
        public string ConversationId { get; set; }
        public string Errorline { get; set; }
        public string DatabaseVersion { get; set; }
        public string SoftwareVersion { get; set; }
        public string TimeTaken { get; set; }
        public string RandomNumber { get; set; }
        public string TimeSecond { get; set; }
        public string TimeMinute { get; set; }
        public string TimeHour { get; set; }
        public string TimeDayOfWeek { get; set; }
        public string TimeDay { get; set; }
        public string TimeMonth { get; set; }
        public string TimeYear { get; set; }
        public string Reaction { get; set; }
        public string ReactionTone { get; set; }
        public string Emotion { get; set; }
        public string EmotionTone { get; set; }
        public string CleverAccuracy { get; set; }
        public string CleverOutput { get; set; }
        public string CleverMatch { get; set; }
        public string CSRES30 { get; set; }
        public string TimeElapsed { get; set; }
        public string FilteredInput { get; set; }
        public string FilteredInputOther { get; set; }
        public string ReactionDegree { get; set; }
        public string EmotionDegree { get; set; }
        public string ReactionValues { get; set; }
        public string EmotionValues { get; set; }
        public string Callback { get; set; }
        public string Interaction1 { get; set; }
        public string Interaction2 { get; set; }
        public string Interaction3 { get; set; }
        public string Interaction4 { get; set; }
        public string Interaction5 { get; set; }
        public string Interaction6 { get; set; }
        public string Interaction7 { get; set; }
        public string Interaction8 { get; set; }
        public string Interaction9 { get; set; }
        public string Interaction10 { get; set; }
        public string Interaction11 { get; set; }
        public string Interaction12 { get; set; }
        public string Interaction13 { get; set; }
        public string Interaction14 { get; set; }
        public string Interaction15 { get; set; }
        public string Interaction16 { get; set; }
        public string Interaction17 { get; set; }
        public string Interaction18 { get; set; }
        public string Interaction19 { get; set; }
        public string Interaction20 { get; set; }
        public string Interaction21 { get; set; }
        public string Interaction22 { get; set; }
        public string Interaction23 { get; set; }
        public string Interaction24 { get; set; }
        public string Interaction25 { get; set; }
        public string Interaction26 { get; set; }
        public string Interaction27 { get; set; }
        public string Interaction28 { get; set; }
        public string Interaction29 { get; set; }
        public string Interaction30 { get; set; }
        public string Interaction31 { get; set; }
        public string Interaction32 { get; set; }
        public string Interaction33 { get; set; }
        public string Interaction34 { get; set; }
        public string Interaction35 { get; set; }
        public string Interaction36 { get; set; }
        public string Interaction37 { get; set; }
        public string Interaction38 { get; set; }
        public string Interaction39 { get; set; }
        public string Interaction40 { get; set; }
        public string Interaction41 { get; set; }
        public string Interaction42 { get; set; }
        public string Interaction43 { get; set; }
        public string Interaction44 { get; set; }
        public string Interaction45 { get; set; }
        public string Interaction46 { get; set; }
        public string Interaction47 { get; set; }
        public string Interaction48 { get; set; }
        public string Interaction49 { get; set; }
        public string Interaction50 { get; set; }

        //public string Interaction1Other { get; set; }

        public List<string> AllInteractions = new List<string>();

        public void CreateInteractionsList()
        {
            foreach (var item in GetType().GetTypeInfo().DeclaredFields)
            {
                if (item.Name.StartsWith("interaction"))
                {
                    if (string.IsNullOrWhiteSpace((string)item.GetValue(this)))
                    {
                        AllInteractions.Add(item.GetValue(this) as string);
                    }
                }
            }
        }
    }
}
