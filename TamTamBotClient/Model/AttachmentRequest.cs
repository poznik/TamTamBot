using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{    /// <summary>Request to attach some data to message</summary>
    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("attachment", typeof(Attachment2))]
    [JsonInheritanceAttribute("image", typeof(PhotoAttachmentRequest))]
    [JsonInheritanceAttribute("video", typeof(VideoAttachmentRequest))]
    [JsonInheritanceAttribute("audio", typeof(AudioAttachmentRequest))]
    [JsonInheritanceAttribute("file", typeof(FileAttachmentRequest))]
    [JsonInheritanceAttribute("sticker", typeof(StickerAttachmentRequest))]
    [JsonInheritanceAttribute("contact", typeof(ContactAttachmentRequest))]
    [JsonInheritanceAttribute("inline_keyboard", typeof(InlineKeyboardAttachmentRequest))]
    [JsonInheritanceAttribute("location", typeof(LocationAttachmentRequest))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AttachmentRequest
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AttachmentRequest FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AttachmentRequest>(data);
        }

    }}