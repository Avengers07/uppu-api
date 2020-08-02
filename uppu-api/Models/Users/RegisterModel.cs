using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace uppu_api.Models.Users
{
    [ExcludeFromCodeCoverage]
    public class RegisterModel
    {
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
