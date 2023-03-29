using HospitalManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HospitalManagement.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Patients> Patient{ get; set; }

        public DbSet<Doctors> Doctors { get; set; }

        public DbSet<Laboratory> Laboratory { get; set; }

        public DbSet<Pharmacy> Pharmacy { get; set; }



    }

}
