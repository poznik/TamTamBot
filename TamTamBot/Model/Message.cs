using System;
namespace TamTamBot.Model
{
    /// <summary>Message in chat</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Message
    {
        /// <summary>User that sent this message. Can be `null` if message has been posted on behalf of a channel.</summary>
        [Newtonsoft.Json.JsonProperty("sender", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public User Sender { get; set; }

        /// <summary>Message recipient. Could be user or chat</summary>
        [Newtonsoft.Json.JsonProperty("recipient", Required = Newtonsoft.Json.Required.Always)]
        public Recipient Recipient { get; set; }

        /// <summary>Unix-time when message was created</summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public long Timestamp { get; set; }

        /// <summary>Forwarder or replied message</summary>
        [Newtonsoft.Json.JsonProperty("link", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LinkedMessage Link { get; set; }

        /// <summary>Body of created message. Text + attachments. Could be null if message contains only forwarded message.</summary>
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public MessageBody Body { get; set; } = new MessageBody();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Message FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Message>(data);
        }

    }
}
