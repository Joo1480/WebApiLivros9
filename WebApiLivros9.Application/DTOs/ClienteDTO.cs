﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLivros9.Application.DTOs
{
    public class ClienteDTO
    {
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 caracteres")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(200, ErrorMessage = "O Nome deve ter 200 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Endereço é obrigatório")]
        [StringLength(50, ErrorMessage = "O Endereço deve ter 50 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "A Cidade é obrigatória")]
        [StringLength(50, ErrorMessage = "A Cidade deve ter 50 caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório")]
        [StringLength(50, ErrorMessage = "O Bairro deve ter 50 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório")]
        [StringLength(50, ErrorMessage = "O número deve ter 50 caracteres")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O Telefone Celular é obrigatório")]
        [StringLength(11, ErrorMessage = "O número de Telefone celular deve ter 11 caracteres")]
        public string TelefoneCelular { get; set; }

        [Required(ErrorMessage = "O Telefone Fixo é obrigatório")]
        [StringLength(10, ErrorMessage = "O número de Telefone fixo deve ter 10 caracteres")]
        public string TelefoneFixo { get; set; }
    }
}
