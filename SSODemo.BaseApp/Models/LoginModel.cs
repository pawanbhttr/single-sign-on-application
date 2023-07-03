using System.ComponentModel.DataAnnotations;

namespace SSODemo.BaseApp.Models
{
    public class LoginModel
    {
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
