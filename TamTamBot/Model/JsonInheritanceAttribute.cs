using System;
namespace TamTamBot.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    internal class JsonInheritanceAttribute : System.Attribute
    {
        public JsonInheritanceAttribute(string key, System.Type type)
        {
            Key = key;
            Type = type;
        }

        public string Key { get; }

        public System.Type Type { get; }
    }
}
