using Microsoft.AspNetCore.Mvc.Rendering;

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
