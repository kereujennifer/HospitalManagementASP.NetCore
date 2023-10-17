using HospitalManagement.Models;

namespace HospitalManagement.ViewModels
{
    public class IndexLabViewModel { 
     public List<Laboratory> Laboratories { get; set; }
    public List<LabRequest> LabRequests { get; set; }
    public List<LabTestCategory> LabTestCategories { get; set; }
    public List<LabTest> LabTest { get; set; }


    }
}
