using System.ComponentModel.DataAnnotations;

namespace JWT.DTOs
{
    public class CreateRolDto
    {
        [Required (ErrorMessage = "Role Name is required")]

        public string RoleName { get; set; } = string.Empty;
    }
}
