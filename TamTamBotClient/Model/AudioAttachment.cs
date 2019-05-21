using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{ [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AudioAttachment : Attachment
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload3 Payload { get; set; } = new Payload3();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AudioAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AudioAttachment>(data);
        }

    }}