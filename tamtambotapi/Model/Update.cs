using System;
using System.Collections.Generic;

namespace tamtambotapi.Classes
{
    public class Sender
    {
        public long user_id { get; set; }
        public string name { get; set; }
    }

    public class Recipient
    {
        public long chat_id { get; set; }
        public string chat_type { get; set; }
        public long user_id { get; set; }
    }

    public class Body
    {
        public string mid { get; set; }
        public long seq { get; set; }
        public string text { get; set; }
    }

    public class Message
    {
        public Sender sender { get; set; }
        public Recipient recipient { get; set; }
        public long timestamp { get; set; }
        public Body body { get; set; }
    }

    public class Update
    {
        public Message message { get; set; }
        public long timestamp { get; set; }
        public string update_type { get; set; }
    }

    public class Updates
    {
        public List<Update> updates { get; set; }
        public int marker { get; set; }
    }
}
