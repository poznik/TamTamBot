 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Payload4 : FileAttachmentPayload
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Payload4 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Payload4>(data);
        }

    }
}