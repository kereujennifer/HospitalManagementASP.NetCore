using HospitalManagement.Models;
using System.Net;
using HospitalManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.ViewModels
{
    public class PatientViewModel
    {

        public Patients Patient { get; set; }
        public List<MedicalHistory> MedicalHistories { get; set; } = new List<MedicalHistory>();
        public List<Prescription> Prescriptions { get; set; } = new List<Prescription>();
        public List<LabResults> LabResults { get; set; } = new List<LabResults>();
        public List<VitalSigns> VitalSigns { get; set; } = new List<VitalSigns>();


        
}

}
