 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Request to set up WebHook subscription</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SubscriptionRequestBody
    {
        /// <summary>URL of HTTP(S)-endpoint of your bot</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; }

        /// <summary>List of update types your bot want to receive. See `Update` object for a complete list of types</summary>
        [Newtonsoft.Json.JsonProperty("update_types", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Update_types { get; set; }

        /// <summary>Version of API. Affects model representation</summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static SubscriptionRequestBody FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SubscriptionRequestBody>(data);
        }

    }}