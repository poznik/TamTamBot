 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Simple response to request</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SimpleQueryResult
    {
        /// <summary>`true` if request was successful. `false` otherwise</summary>
        [Newtonsoft.Json.JsonProperty("success", Required = Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static SimpleQueryResult FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SimpleQueryResult>(data);
        }

    }
}