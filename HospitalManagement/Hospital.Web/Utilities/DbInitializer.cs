using Hospital.Web.Data;
using Hospital.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Web.Utilities
{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDBContext context;

        public DbInitializer(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDBContext context)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.context = context;
        }

        public void initialize()
        {
            try 
            {
                if (context.Database.GetPendingMigrations().Count()>0)
                {
                    context.Database.Migrate();
                }
            } 
            catch (Exception) 
            {
                throw;
            }
            if (!roleManager.RoleExistsAsync(WebRoles.WebAdmin).GetAwaiter().GetResult())
            {
                roleManager.CreateAsync(new IdentityRole(WebRoles.WebAdmin)).GetAwaiter().GetResult();
                roleManager.CreateAsync(new IdentityRole(WebRoles.WebPatient)).GetAwaiter().GetResult();
                roleManager.CreateAsync(new IdentityRole(WebRoles.WebDoctor)).GetAwaiter().GetResult();

                userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "Jenny",
                    Email="kereujennifer@gmail.com",

                },"Jennifer@101").GetAwaiter().GetResult();

                var AppUser = context.ApplicationUsers.FirstOrDefault(x => x.Email == "kereujennifer@gmail.com");
                if( AppUser!=null)
                {
                    userManager.AddToRoleAsync(AppUser, WebRoles.WebAdmin).GetAwaiter().GetResult();
                }


            }
        }
    }
}
