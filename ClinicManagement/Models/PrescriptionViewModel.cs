using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class PrescriptionViewModel
    {
        public long PrescriptionId { get; set; }
        public string Description { get; set; }

        [DisplayName("Collected")]
        public bool IsCollected { get; set; }

        [DisplayName("Collected date")]
        public string CollectedDate { get; set; }

        [DisplayName("Expiration date")]
        public string ExpirationDate { get; set; }

        [DisplayName("Issue date")]
        public string CreateDate { get; set; }

        [DisplayName("Doctor")]
        public string DoctorName { get; set; }

        [DisplayName("Patient")]
        public string PatientName { get; set; }

        [DisplayName("Medicine")]
        public string MedicineName { get; set; }

        [DisplayName("Medicine price")]
        public string MedicinePrice { get; set; }
    }
}
