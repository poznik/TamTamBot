using System;
namespace tamtambotapi.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class User
    {
        /// <summary>Users identifier</summary>
        [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Always)]
        public long User_id { get; set; }

        /// <summary>Users visible name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }

        /// <summary>Unique public user name. Can be `null` if user is not accessible or it is not set</summary>
        [Newtonsoft.Json.JsonProperty("username", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Username { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static User FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<User>(data);
        }
    }
}
