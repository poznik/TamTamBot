using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{    /// <summary>You will get this `update` as soon as message is created</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MessageCreatedUpdate : Update
    {
        /// <summary>Newly created message</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        public Message Message { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MessageCreatedUpdate FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MessageCreatedUpdate>(data);
        }

    }}