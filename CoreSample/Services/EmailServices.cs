using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSample.Services
{
    public class Message
    {
        public string  To { get; set; }
        public string From{ get; set; }
        public string Body { get; set; }
        public List<string> Attachments { get; set; }

    }

    public class EmailServices : IEmailServices
    {
        public void SendEmail(Message message)
        {
            //Logic for sending email
        }

        public void SetConfiguration()
        {
            //setting up email configuration : port details, SMTP settings etc
        }
    }
}
