 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ChatMembersList
    {
        /// <summary>Participants in chat with time of last activity. Visible only for chat admins</summary>
        [Newtonsoft.Json.JsonProperty("members", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<ChatMember> Members { get; set; } = new System.Collections.ObjectModel.Collection<ChatMember>();

        /// <summary>Pointer to the next data page</summary>
        [Newtonsoft.Json.JsonProperty("marker", Required = Newtonsoft.Json.Required.Default)]
        public long? Marker { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ChatMembersList FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ChatMembersList>(data);
        }

    }}