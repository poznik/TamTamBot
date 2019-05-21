using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{    /// <summary>List of all WebHook subscriptions</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetSubscriptionsResult
    {
        /// <summary>Current suscriptions</summary>
        [Newtonsoft.Json.JsonProperty("subscriptions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Subscription> Subscriptions { get; set; } = new System.Collections.ObjectModel.Collection<Subscription>();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static GetSubscriptionsResult FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetSubscriptionsResult>(data);
        }

    }}