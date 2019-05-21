using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{    /// <summary>Generic schema representing message attachment</summary>
    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("image", typeof(PhotoAttachment))]
    [JsonInheritanceAttribute("video", typeof(VideoAttachment))]
    [JsonInheritanceAttribute("audio", typeof(AudioAttachment))]
    [JsonInheritanceAttribute("file", typeof(FileAttachment))]
    [JsonInheritanceAttribute("sticker", typeof(StickerAttachment))]
    [JsonInheritanceAttribute("contact", typeof(ContactAttachment))]
    [JsonInheritanceAttribute("inline_keyboard", typeof(InlineKeyboardAttachment))]
    [JsonInheritanceAttribute("share", typeof(ShareAttachment))]
    [JsonInheritanceAttribute("location", typeof(LocationAttachment))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Attachment
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Attachment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Attachment>(data);
        }

    }}