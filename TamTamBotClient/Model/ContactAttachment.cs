 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactAttachment : Attachment
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload5 Payload { get; set; } = new Payload5();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ContactAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ContactAttachment>(data);
        }

    }}