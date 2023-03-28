using HospitalManagement.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Data
{
    public class HospitalDBContext : IdentityDbContext
    {
        public HospitalDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<PatientViewModel>Hospital { get; set; }         
        public DbSet<HospitalManagement.ViewModels.DoctorViewModel>? DoctorViewModel { get; set; }
    }
}
