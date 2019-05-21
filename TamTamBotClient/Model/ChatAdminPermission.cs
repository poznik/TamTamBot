using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{/// <summary>Chat admin permissions</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum ChatAdminPermission
    {
        [System.Runtime.Serialization.EnumMember(Value = @"read_all_messages")]
        Read_all_messages = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"add_remove_members")]
        Add_remove_members = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"add_admins")]
        Add_admins = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"change_chat_info")]
        Change_chat_info = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"pin_message")]
        Pin_message = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"write")]
        Write = 5,

    }
}