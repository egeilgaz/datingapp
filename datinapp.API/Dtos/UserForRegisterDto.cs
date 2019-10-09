using System.ComponentModel.DataAnnotations;

namespace datinapp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8,MinimumLength = 4, ErrorMessage = "şifrenizi 4 ile 8 arası tutunuz" )]
        public string Password { get; set; }
    }

}