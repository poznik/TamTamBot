using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Chat
    {
        /// <summary>Chats identifier</summary>
        [Newtonsoft.Json.JsonProperty("chat_id", Required = Newtonsoft.Json.Required.Always)]
        public long Chat_id { get; set; }

        /// <summary>Type of chat. One of: dialog, chat, channel</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        public ChatType Type { get; set; }

        /// <summary>Chat status. One of:
        ///  - active: bot is active member of chat
        ///  - removed: bot was kicked
        ///  - left: bot intentionally left chat
        ///  - closed: chat was closed</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        public ChatStatus Status { get; set; }

        /// <summary>Visible title of chat. Can be null for dialogs</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }

        /// <summary>Icon of chat</summary>
        [Newtonsoft.Json.JsonProperty("icon", Required = Newtonsoft.Json.Required.Default)]
        public Image Icon { get; set; }

        /// <summary>Time of last event occured in chat</summary>
        [Newtonsoft.Json.JsonProperty("last_event_time", Required = Newtonsoft.Json.Required.Always)]
        public long Last_event_time { get; set; }

        /// <summary>Number of people in chat. Always 2 for `dialog` chat type</summary>
        [Newtonsoft.Json.JsonProperty("participants_count", Required = Newtonsoft.Json.Required.Always)]
        public int Participants_count { get; set; }

        /// <summary>Identifier of chat owner. Visible only for chat admins</summary>
        [Newtonsoft.Json.JsonProperty("owner_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Owner_id { get; set; }

        /// <summary>Participants in chat with time of last activity. Can be *null* when you request list of chats. Visible for chat admins only</summary>
        [Newtonsoft.Json.JsonProperty("participants", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long> Participants { get; set; }

        /// <summary>Is current chat publicly available. Always `false` for dialogs</summary>
        [Newtonsoft.Json.JsonProperty("is_public", Required = Newtonsoft.Json.Required.Always)]
        public bool Is_public { get; set; }

        /// <summary>Link on chat if it is public</summary>
        [Newtonsoft.Json.JsonProperty("link", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>Chat description</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default)]
        public object Description { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Chat FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Chat>(data);
        }

    }}