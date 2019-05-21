 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>You will receive this update when user has been added to chat where bot is administrator</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UserAddedToChatUpdate : Update
    {
        /// <summary>Chat identifier where event has occured</summary>
        [Newtonsoft.Json.JsonProperty("chat_id", Required = Newtonsoft.Json.Required.Always)]
        public long Chat_id { get; set; }

        /// <summary>User added to chat</summary>
        [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Always)]
        public long User_id { get; set; }

        /// <summary>User who added user to chat</summary>
        [Newtonsoft.Json.JsonProperty("inviter_id", Required = Newtonsoft.Json.Required.Always)]
        public long Inviter_id { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static UserAddedToChatUpdate FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UserAddedToChatUpdate>(data);
        }

    }}