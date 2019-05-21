using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactAttachmentRequestPayload
    {
        /// <summary>Contact name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }

        /// <summary>Contact identifier</summary>
        [Newtonsoft.Json.JsonProperty("contactId", Required = Newtonsoft.Json.Required.Default)]
        public long? ContactId { get; set; }

        /// <summary>Full information about contact in VCF format</summary>
        [Newtonsoft.Json.JsonProperty("vcfInfo", Required = Newtonsoft.Json.Required.Default)]
        public string VcfInfo { get; set; }

        /// <summary>Contact phone in VCF format</summary>
        [Newtonsoft.Json.JsonProperty("vcfPhone", Required = Newtonsoft.Json.Required.Default)]
        public string VcfPhone { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ContactAttachmentRequestPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ContactAttachmentRequestPayload>(data);
        }

    }}