using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ChatMember : UserWithPhoto
    {
        [Newtonsoft.Json.JsonProperty("last_access_time", Required = Newtonsoft.Json.Required.Always)]
        public long Last_access_time { get; set; }

        [Newtonsoft.Json.JsonProperty("is_owner", Required = Newtonsoft.Json.Required.Always)]
        public bool Is_owner { get; set; }

        [Newtonsoft.Json.JsonProperty("is_admin", Required = Newtonsoft.Json.Required.Always)]
        public bool Is_admin { get; set; }

        [Newtonsoft.Json.JsonProperty("join_time", Required = Newtonsoft.Json.Required.Always)]
        public long Join_time { get; set; }

        /// <summary>Permissions in chat if member is admin. `null` otherwise</summary>
        [Newtonsoft.Json.JsonProperty("permissions", Required = Newtonsoft.Json.Required.Default, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.Generic.ICollection<ChatAdminPermission> Permissions { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ChatMember FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ChatMember>(data);
        }

    }
}