 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Buttons in messages</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InlineKeyboardAttachment : Attachment
    {
        /// <summary>Unique identifier of keyboard</summary>
        [Newtonsoft.Json.JsonProperty("callback_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Callback_id { get; set; }

        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload8 Payload { get; set; } = new Payload8();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static InlineKeyboardAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InlineKeyboardAttachment>(data);
        }

    }}