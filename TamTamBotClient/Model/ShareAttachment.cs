 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ShareAttachment : Attachment
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload7 Payload { get; set; } = new Payload7();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ShareAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ShareAttachment>(data);
        }

    }}