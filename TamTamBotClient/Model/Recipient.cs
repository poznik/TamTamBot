 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>New message recepient. Could be user or chat</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Recipient
    {
        /// <summary>Chat identifier</summary>
        [Newtonsoft.Json.JsonProperty("chat_id", Required = Newtonsoft.Json.Required.Default)]
        public long? Chat_id { get; set; }

        /// <summary>Chat type</summary>
        [Newtonsoft.Json.JsonProperty("chat_type", Required = Newtonsoft.Json.Required.Always)]
        public ChatType Chat_type { get; set; }

        /// <summary>User identifier, if message was sent to user</summary>
        [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Default)]
        public long? User_id { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Recipient FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Recipient>(data);
        }

    }}