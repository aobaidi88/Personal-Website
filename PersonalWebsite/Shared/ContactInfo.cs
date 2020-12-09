using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalWebsite.Shared
{
   public class ContactInfo
    {
        public string Comments { get; set; }
        public int ContactInfoID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public bool IsPhoneApp { get; set; }
        public bool IsWebApp { get; set; }
        public bool IsWindows { get; set; }
        public string lastName { get; set; }
        public string TypeOfRequest { get; set; }
    }
}
