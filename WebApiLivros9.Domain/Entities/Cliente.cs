using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Domain.Validation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApiLivros9.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string CPF { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Numero { get; private set; }
        public string TelefoneCelular { get; private set; }
        public string TelefoneFixo { get; private set; }
        public ICollection<Emprestimo> Emprestimos { get; set; }

        public Cliente(int id, string CPF, string nome, string endereco,
            string cidade, string bairro, string numero, string telefoneCelular, string telefoneFixo)
        {
            DomainExceptionValidation.When(id < 0, "O ID do cliente deve ser positivo");
            Id = id;
            ValidateDomain(CPF, nome, endereco, cidade, bairro, numero, telefoneCelular, telefoneFixo);
        }
        public Cliente(string CPF, string nome, string endereco, 
            string cidade, string bairro, string numero, string telefoneCelular, string telefoneFixo)
        {
            ValidateDomain(CPF, nome, endereco, cidade, bairro, numero, telefoneCelular, telefoneFixo);
        }
        public void Update(string CPF, string nome, string endereco,
            string cidade, string bairro, string numero, string telefoneCelular, string telefoneFixo)
        {
            ValidateDomain(CPF, nome, endereco, cidade, bairro, numero, telefoneCelular, telefoneFixo);
        }

        public void ValidateDomain(string Cpf, string nome, string endereco,
            string cidade, string bairro, string numero, string telefoneCelular, string telefoneFixo)
        {
            DomainExceptionValidation.When(Cpf.Length != 11, "O CPF deve ter 11 caracteres.");
            DomainExceptionValidation.When(nome.Length > 200, "O Nome deve ter, no máximo, 200 caracteres.");
            DomainExceptionValidation.When(endereco.Length > 50, "O endereço deve ter, no máximo, 50 caracteres.");
            DomainExceptionValidation.When(cidade.Length > 50, "A cidade deve ter, no máximo, 50 caracteres.");
            DomainExceptionValidation.When(bairro.Length > 50, "O bairro deve ter, no máximo, 50 caracteres.");
            DomainExceptionValidation.When(numero.Length > 20, "O numero deve ter, no máximo, 20 caracteres.");
            DomainExceptionValidation.When(telefoneCelular.Length > 11, "O celular deve ter, no máximo, 11 caracteres.");
            DomainExceptionValidation.When(telefoneFixo.Length > 11, "O telefone fixo deve ter, no máximo, 10 caracteres.");

            CPF = Cpf;
            Nome = nome;
            Endereco = endereco;
            Cidade = cidade;
            Bairro = bairro;
            Numero = numero;
            TelefoneCelular = telefoneCelular;
            TelefoneFixo = telefoneFixo;
        }
    }
}
