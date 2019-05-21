using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{/// <summary>Schema to describe WebHook subscription</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Subscription
    {
        /// <summary>WebHook URL</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; }

        /// <summary>Unix-time when subscription was created</summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Always)]
        public long Time { get; set; }

        /// <summary>Update types bot subscribed for</summary>
        [Newtonsoft.Json.JsonProperty("update_types", Required = Newtonsoft.Json.Required.Default)]
        public System.Collections.Generic.ICollection<string> Update_types { get; set; }

        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}")]
        public string Version { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Subscription FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Subscription>(data);
        }

    }}