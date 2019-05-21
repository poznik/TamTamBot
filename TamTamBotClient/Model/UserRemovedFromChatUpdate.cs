 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>You will receive this update when user has been removed from chat where bot is administrator</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UserRemovedFromChatUpdate : Update
    {
        /// <summary>Chat identifier where event has occured</summary>
        [Newtonsoft.Json.JsonProperty("chat_id", Required = Newtonsoft.Json.Required.Always)]
        public long Chat_id { get; set; }

        /// <summary>User removed from chat</summary>
        [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Always)]
        public long User_id { get; set; }

        /// <summary>Administrator who removed user from chat</summary>
        [Newtonsoft.Json.JsonProperty("admin_id", Required = Newtonsoft.Json.Required.Always)]
        public long Admin_id { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static UserRemovedFromChatUpdate FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UserRemovedFromChatUpdate>(data);
        }

    }}