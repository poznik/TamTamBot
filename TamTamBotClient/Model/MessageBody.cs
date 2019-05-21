using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{/// <summary>Schema representing body of message</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MessageBody
    {
        /// <summary>Unique identifier of message</summary>
        [Newtonsoft.Json.JsonProperty("mid", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Mid { get; set; }

        /// <summary>Sequence identifier of message in chat</summary>
        [Newtonsoft.Json.JsonProperty("seq", Required = Newtonsoft.Json.Required.Always)]
        public long Seq { get; set; }

        /// <summary>Message text</summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default)]
        public string Text { get; set; }

        /// <summary>Message attachments. Could be one of `Attachment` type. See description of this schema</summary>
        [Newtonsoft.Json.JsonProperty("attachments", Required = Newtonsoft.Json.Required.Default)]
        public System.Collections.Generic.ICollection<Attachment> Attachments { get; set; }

        /// <summary>In case this message is repled to, it is the unique identifier of the replied message</summary>
        [Newtonsoft.Json.JsonProperty("reply_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reply_to { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MessageBody FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MessageBody>(data);
        }

    }
}