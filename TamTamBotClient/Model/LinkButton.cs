using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{    /// <summary>After pressing this type of button user follows the link it contains</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class LinkButton : Button
    {
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(256)]
        public string Url { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static LinkButton FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LinkButton>(data);
        }

    }
}