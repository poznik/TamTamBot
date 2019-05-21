using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TamTamBot
{    /// <summary>Keyboard is two-dimension array of buttons</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Keyboard
    {
        [Newtonsoft.Json.JsonProperty("buttons", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Collection<Collection<Button>> Buttons { get; set; } = 
            new Collection<Collection<Button>>();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Keyboard FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Keyboard>(data);
        }

    }}