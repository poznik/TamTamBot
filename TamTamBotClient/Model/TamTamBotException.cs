using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.3.0.0 (NJsonSchema v9.14.1.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class TamTamBotException<TResult> : TamTamBotException
    {
        public TResult Result { get; private set; }

        public TamTamBotException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }}