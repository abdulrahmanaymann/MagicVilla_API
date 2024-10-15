using Microsoft.AspNetCore.Identity;

namespace MagicVilla.Models.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string Name { get; set; }
    }
}
