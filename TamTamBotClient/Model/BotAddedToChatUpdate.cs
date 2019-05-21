 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>You will receive this update when bot has been added to chat</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BotAddedToChatUpdate : Update
    {
        /// <summary>Chat id where bot was added</summary>
        [Newtonsoft.Json.JsonProperty("chat_id", Required = Newtonsoft.Json.Required.Always)]
        public long Chat_id { get; set; }

        /// <summary>User id who added bot to chat</summary>
        [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Always)]
        public long User_id { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static BotAddedToChatUpdate FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BotAddedToChatUpdate>(data);
        }

    }}