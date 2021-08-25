using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentLibrary
{
    public class Student
    {
        [Key]
        public string BcitId { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "First Name format not valid")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Last Name format not valid")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$", ErrorMessage = "Phone number format not valid")]
        public string MobileNumber { get; set; }
        //[Required]
        //[RegularExpression(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))| [-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*) (?<=[0-9a-zA-Z])@)) (?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])| (([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$", ErrorMessage = "Email entered not valid")]
        public string EmailAddress { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "City format not valid")]
        public string City { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Speicialization format not valid")]
        public string Specialization { get; set; }
    }
}
