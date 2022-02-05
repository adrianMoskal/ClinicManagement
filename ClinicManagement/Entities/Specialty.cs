using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Entities
{
    public class Specialty
    {
        public int SpecialtyId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<UserSpecialty> UserSpecialties { get; set; }
    }
}
