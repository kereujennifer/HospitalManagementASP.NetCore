using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace HospitalManagement.Models
{
    public class Department
    {

        public int DepartmentId { get; set; }


        public string DepartmentName { get; set;}
        public string Description { get; set; }

    }
}
