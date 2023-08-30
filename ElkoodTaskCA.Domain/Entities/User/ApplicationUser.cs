using Microsoft.AspNetCore.Identity;

namespace ElkoodTaskCA.Domain.Entities.User;

public class ApplicationUser : IdentityUser
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}