using System;
namespace TamTamBot.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InlineKeyboardAttachmentRequestPayload
    {
        /// <summary>Two-dimensional array of buttons</summary>
        [Newtonsoft.Json.JsonProperty("buttons", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<System.Collections.Generic.ICollection<Button>> Buttons { get; set; } = (System.Collections.Generic.ICollection<System.Collections.Generic.ICollection<TamTamBot.Model.Button>>)(System.Collections.Generic.ICollection<System.Collections.Generic.ICollection<Button>>)new System.Collections.ObjectModel.Collection<System.Collections.ObjectModel.Collection<Button>>();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static InlineKeyboardAttachmentRequestPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InlineKeyboardAttachmentRequestPayload>(data);
        }

    }
}
