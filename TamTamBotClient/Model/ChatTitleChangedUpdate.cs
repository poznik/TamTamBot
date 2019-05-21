 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Bot gets this type of update as soon as title has been changed in chat</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ChatTitleChangedUpdate : Update
    {
        /// <summary>Chat identifier where event has occurred</summary>
        [Newtonsoft.Json.JsonProperty("chat_id", Required = Newtonsoft.Json.Required.Always)]
        public long Chat_id { get; set; }

        /// <summary>User who changed title</summary>
        [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Always)]
        public long User_id { get; set; }

        /// <summary>New title</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Title { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ChatTitleChangedUpdate FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ChatTitleChangedUpdate>(data);
        }

    }}