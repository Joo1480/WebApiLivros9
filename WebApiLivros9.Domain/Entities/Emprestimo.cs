using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Domain.Validation;

namespace WebApiLivros9.Domain.Entities
{
    public  class Emprestimo
    {
        public int Id { get; private set; }
        public int SeqCliente { get; private set; }
        public int SeqLivro { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataEntrega { get; private set; }
        public bool Entregue {  get; private set; }
        public Cliente Cliente { get; set; }
        public Livro Livro { get; set; }

        public Emprestimo(int id, int seqCliente, int seqLivro, DateTime dataEmprestimo, DateTime dataEntrega,bool entregue) 
        {
            DomainExceptionValidation.When(id < 0, "Id do empréstimo deve ser positivo");
            Id = id;
            ValidateDomain(seqCliente,seqLivro,dataEmprestimo,dataEntrega,entregue);
        }

        public Emprestimo(int seqCliente, int seqLivro, DateTime dataEmprestimo, DateTime dataEntrega, bool entregue)
        {
            ValidateDomain(seqCliente, seqLivro, dataEmprestimo, dataEntrega, entregue);
        }

        public void Update(int seqCliente, int seqLivro, DateTime dataEmprestimo, DateTime dataEntrega, bool entregue)
        {
            ValidateDomain(seqCliente, seqLivro, dataEmprestimo, dataEntrega, entregue);
        }

        public void ValidateDomain(int seqCliente, int seqLivro, DateTime dataEmprestimo, DateTime dataEntrega, bool entregue)
        {
            DomainExceptionValidation.When(seqCliente <= 0, "Id do cliente deve ser maior que 0");
            DomainExceptionValidation.When(seqLivro <= 0, "Id do livro deve ser maior que 0");

            SeqCliente = seqCliente;
            SeqLivro = seqLivro;
            DataEmprestimo = dataEmprestimo;
            DataEntrega = dataEntrega;
            Entregue = entregue;
        }
    }
}
