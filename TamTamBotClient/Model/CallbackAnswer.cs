 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Send this object when your bot wants to react to when a button is pressed</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CallbackAnswer
    {
        [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long User_id { get; set; }

        /// <summary>Fill this if you want to modify current message</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NewMessageBody Message { get; set; }

        /// <summary>Fill this if you just want to send one-time notification to user</summary>
        [Newtonsoft.Json.JsonProperty("notification", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notification { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static CallbackAnswer FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CallbackAnswer>(data);
        }

    }}