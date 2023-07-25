using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HospitalManagement.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string? Notes { get; set; }

        public string? MedicinePrescription { get; set; }
        public DateTime? DateDispensed { get; set; }
        [Display(Name = " DoctorsName")]
        public int DoctorsId { get; set; }
        public Doctors? Doctors { get; set; }
       public int PatientId { get; set; } // Foreign key
        public Patients? Patient { get; set; }
    }
}
