  using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{  /// <summary>This is information you will recieve as soon as audio/video is uploaded</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UploadedInfo
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public long Id { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static UploadedInfo FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UploadedInfo>(data);
        }

    }}