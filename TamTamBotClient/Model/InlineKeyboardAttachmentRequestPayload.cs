  using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TamTamBot
{  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InlineKeyboardAttachmentRequestPayload
    {
        /// <summary>Two-dimensional array of buttons</summary>
        [Newtonsoft.Json.JsonProperty("buttons", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Collection<Collection<Button>> Buttons { get; set; } = 
            new Collection<Collection<Button>>();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static InlineKeyboardAttachmentRequestPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InlineKeyboardAttachmentRequestPayload>(data);
        }

    }}