using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ClinicManagement.Models
{
    public class UserViewModel
    {
        [HiddenInput]
        public string UserId { get; set; }

        public string UserName { get; set; }

        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("Role")]
        public string Role { get; set; }

        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }
    }
}
