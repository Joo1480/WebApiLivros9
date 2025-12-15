using System.ComponentModel.DataAnnotations;

namespace WebApiLivros9.API.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
