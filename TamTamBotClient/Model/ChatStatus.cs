using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{/// <summary>Chat status for current bot</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum ChatStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"active")]
        Active = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"removed")]
        Removed = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"left")]
        Left = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"closed")]
        Closed = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"suspended")]
        Suspended = 4,

    }}