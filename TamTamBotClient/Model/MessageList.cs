 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Paginated list of messages</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MessageList
    {
        /// <summary>List of messages</summary>
        [Newtonsoft.Json.JsonProperty("messages", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Message> Messages { get; set; } = new System.Collections.ObjectModel.Collection<Message>();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MessageList FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MessageList>(data);
        }

    }}