using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiLivros9.Application.DTOs
{
    public class EmprestimoPostDTO
    {
        [Required(ErrorMessage ="O cliente é Obrigatório")]
        [Range(1,int.MaxValue, ErrorMessage = "O ID é inválido")]
        public int SeqCliente { get; set; }
        [Required(ErrorMessage = "O livro é Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O ID é inválido")]
        public int SeqLivro { get; set; }
        [Required(ErrorMessage = "A data de entrega é Obrigatório")]
        public DateTime DataEntrega { get; set; }
        [JsonIgnore]
        public DateTime DataEmprestimo { get; set; }
        [JsonIgnore]
        public bool Entregue { get; set; }
    }
}
