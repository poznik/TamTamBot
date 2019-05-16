using System;
namespace TamTamBot.Model
{

        /// <summary>You will get this `update` as soon as user presses button</summary>
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
        public partial class MessageCallbackUpdate : Update
        {
            [Newtonsoft.Json.JsonProperty("callback", Required = Newtonsoft.Json.Required.Always)]
            public Callback Callback { get; set; }

            /// <summary>Original message containing inline keyboard. Can be `null` in case it had been deleted by the moment a bot got this update.</summary>
            [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.AllowNull)]
            public Message Message { get; set; }

            public string ToJson()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }

            public static MessageCallbackUpdate FromJson(string data)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<MessageCallbackUpdate>(data);
            }

        }

        /// <summary>You will get this `update` as soon as message is created</summary>
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
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

        }

        /// <summary>You will get this `update` as soon as message is removed</summary>
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
        public partial class MessageRemovedUpdate : Update
        {
            /// <summary>Identifier of removed message</summary>
            [Newtonsoft.Json.JsonProperty("message_id", Required = Newtonsoft.Json.Required.Always)]
            [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
            public string Message_id { get; set; }

            public string ToJson()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }

            public static MessageRemovedUpdate FromJson(string data)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<MessageRemovedUpdate>(data);
            }

        }

        /// <summary>You will get this `update` as soon as message is edited</summary>
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
        public partial class MessageEditedUpdate : Update
        {
            /// <summary>Edited message</summary>
            [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
            public Message Message { get; set; }

            public string ToJson()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }

            public static MessageEditedUpdate FromJson(string data)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<MessageEditedUpdate>(data);
            }

        }

        /// <summary>You will receive this update when bot has been added to chat</summary>
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
        public partial class BotAddedToChatUpdate : Update
        {
            /// <summary>Chat id where bot was added</summary>
            [Newtonsoft.Json.JsonProperty("chat_id", Required = Newtonsoft.Json.Required.Always)]
            public long Chat_id { get; set; }

            /// <summary>User id who added bot to chat</summary>
            [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Always)]
            public long User_id { get; set; }

            public string ToJson()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }

            public static BotAddedToChatUpdate FromJson(string data)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<BotAddedToChatUpdate>(data);
            }

        }

        /// <summary>You will receive this update when bot has been removed from chat</summary>
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
        public partial class BotRemovedFromChatUpdate : Update
        {
            /// <summary>Chat identifier bot removed from</summary>
            [Newtonsoft.Json.JsonProperty("chat_id", Required = Newtonsoft.Json.Required.Always)]
            public long Chat_id { get; set; }

            /// <summary>User id who removed bot from chat</summary>
            [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Always)]
            public long User_id { get; set; }

            public string ToJson()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }

            public static BotRemovedFromChatUpdate FromJson(string data)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<BotRemovedFromChatUpdate>(data);
            }

        }

        /// <summary>You will receive this update when user has been added to chat where bot is administrator</summary>
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
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

        }

        /// <summary>You will receive this update when user has been removed from chat where bot is administrator</summary>
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
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

        }

        /// <summary>Bot gets this type of update as soon as user pressed `Start` button</summary>
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
        public partial class BotStartedUpdate : Update
        {
            /// <summary>Dialog identifier where event has occurred</summary>
            [Newtonsoft.Json.JsonProperty("chat_id", Required = Newtonsoft.Json.Required.Always)]
            public long Chat_id { get; set; }

            /// <summary>User pressed the 'Start' button</summary>
            [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Always)]
            public long User_id { get; set; }

            public string ToJson()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }

            public static BotStartedUpdate FromJson(string data)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<BotStartedUpdate>(data);
            }

        }

        /// <summary>Bot gets this type of update as soon as title has been changed in chat</summary>
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
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

        }

}
