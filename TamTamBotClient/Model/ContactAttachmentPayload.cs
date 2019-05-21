 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactAttachmentPayload
    {
        /// <summary>User info in VCF format</summary>
        [Newtonsoft.Json.JsonProperty("vcfInfo", Required = Newtonsoft.Json.Required.Default)]
        public string VcfInfo { get; set; }

        /// <summary>User info</summary>
        [Newtonsoft.Json.JsonProperty("tamInfo", Required = Newtonsoft.Json.Required.Default)]
        public User TamInfo { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ContactAttachmentPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ContactAttachmentPayload>(data);
        }

    }}