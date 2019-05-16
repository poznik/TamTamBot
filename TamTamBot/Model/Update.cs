using System;
namespace TamTamBot.Model
{
    /// <summary>`Update` object repsesents different types of events that happened in chat. See its inheritors</summary>
    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "update_type")]
    [JsonInheritanceAttribute("message_created", typeof(MessageCreatedUpdate))]
    [JsonInheritanceAttribute("message_callback", typeof(MessageCallbackUpdate))]
    [JsonInheritanceAttribute("message_edited", typeof(MessageEditedUpdate))]
    [JsonInheritanceAttribute("message_removed", typeof(MessageRemovedUpdate))]
    [JsonInheritanceAttribute("bot_added", typeof(BotAddedToChatUpdate))]
    [JsonInheritanceAttribute("bot_removed", typeof(BotRemovedFromChatUpdate))]
    [JsonInheritanceAttribute("user_added", typeof(UserAddedToChatUpdate))]
    [JsonInheritanceAttribute("user_removed", typeof(UserRemovedFromChatUpdate))]
    [JsonInheritanceAttribute("bot_started", typeof(BotStartedUpdate))]
    [JsonInheritanceAttribute("chat_title_changed", typeof(ChatTitleChangedUpdate))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Update
    {
        /// <summary>Unix-time when event has occured</summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public long Timestamp { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Update FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Update>(data);
        }

    }
}
