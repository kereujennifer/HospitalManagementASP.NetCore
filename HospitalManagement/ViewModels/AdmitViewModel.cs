using HospitalManagement.Models;

namespace HospitalManagement.ViewModels
{
    public class AdmitViewModel
    {
       
            public int PatientId { get; set; }
        public List<HospitalMngt> Wards { get; set; }
        public List<HospitalMngt> Rooms { get; set; }
        public int SelectedWardId { get; set; }
         public int SelectedRoomId { get; set; }

        // Add any additional fields you need for ward and room selection (e.g., WardId, RoomId, etc.)
        // For example:
        // public int SelectedWardId { get; set; }
        // public int SelectedRoomId { get; set; }

    }


}
