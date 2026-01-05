using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Domain.Entities;

namespace WebApiLivros9.Domain.Interfaces
{
    public interface IEmprestimoRepository
    {
        Task<Emprestimo> Incluir(Emprestimo model);
        Task<Emprestimo> Alterar(Emprestimo model);
        Task<Emprestimo> Excluir(int id);
        Task<Emprestimo> SelecionarAsync(int id);
        Task<IEnumerable<Emprestimo>> SelecionarTodosAsync();
    }
}
