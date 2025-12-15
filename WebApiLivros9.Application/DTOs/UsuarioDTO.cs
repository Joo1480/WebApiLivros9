using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiLivros9.Application.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório")]
        [MaxLength(250,ErrorMessage ="O nome não pode ter mais de 250 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [MaxLength(200, ErrorMessage = "O e-mail não pode ter mais de 250 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatório")]
        [MaxLength(100, ErrorMessage = "A senha não pode ter mais de 100 caracteres")]
        [MinLength(8, ErrorMessage = "A senha não pode ter menos de 8 caracteres")]
        [NotMapped]
        public string Password { get; set; }
        [NotMapped]
        public byte[]? PasswordHash { get; private set; }
        [NotMapped]
        public byte[]? PasswordSalt { get; private set; }
        [JsonIgnore]
        public bool IsAdmin { get; set; }
    }
}
