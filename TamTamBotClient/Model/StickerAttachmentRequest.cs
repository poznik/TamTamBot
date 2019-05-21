 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Request to attach sticker. MUST be the only attachment request in message</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class StickerAttachmentRequest : AttachmentRequest
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        public StickerAttachmentRequestPayload Payload { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StickerAttachmentRequest FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StickerAttachmentRequest>(data);
        }

    }}