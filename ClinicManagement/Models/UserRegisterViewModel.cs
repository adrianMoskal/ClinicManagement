using System.ComponentModel;

namespace ClinicManagement.Models
{
    public class UserRegisterViewModel
    {
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Username")]
        public string UserName { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
