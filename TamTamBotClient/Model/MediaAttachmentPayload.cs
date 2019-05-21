 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MediaAttachmentPayload : AttachmentPayload
    {
        /// <summary>Identifier of media attachment</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public long Id { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MediaAttachmentPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MediaAttachmentPayload>(data);
        }

    }
}