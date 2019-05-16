using System;
namespace TamTamBot.Model
{
    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("callback", typeof(CallbackButton))]
    [JsonInheritanceAttribute("link", typeof(LinkButton))]
    [JsonInheritanceAttribute("request_geo_location", typeof(RequestGeoLocationButton))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Button
    {
        /// <summary>Visible text of button</summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(128)]
        public string Text { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Button FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Button>(data);
        }

    }
}
