using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class StickerAttachmentRequestPayload
    {
        /// <summary>Sticker code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Code { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StickerAttachmentRequestPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StickerAttachmentRequestPayload>(data);
        }

    }
}