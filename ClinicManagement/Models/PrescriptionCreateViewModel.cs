using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class PrescriptionCreateViewModel
    {
        public string Description { get; set; }
        public long MedicineId { get; set; }
        public SelectList Medicines { get; set; }

        public string PatientId { get; set; }
        public SelectList Patients { get; set; }
    }
}
