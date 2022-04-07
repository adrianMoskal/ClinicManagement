using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class UserEditRoleViewModel
    {
        public IEnumerable<UserViewModel> Users { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string RoleId { get; set; }

        public SelectList Roles { get; set; }
    }
}
