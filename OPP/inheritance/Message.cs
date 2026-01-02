using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPP.Inheritance
{
    public class Message
    {
        public string? Sender { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class EmailMessage : Message
    {
        public string? Subject { get; set; } // Emails have subjects, SMS don't
    }

    public class SmsMessage : Message
    {
        public string? PhoneNumber { get; set; }
    }
}