  using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{  /// <summary>Request to attach contact card to message. MUST be the only attachment in message</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactAttachmentRequest : AttachmentRequest
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        public ContactAttachmentRequestPayload Payload { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ContactAttachmentRequest FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ContactAttachmentRequest>(data);
        }

    }}