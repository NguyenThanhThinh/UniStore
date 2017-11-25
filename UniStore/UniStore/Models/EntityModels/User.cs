using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UniStore.Models.EntityModels
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }

        public virtual List<Order> Orders { get; set; } = new List<Order>();

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }
    }
}