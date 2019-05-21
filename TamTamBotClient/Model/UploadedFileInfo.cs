 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>This is information you will recieve as soon as a file is uploaded</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UploadedFileInfo
    {
        /// <summary>Unique file identifier</summary>
        [Newtonsoft.Json.JsonProperty("fileId", Required = Newtonsoft.Json.Required.Always)]
        public long FileId { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static UploadedFileInfo FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UploadedFileInfo>(data);
        }

    }}