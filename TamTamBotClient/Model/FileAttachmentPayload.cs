  using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{  [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
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

    }}