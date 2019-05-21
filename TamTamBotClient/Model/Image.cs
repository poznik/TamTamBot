using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{/// <summary>Generic schema describing image object</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Image
    {
        /// <summary>URL of image</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Image FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Image>(data);
        }

    }}