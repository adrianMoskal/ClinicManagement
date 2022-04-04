using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Entities
{
    public class Prescription : BaseEntity
    {
        public string Description { get; set; }
        public bool Used { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string PatientId { get; set; }
        public virtual User Patient { get; set; }
        public string DoctorId { get; set; }
        public virtual User Doctor { get; set; }
        public long MedicineId { get; set; }
        public virtual Medicine Medicine { get; set; }
    }
}
