using System;
namespace TamTamBot.Model
{
    /// <summary>Object sent to bot when user presses button</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Callback
    {
        /// <summary>Unix-time when user pressed the button</summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public long Timestamp { get; set; }

        /// <summary>Current keyboard identifier</summary>
        [Newtonsoft.Json.JsonProperty("callback_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Callback_id { get; set; }

        /// <summary>Button payload</summary>
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Payload { get; set; }

        /// <summary>User pressed the button</summary>
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Always)]
        public User User { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Callback FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Callback>(data);
        }

    }
}
