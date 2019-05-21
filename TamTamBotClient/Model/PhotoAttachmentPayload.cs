using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PhotoAttachmentPayload
    {
        /// <summary>Unique identifier of this image</summary>
        [Newtonsoft.Json.JsonProperty("photo_id", Required = Newtonsoft.Json.Required.Always)]
        public long Photo_id { get; set; }

        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Token { get; set; }

        /// <summary>Image URL</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PhotoAttachmentPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhotoAttachmentPayload>(data);
        }

    }}