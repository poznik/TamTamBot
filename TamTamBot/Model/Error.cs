using System;
namespace TamTamBot.Model
{
    /// <summary>Server returns this if there was an exception to your request</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Error
    {
        /// <summary>Error</summary>
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Error1 { get; set; }

        /// <summary>Error code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Code { get; set; }

        /// <summary>Human-readable description</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Message { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Error FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(data);
        }

    }
}
