using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Link : NewMessageLink
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Link FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Link>(data);
        }

    }}