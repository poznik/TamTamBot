 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>You will get this `update` as soon as user presses button</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MessageCallbackUpdate : Update
    {
        [Newtonsoft.Json.JsonProperty("callback", Required = Newtonsoft.Json.Required.Always)]
        public Callback Callback { get; set; }

        /// <summary>Original message containing inline keyboard. Can be `null` in case it had been deleted by the moment a bot got this update.</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default)]
        public Message Message { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MessageCallbackUpdate FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MessageCallbackUpdate>(data);
        }

    }}