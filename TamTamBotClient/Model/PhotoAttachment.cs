 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Image attachment</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PhotoAttachment : Attachment
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload Payload { get; set; } = new Payload();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PhotoAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhotoAttachment>(data);
        }

    }}