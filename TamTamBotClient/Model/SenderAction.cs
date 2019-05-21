 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Different actions to send to chat members</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum SenderAction
    {
        [System.Runtime.Serialization.EnumMember(Value = @"typing_on")]
        Typing_on = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"typing_off")]
        Typing_off = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"sending_photo")]
        Sending_photo = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"sending_video")]
        Sending_video = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"sending_audio")]
        Sending_audio = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"mark_seen")]
        Mark_seen = 5,

    }}