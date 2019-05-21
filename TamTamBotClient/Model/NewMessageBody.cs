using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TamTamBot
{[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NewMessageBody
    {
        /// <summary>Message text</summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string Text { get; set; }

        /// <summary>Use `attachments` property instead. Will be removed in the next major release.
        /// 
        /// Single message attachment.</summary>
        [Newtonsoft.Json.JsonProperty("attachment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Attachment2 Attachment { get; set; }

        /// <summary>Message attachments. See `AttachmentRequest` and it's inheritors for full information.</summary>
        [Newtonsoft.Json.JsonProperty("attachments", Required = Newtonsoft.Json.Required.Default)]
        public Collection<AttachmentRequest> Attachments { get; set; }

        /// <summary>Link to Message</summary>
        [Newtonsoft.Json.JsonProperty("link", Required = Newtonsoft.Json.Required.Default)]
        public Link Link { get; set; }

        /// <summary>If false, chat participants wouldn't be notified</summary>
        [Newtonsoft.Json.JsonProperty("notify", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Notify { get; set; } = true;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static NewMessageBody FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<NewMessageBody>(data);
        }

    }}