using Microsoft.AspNet.Identity.EntityFramework;

using Microsoft.AspNet.Identity;

using System.Security.Claims;
using System.Threading.Tasks;
using Remote_db.Interfaces;

namespace Remote_db.Models
{
    public class ApplicationUser : IdentityUser, IIdentifiable<string>
    {

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager) {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}