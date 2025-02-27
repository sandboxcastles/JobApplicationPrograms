using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoverLetterTextMaker.Interfaces
{
    internal class PersonalInformation
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? StateCode { get; set; }
        public string? Zip { get; set; }
        public string? Heading { get; set; }
        public List<string> Paragraphs { get; set; } = new List<string>();
        public string? JobSpecificQualificationsText { get; set;  }
        public string? SignOff { get; set;  }
        public List<List<string>>? Socials { get; set; }
    }
}
