using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Event
    {
        public string EventId { get; }
        public string Publisher { get; }
        public string Payload { get; }
        public int Timestamp { get; }

        public Event(string eventId, string publisher, string payload, int timestamp)
        {
            EventId = eventId;
            Publisher = publisher;
            Payload = payload;
            Timestamp = timestamp;
        }
    }
}
