 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>After pressing this type of button client sends new message with attachment of current user geo location</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RequestGeoLocationButton : Button
    {
        /// <summary>If *true*, sends location without asking user's confirmation</summary>
        [Newtonsoft.Json.JsonProperty("quick", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Quick { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RequestGeoLocationButton FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RequestGeoLocationButton>(data);
        }

    }}