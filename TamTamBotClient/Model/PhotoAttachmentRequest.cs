using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PhotoAttachmentRequest : AttachmentRequest
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        public PhotoAttachmentRequestPayload Payload { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PhotoAttachmentRequest FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhotoAttachmentRequest>(data);
        }

    }}