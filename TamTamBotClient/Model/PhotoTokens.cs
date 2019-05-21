 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>This is information you will recieve as soon as an image uploaded</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PhotoTokens
    {
        [Newtonsoft.Json.JsonProperty("photos", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.IDictionary<string, PhotoToken> Photos { get; set; } = new System.Collections.Generic.Dictionary<string, PhotoToken>();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PhotoTokens FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhotoTokens>(data);
        }

    }}