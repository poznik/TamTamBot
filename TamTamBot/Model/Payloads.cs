using System;
namespace TamTamBot.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Payload : PhotoAttachmentPayload
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Payload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Payload>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Payload2 : MediaAttachmentPayload
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Payload2 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Payload2>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Payload3 : MediaAttachmentPayload
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Payload3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Payload3>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
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

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Payload5 : ContactAttachmentPayload
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Payload5 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Payload5>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Payload6 : AttachmentPayload
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Payload6 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Payload6>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Payload7 : AttachmentPayload
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Payload7 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Payload7>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Payload8 : Keyboard
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Payload8 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Payload8>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Payload9 : InlineKeyboardAttachmentRequestPayload
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Payload9 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Payload9>(data);
        }

    }
}
