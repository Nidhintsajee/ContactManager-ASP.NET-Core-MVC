using System;
using System.ComponentModel.DataAnnotations;

namespace MvcContact.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public double PhoneNumber { get; set; }
        public int AddressID { get; set; } 
        public Address Address { get; set; }
    }
}