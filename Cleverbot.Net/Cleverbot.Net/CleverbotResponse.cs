using Newtonsoft.Json;
using System.Reflection;

namespace Cleverbot.Net
{   
    public class CleverbotResponse
    {
        [JsonProperty("cs")]
        public string CleverBotState { get; set; }
        public string Interaction_Count { get; set; }
        public string Input { get; set; }
        public string Input_Other { get; set; }
        public string Input_Label { get; set; }
        public string Predicted_Input { get; set; }
        public string Accuracy { get; set; }
        public string Output_Label { get; set; }
        public string Output { get; set; }
        public string Conversation_Id { get; set; }
        public string Errorline { get; set; }
        public string Database_Version { get; set; }
        public string Software_Version { get; set; }
        public string Time_Taken { get; set; }
        public string Random_Number { get; set; }
        public string Time_Second { get; set; }
        public string Time_Minute { get; set; }
        public string Time_Hour { get; set; }
        public string Time_Day_Of_Week { get; set; }
        public string Time_Day { get; set; }
        public string Time_Month { get; set; }
        public string Time_Year { get; set; }
        public string Reaction { get; set; }
        public string Reaction_Tone { get; set; }
        public string Emotion { get; set; }
        public string Emotion_Tone { get; set; }
        public string Clever_Accuracy { get; set; }
        public string Clever_Output { get; set; }
        public string Clever_Match { get; set; }
        public string CSRES30 { get; set; }
        public string Time_Elapsed { get; set; }
        public string Filtered_Input { get; set; }
        public string Filtered_Input_Other { get; set; }
        public string Reaction_Degree { get; set; }
        public string Emotion_Degree { get; set; }
        public string Reaction_Values { get; set; }
        public string Emotion_Values { get; set; }
        public string Callback { get; set; }
        public string Interaction_1 { get; set; }
        public string Interaction_2 { get; set; }
        public string Interaction_3 { get; set; }
        public string Interaction_4 { get; set; }
        public string Interaction_5 { get; set; }
        public string Interaction_6 { get; set; }
        public string Interaction_7 { get; set; }
        public string Interaction_8 { get; set; }
        public string Interaction_9 { get; set; }
        public string Interaction_10 { get; set; }
        public string Interaction_11 { get; set; }
        public string Interaction_12 { get; set; }
        public string Interaction_13 { get; set; }
        public string Interaction_14 { get; set; }
        public string Interaction_15 { get; set; }
        public string Interaction_16 { get; set; }
        public string Interaction_17 { get; set; }
        public string Interaction_18 { get; set; }
        public string Interaction_19 { get; set; }
        public string Interaction_20 { get; set; }
        public string Interaction_21 { get; set; }
        public string Interaction_22 { get; set; }
        public string Interaction_23 { get; set; }
        public string Interaction_24 { get; set; }
        public string Interaction_25 { get; set; }
        public string Interaction_26 { get; set; }
        public string Interaction_27 { get; set; }
        public string Interaction_28 { get; set; }
        public string Interaction_29 { get; set; }
        public string Interaction_30 { get; set; }
        public string Interaction_31 { get; set; }
        public string Interaction_32 { get; set; }
        public string Interaction_33 { get; set; }
        public string Interaction_34 { get; set; }
        public string Interaction_35 { get; set; }
        public string Interaction_36 { get; set; }
        public string Interaction_37 { get; set; }
        public string Interaction_38 { get; set; }
        public string Interaction_39 { get; set; }
        public string Interaction_40 { get; set; }
        public string Interaction_41 { get; set; }
        public string Interaction_42 { get; set; }
        public string Interaction_43 { get; set; }
        public string Interaction_44 { get; set; }
        public string Interaction_45 { get; set; }
        public string Interaction_46 { get; set; }
        public string Interaction_47 { get; set; }
        public string Interaction_48 { get; set; }
        public string Interaction_49 { get; set; }
        public string Interaction_50 { get; set; }
        public string Interaction_1_Other { get; set; }
        public string Interaction_2_Other { get; set; }
        public string Interaction_3_Other { get; set; }
        public string Interaction_4_Other { get; set; }
        public string Interaction_5_Other { get; set; }
        public string Interaction_6_Other { get; set; }
        public string Interaction_7_Other { get; set; }
        public string Interaction_8_Other { get; set; }
        public string Interaction_9_Other { get; set; }
        public string Interaction_10_Other { get; set; }
        public string Interaction_11_Other { get; set; }
        public string Interaction_12_Other { get; set; }
        public string Interaction_13_Other { get; set; }
        public string Interaction_14_Other { get; set; }
        public string Interaction_15_Other { get; set; }
        public string Interaction_16_Other { get; set; }
        public string Interaction_17_Other { get; set; }
        public string Interaction_18_Other { get; set; }
        public string Interaction_19_Other { get; set; }
        public string Interaction_20_Other { get; set; }
        public string Interaction_21_Other { get; set; }
        public string Interaction_22_Other { get; set; }
        public string Interaction_23_Other { get; set; }
        public string Interaction_24_Other { get; set; }
        public string Interaction_25_Other { get; set; }
        public string Interaction_26_Other { get; set; }
        public string Interaction_27_Other { get; set; }
        public string Interaction_28_Other { get; set; }
        public string Interaction_29_Other { get; set; }
        public string Interaction_30_Other { get; set; }
        public string Interaction_31_Other { get; set; }
        public string Interaction_32_Other { get; set; }
        public string Interaction_33_Other { get; set; }
        public string Interaction_34_Other { get; set; }
        public string Interaction_35_Other { get; set; }
        public string Interaction_36_Other { get; set; }
        public string Interaction_37_Other { get; set; }
        public string Interaction_38_Other { get; set; }
        public string Interaction_39_Other { get; set; }
        public string Interaction_40_Other { get; set; }
        public string Interaction_41_Other { get; set; }
        public string Interaction_42_Other { get; set; }
        public string Interaction_43_Other { get; set; }
        public string Interaction_44_Other { get; set; }
        public string Interaction_45_Other { get; set; }
        public string Interaction_46_Other { get; set; }
        public string Interaction_47_Other { get; set; }
        public string Interaction_48_Other { get; set; }
        public string Interaction_49_Other { get; set; }
        public string Interaction_50_Other { get; set; }

        public List<string> AllInteractions = new List<string>();
        public string RawResponse { get; set; }

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
