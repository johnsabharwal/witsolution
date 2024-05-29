using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SendGridSettings
    {
        public string ApiUrl { get; set; }
        public string ApiKey { get; set; }


        public string EmailAddress { get; set; }


        public string EmailName { get; set; }
        public string adminEmail { get; set; }

    }
}
