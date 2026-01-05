using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLivros9.Application.DTOs
{
    public class EmprestimoDTO
    {
        public int Id { get; set; }
        public int SeqCliente { get; set; }
        public int SeqLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataEntrega { get; set; }
        public bool Entregue { get; set; }
        public ClienteDTO? ClienteDTO { get; set; }          
        public LivroDTO? LivroDTO { get; set; }
    }
}
