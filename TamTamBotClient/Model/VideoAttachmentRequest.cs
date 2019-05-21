  using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{  /// <summary>Request to attach video to message</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class VideoAttachmentRequest : AttachmentRequest
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        public UploadedInfo Payload { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static VideoAttachmentRequest FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<VideoAttachmentRequest>(data);
        }

    }}