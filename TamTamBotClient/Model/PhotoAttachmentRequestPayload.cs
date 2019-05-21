 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{       /// <summary>Request to attach image. All fields are mutually exclusive.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
	public partial class PhotoAttachmentRequestPayload
    {
        /// <summary>Any external image URL you want to attach</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>Token of any existing attachment</summary>
        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>Tokens were obtained after uploading images</summary>
        [Newtonsoft.Json.JsonProperty("photos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, PhotoToken> Photos { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PhotoAttachmentRequestPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhotoAttachmentRequestPayload>(data);
        }

    }
}