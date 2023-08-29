using Microsoft.AspNetCore.Identity;

namespace ElkoodTaskCA.Domain.Models.UserEntities;

public class ApplicationUser : IdentityUser
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}