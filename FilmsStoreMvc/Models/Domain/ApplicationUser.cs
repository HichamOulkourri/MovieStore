using Microsoft.AspNetCore.Identity;

namespace FilmsStoreMvc.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
