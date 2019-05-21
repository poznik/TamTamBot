  using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PhotoToken
    {
        /// <summary>Encoded information of uploaded image</summary>
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Token { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PhotoToken FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhotoToken>(data);
        }

    }
}