using System;
namespace TamTamBot.Model
{
    /// <summary>Image attachment</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PhotoAttachment : Attachment
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload Payload { get; set; } = new Payload();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PhotoAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhotoAttachment>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PhotoAttachmentPayload
    {
        /// <summary>Unique identifier of this image</summary>
        [Newtonsoft.Json.JsonProperty("photo_id", Required = Newtonsoft.Json.Required.Always)]
        public long Photo_id { get; set; }

        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Token { get; set; }

        /// <summary>Image URL</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PhotoAttachmentPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PhotoAttachmentPayload>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class VideoAttachment : Attachment
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload2 Payload { get; set; } = new Payload2();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static VideoAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<VideoAttachment>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AudioAttachment : Attachment
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload3 Payload { get; set; } = new Payload3();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AudioAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AudioAttachment>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class FileAttachment : Attachment
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload4 Payload { get; set; } = new Payload4();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static FileAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FileAttachment>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AttachmentPayload
    {
        /// <summary>Media attachment URL</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AttachmentPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AttachmentPayload>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MediaAttachmentPayload : AttachmentPayload
    {
        /// <summary>Identifier of media attachment</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public long Id { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MediaAttachmentPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MediaAttachmentPayload>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class FileAttachmentPayload : AttachmentPayload
    {
        /// <summary>Identifier of uploaded file</summary>
        [Newtonsoft.Json.JsonProperty("fileId", Required = Newtonsoft.Json.Required.Always)]
        public long FileId { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static FileAttachmentPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FileAttachmentPayload>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
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

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactAttachmentPayload
    {
        /// <summary>User info in VCF format</summary>
        [Newtonsoft.Json.JsonProperty("vcfInfo", Required = Newtonsoft.Json.Required.AllowNull)]
        public string VcfInfo { get; set; }

        /// <summary>User info</summary>
        [Newtonsoft.Json.JsonProperty("tamInfo", Required = Newtonsoft.Json.Required.AllowNull)]
        public User TamInfo { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ContactAttachmentPayload FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ContactAttachmentPayload>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class StickerAttachment : Attachment
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload6 Payload { get; set; } = new Payload6();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StickerAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StickerAttachment>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ShareAttachment : Attachment
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload7 Payload { get; set; } = new Payload7();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ShareAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ShareAttachment>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class LocationAttachment : Attachment
    {
        [Newtonsoft.Json.JsonProperty("latitude", Required = Newtonsoft.Json.Required.Always)]
        public double Latitude { get; set; }

        [Newtonsoft.Json.JsonProperty("longitude", Required = Newtonsoft.Json.Required.Always)]
        public double Longitude { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static LocationAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LocationAttachment>(data);
        }

    }

    /// <summary>Buttons in messages</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class InlineKeyboardAttachment : Attachment
    {
        /// <summary>Unique identifier of keyboard</summary>
        [Newtonsoft.Json.JsonProperty("callback_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Callback_id { get; set; }

        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Payload8 Payload { get; set; } = new Payload8();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static InlineKeyboardAttachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InlineKeyboardAttachment>(data);
        }

    }
}
