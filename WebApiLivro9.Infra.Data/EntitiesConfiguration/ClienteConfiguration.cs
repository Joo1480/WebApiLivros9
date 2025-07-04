﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Domain.Entities;

namespace WebApiLivros9.Infra.Data.EntitiesConfiguration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CPF).HasMaxLength(11).IsRequired();
            builder.Property(x => x.Nome).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Endereco).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Cidade).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Bairro).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Numero).HasMaxLength(50).IsRequired();
            builder.Property(x => x.TelefoneCelular).HasMaxLength(11).IsRequired();
            builder.Property(x => x.TelefoneFixo).HasMaxLength(10).IsRequired();
        }
    }
}
