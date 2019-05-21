 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Message statistics</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MessageStat
    {
        [Newtonsoft.Json.JsonProperty("views", Required = Newtonsoft.Json.Required.Always)]
        public int Views { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MessageStat FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MessageStat>(data);
        }

    }}