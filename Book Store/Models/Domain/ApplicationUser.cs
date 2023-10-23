using Microsoft.AspNetCore.Identity;

namespace Book_Store.Models.Domain
{
    public class ApplicationUser: IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }
}
