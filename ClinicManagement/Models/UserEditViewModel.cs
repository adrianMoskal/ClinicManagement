using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class UserEditViewModel
    {
        [HiddenInput]
        public string UserId { get; set; }

        [Required]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }
    }
}
