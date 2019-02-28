using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WGC.Models
{
    public class FeedbackMessage
    {
        [Required(ErrorMessage = "Please state your name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address")]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        public string Subject { get; set; }

        [Required(ErrorMessage = "Please type a message before sending")]
        [Display(Name = "Message")]
        public string Message { get; set; }

        public bool MessageSent { get; set; }
    }
}