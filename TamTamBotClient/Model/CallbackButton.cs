 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>After pressing this type of button client sends to server payload it contains</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CallbackButton : Button
    {
        /// <summary>Button payload</summary>
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(1024)]
        public string Payload { get; set; }

        /// <summary>Intent of button. Affects clients representation.</summary>
        [Newtonsoft.Json.JsonProperty("intent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Intent Intent { get; set; } = Intent.Default;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static CallbackButton FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CallbackButton>(data);
        }

    }}