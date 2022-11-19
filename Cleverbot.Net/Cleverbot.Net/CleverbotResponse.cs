using Newtonsoft.Json;
using System.Reflection;

namespace Cleverbot.Net
{
    public class CleverbotResponse
    {
        [JsonProperty("cs")]
        public string CleverBotState { get; set; }
        public string InteractionCount { get; set; }
        public string Input { get; set; } // users last message
        public string InputOther { get; set; }
        public string PredictedInput { get; set; }
        public string Accuracy { get; set; }
        public string OutputLabel { get; set; }
        public string Output { get; set; } // response
        public string ConversationId { get; set; }
        public string ErrorLine { get; set; }
        public string DatabaseVersion { get; set; }
        public string SoftwareVersion { get; set; }
        public string TimeTaken { get; set; }
        public string RandomNumber { get; set; }
        public string TimeSecond { get; set; }
        public string TimeMinute { get; set; }
        public string TimeHour { get; set; }
        public string TimeDayOfWeek { get; set; }
        public string TimeDay { get; set; }

        [JsonProperty("time_month")]
        public string timeMonths { get; set; }

        [JsonProperty("time_year")]
        public string timeYears { get; set; }

        // ("reaction")]
        public string reaction { get; set; }

        // ("reaction_tone")]
        public string reactionTone { get; set; }

        // ("emotion")]
        public string emotion { get; set; }

        // ("emotion_tone")]
        public string emotionTone { get; set; }

        // ("clever_accuracy")]
        public string cleverAccuracy { get; set; }

        // ("clever_output")]
        public string cleverOutput { get; set; }

        // ("clever_match")]
        public string cleverMatch { get; set; }

        // ("time_elapsed")]
        public string timeElapsed { get; set; }

        // ("filtered_input")]
        public string filteredInput { get; set; }

        // ("reaction_degree")]
        public string reactionDegree { get; set; }

        // ("emotion_degree")]
        public string emotionDegree { get; set; }

        // ("reaction_values")]
        public string reactionValues { get; set; }

        // ("emotion_values")]
        public string emotionValues { get; set; }

        // ("callback")]
        public string callback { get; set; }

        // TODO: convince Rollo to make these a array/list in json
        // It failed
        // ("interaction_1")]
        public string interaction1 { get; set; }

        // ("interaction_2")]
        public string interaction2 { get; set; }

        // ("interaction_3")]
        public string interaction3 { get; set; }

        // ("interaction_4")]
        public string interaction4 { get; set; }

        // ("interaction_5")]
        public string interaction5 { get; set; }

        // ("interaction_6")]
        public string interaction6 { get; set; }

        // ("interaction_7")]
        public string interaction7 { get; set; }

        // ("interaction_8")]
        public string interaction8 { get; set; }

        // ("interaction_9")]
        public string interaction9 { get; set; }

        // ("interaction_10")]
        public string interaction10 { get; set; }

        // ("interaction_11")]
        public string interaction11 { get; set; }

        // ("interaction_12")]
        public string interaction12 { get; set; }

        // ("interaction_13")]
        public string interaction13 { get; set; }

        // ("interaction_14")]
        public string interaction14 { get; set; }

        // ("interaction_15")]
        public string interaction15 { get; set; }

        // ("interaction_16")]
        public string interaction16 { get; set; }

        // ("interaction_17")]
        public string interaction17 { get; set; }

        // ("interaction_18")]
        public string interaction18 { get; set; }

        // ("interaction_19")]
        public string interaction19 { get; set; }

        // ("interaction_20")]
        public string interaction20 { get; set; }

        // ("interaction_21")]
        public string interaction21 { get; set; }

        // ("interaction_22")]
        public string interaction22 { get; set; }

        // ("interaction_23")]
        public string interaction23 { get; set; }

        // ("interaction_24")]
        public string interaction24 { get; set; }

        // ("interaction_25")]
        public string interaction25 { get; set; }

        // ("interaction_26")]
        public string interaction26 { get; set; }

        // ("interaction_27")]
        public string interaction27 { get; set; }

        // ("interaction_28")]
        public string interaction28 { get; set; }

        // ("interaction_29")]
        public string interaction29 { get; set; }

        // ("interaction_30")]
        public string interaction30 { get; set; }

        // ("interaction_31")]
        public string interaction31 { get; set; }

        // ("interaction_32")]
        public string interaction32 { get; set; }

        // ("interaction_33")]
        public string interaction33 { get; set; }

        // ("interaction_34")]
        public string interaction34 { get; set; }

        // ("interaction_35")]
        public string interaction35 { get; set; }

        // ("interaction_36")]
        public string interaction36 { get; set; }

        // ("interaction_37")]
        public string interaction37 { get; set; }

        // ("interaction_38")]
        public string interaction38 { get; set; }

        // ("interaction_39")]
        public string interaction39 { get; set; }

        // ("interaction_40")]
        public string interaction40 { get; set; }

        // ("interaction_41")]
        public string interaction41 { get; set; }

        // ("interaction_42")]
        public string interaction42 { get; set; }

        // ("interaction_43")]
        public string interaction43 { get; set; }

        // ("interaction_44")]
        public string interaction44 { get; set; }

        // ("interaction_45")]
        public string interaction45 { get; set; }

        // ("interaction_46")]
        public string interaction46 { get; set; }

        // ("interaction_47")]
        public string interaction47 { get; set; }

        // ("interaction_48")]
        public string interaction48 { get; set; }

        // ("interaction_49")]
        public string interaction49 { get; set; }

        // ("interaction_50")]
        public string interaction50 { get; set; }

        // ("interaction_1_other")]

        public string interaction1other;

        public List<string> allInteractions = new List<string>();

        public void CreateInteractionsList()
        {
            foreach (var item in GetType().GetTypeInfo().DeclaredFields)
            {
                if (item.Name.StartsWith("interaction"))
                {
                    if (string.IsNullOrWhiteSpace((string)item.GetValue(this)))
                    {
                        allInteractions.Add(item.GetValue(this) as string);
                    }
                }
            }
        }
    }
}
