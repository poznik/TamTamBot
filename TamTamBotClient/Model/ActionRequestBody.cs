 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ActionRequestBody
    {
        [Newtonsoft.Json.JsonProperty("action", Required = Newtonsoft.Json.Required.Always)]
        public SenderAction Action { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ActionRequestBody FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ActionRequestBody>(data);
        }

    }}