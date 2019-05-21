 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Bot gets this type of update as soon as user pressed `Start` button</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BotStartedUpdate : Update
    {
        /// <summary>Dialog identifier where event has occurred</summary>
        [Newtonsoft.Json.JsonProperty("chat_id", Required = Newtonsoft.Json.Required.Always)]
        public long Chat_id { get; set; }

        /// <summary>User pressed the 'Start' button</summary>
        [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Always)]
        public long User_id { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static BotStartedUpdate FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BotStartedUpdate>(data);
        }

    }}