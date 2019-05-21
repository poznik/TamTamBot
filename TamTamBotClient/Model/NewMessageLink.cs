  using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NewMessageLink
    {
        /// <summary>Type of message link</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageLinkType Type { get; set; }

        /// <summary>Message identifier of original message</summary>
        [Newtonsoft.Json.JsonProperty("mid", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Mid { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static NewMessageLink FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<NewMessageLink>(data);
        }

    }}