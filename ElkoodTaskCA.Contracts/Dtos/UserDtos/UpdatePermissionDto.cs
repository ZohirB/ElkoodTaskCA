namespace ElkoodTaskCA.Contracts.Dtos.UserDtos;

public class UpdatePermissionDto
{
    [Required(ErrorMessage = "UserName is required")]
    public string UserName { get; set; }
}