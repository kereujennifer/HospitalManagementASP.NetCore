using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserManagement.Models
{
    public class UserDbContext: IdentityDbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
                    : base(options)
        {

        }
    }
}
