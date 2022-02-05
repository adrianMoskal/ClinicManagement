using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Entities
{
    public class UserSpecialty
    {
        public string UserId { get; set; }
        public virtual User Doctor { get; set; }

        public int SpecialtyId { get; set; }
        public virtual Specialty Specialty { get; set; }
    }
}
