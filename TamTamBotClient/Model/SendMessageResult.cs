using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SendMessageResult
    {
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        public Message Message { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static SendMessageResult FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SendMessageResult>(data);
        }

    }}