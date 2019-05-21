 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>List of all updates in chats your bot participated in</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UpdateList
    {
        /// <summary>Page of updates</summary>
        [Newtonsoft.Json.JsonProperty("updates", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Update> Updates { get; set; } = new System.Collections.ObjectModel.Collection<Update>();

        /// <summary>Pointer to the next data page</summary>
        [Newtonsoft.Json.JsonProperty("marker", Required = Newtonsoft.Json.Required.Default)]
        public long? Marker { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static UpdateList FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateList>(data);
        }

    }}