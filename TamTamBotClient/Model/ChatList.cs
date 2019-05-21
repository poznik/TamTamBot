using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ChatList
    {
        /// <summary>List of requested chats</summary>
        [Newtonsoft.Json.JsonProperty("chats", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Chat> Chats { get; set; } = new System.Collections.ObjectModel.Collection<Chat>();

        /// <summary>Reference to the next page of requested chats</summary>
        [Newtonsoft.Json.JsonProperty("marker", Required = Newtonsoft.Json.Required.Default)]
        public long? Marker { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ChatList FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ChatList>(data);
        }

    }}