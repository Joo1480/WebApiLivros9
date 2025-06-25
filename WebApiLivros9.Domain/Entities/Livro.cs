using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Domain.Validation;

namespace WebApiLivros9.Domain.Entities
{
    public class Livro
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Autor { get; private set; }
        public string Editora { get; private set; }
        public DateTime AnoPublicacao { get; private set; }
        public string Edicao { get; private set; }
        public ICollection <Emprestimo> Emprestimos { get; set; }

        public Livro(int id, string nome, string autor, string editora, DateTime anoPublicacao, string edicao)
        {
            DomainExceptionValidation.When(id < 0, "Id do livro deve ser positivo");
            ValidateDomain(nome,autor, editora, anoPublicacao, edicao);
            Id = id;
        }

        public Livro(string nome, string autor, string editora, DateTime anoPublicacao, string edicao)
        {
            ValidateDomain(nome, autor, editora, anoPublicacao, edicao);
        }
        public void Update(string nome, string autor, string editora, DateTime anoPublicacao, string edicao)
        {
            ValidateDomain(nome, autor, editora, anoPublicacao, edicao);
        }
        public void ValidateDomain(string nome, string autor, string editora, DateTime anoPublicacao, string edicao)
        {
            DomainExceptionValidation.When(nome.Length > 50, "O nome do livro deve ter no máximo 50 caracteres");
            DomainExceptionValidation.When(autor.Length > 200, "O autor do livro deve ter no máximo 200 caracteres");
            DomainExceptionValidation.When(editora.Length > 50, "O nome da editora deve ter no máximo 50 caracteres");
            DomainExceptionValidation.When(edicao.Length > 50, "O ano da edição do livro deve ter no máximo 50 caracteres");

            Nome = nome;
            Autor = autor;
            Editora = editora;
            AnoPublicacao = anoPublicacao;
            this.Edicao = edicao;
        }
    }
}
