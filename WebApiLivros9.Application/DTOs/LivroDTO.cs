using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLivros9.Application.DTOs
{
    public class LivroDTO
    {
        public int Id { get; set; }
        
        [MaxLength(50, ErrorMessage = "O nome do livro não pode ter mais de 50 caracteres")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        
        [MaxLength(200, ErrorMessage = "O nome do autor não pode ter mais de 200 caracteres")]
        [Required(ErrorMessage = "O campo autor é obrigatório")]
        public string Autor { get; set; }

        [MaxLength(50, ErrorMessage = "O nome da editora não pode ter mais de 50 caracteres")]
        [Required(ErrorMessage = "O campo editora é obrigatório")]
        public string Editora { get; set; }
        
        [Required(ErrorMessage = "O campo ano de publicação é obrigatório")]
        public DateTime AnoPublicacao { get; set; }

        [MaxLength(50, ErrorMessage = "O nome de edição não pode ter mais de 50 caracteres")]
        [Required(ErrorMessage = "O campo edição é obrigatório")]
        public string Edicao { get; set; }
    }
}
