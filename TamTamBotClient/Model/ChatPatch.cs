using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ChatPatch
    {
        [Newtonsoft.Json.JsonProperty("icon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhotoAttachmentRequestPayload Icon { get; set; }

        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ChatPatch FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ChatPatch>(data);
        }

    }}