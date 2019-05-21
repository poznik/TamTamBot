 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Endpoint you should upload to your binaries</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UploadEndpoint
    {
        /// <summary>URL to upload</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static UploadEndpoint FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UploadEndpoint>(data);
        }

    }}