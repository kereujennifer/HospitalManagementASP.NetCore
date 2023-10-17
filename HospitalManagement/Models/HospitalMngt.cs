using Microsoft.AspNetCore.Identity;

namespace HospitalManagement.Models
{
    public class HospitalMngt 
    {
        public int Id { get; set; }
        public string? Wards { get; set; }
        public string? Beds { get; set; }
        public string? WardCategory { get; set; }
        public string? Floors { get; set; }
        public bool IsOccupied { get; set; }

        
        public string? Stations { get; set; }

            public string RoomName { get; set; }
            public int RoomTypeId { get; set; }
            public string RoomType { get; set; }
            // Add any other properties as needed
        

       
            public int WardId { get; set; }
            public string WardName { get; set; }
            // Add any other properties as needed
        

       
            public int BedId { get; set; }
            // Add any other properties as needed

     
          
            // Add any other properties as needed
        

    }
}
