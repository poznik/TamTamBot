using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BotPatch
    {
        /// <summary>Visible name of bot</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(64, MinimumLength = 1)]
        public string Name { get; set; }

        /// <summary>Bot unique identifier. It can be any string 4-64 characters long containing any digit, letter or special symbols: "-" or "_". It **must** starts with a letter</summary>
        [Newtonsoft.Json.JsonProperty("username", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(64, MinimumLength = 4)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[a-z]+[a-z0-9-_]*")]
        public string Username { get; set; }

        /// <summary>Bot description up to 16k characters long</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(16000, MinimumLength = 1)]
        public string Description { get; set; }

        /// <summary>Commands supported by bot. Pass empty list if you want to remove commands</summary>
        [Newtonsoft.Json.JsonProperty("commands", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(32)]
        public System.Collections.Generic.ICollection<BotCommand> Commands { get; set; }

        /// <summary>Request to set bot photo</summary>
        [Newtonsoft.Json.JsonProperty("photo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhotoAttachmentRequestPayload Photo { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static BotPatch FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BotPatch>(data);
        }

    }}