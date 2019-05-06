using System;
using Newtonsoft.Json;

namespace tamtambotapi.Classes
{
    public class User
    {
        public long user_id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string avatar_url { get; set; }
        public string full_avatar_url { get; set; }
        public Photo photo { get; set; }

    }
}
