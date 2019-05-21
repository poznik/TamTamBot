 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UserIdsList
    {
        [Newtonsoft.Json.JsonProperty("user_ids", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public object User_ids { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static UserIdsList FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UserIdsList>(data);
        }

    }}