 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Request to attach keyboard to message</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InlineKeyboardAttachmentRequest : AttachmentRequest
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload9 Payload { get; set; } = new Payload9();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static InlineKeyboardAttachmentRequest FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InlineKeyboardAttachmentRequest>(data);
        }

    }}