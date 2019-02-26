using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WGC.Models
{
    public class FeedbackMessage
    {
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
}