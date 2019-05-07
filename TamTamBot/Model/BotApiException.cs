using System;
namespace TamTamBot.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.2.5.0 (NJsonSchema v9.13.37.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class BotApiException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public BotApiException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.2.5.0 (NJsonSchema v9.13.37.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class BotApiException<TResult> : BotApiException
    {
        public TResult Result { get; private set; }

        public BotApiException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

}
