using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Domain.Entities;

namespace WebApiLivros9.Infra.Data.EntitiesConfiguration
{
    public class EmprestimoConfiguration : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SeqCliente).IsRequired();
            builder.Property(x => x.SeqLivro).IsRequired();
            builder.Property(x => x.DataEmprestimo).IsRequired();
            builder.Property(x => x.DataEntrega).IsRequired();
            builder.Property(x => x.Entregue).IsRequired();

            builder.HasOne(x => x.Cliente).WithMany(x => x.Emprestimos)
                .HasForeignKey(x => x.SeqCliente).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Livro).WithMany(x => x.Emprestimos)
                .HasForeignKey(x => x.SeqLivro).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
