using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BotInfo : UserWithPhoto
    {
        /// <summary>Commands supported by bot</summary>
        [Newtonsoft.Json.JsonProperty("commands", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(32)]
        public System.Collections.Generic.ICollection<BotCommand> Commands { get; set; }

        /// <summary>Bot description</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(16000)]
        public string Description { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static BotInfo FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BotInfo>(data);
        }

    }}