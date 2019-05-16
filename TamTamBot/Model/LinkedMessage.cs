using System;
namespace TamTamBot.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class LinkedMessage
    {
        /// <summary>Type of linked message</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageLinkType Type { get; set; }

        /// <summary>User sent this message</summary>
        [Newtonsoft.Json.JsonProperty("sender", Required = Newtonsoft.Json.Required.Always)]
        public User Sender { get; set; }

        /// <summary>Chat where message was originally posted</summary>
        [Newtonsoft.Json.JsonProperty("chat_id", Required = Newtonsoft.Json.Required.Always)]
        public long Chat_id { get; set; }

        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public MessageBody Message { get; set; } = new MessageBody();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static LinkedMessage FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LinkedMessage>(data);
        }

    }
}
