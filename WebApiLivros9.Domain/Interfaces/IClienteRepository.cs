using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Domain.Entities;
using WebApiLivros9.Domain.Pagination;

namespace WebApiLivros9.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente> Incluir(Cliente model);
        Task<Cliente> Alterar(Cliente model);
        Task<Cliente> Excluir(int id);
        Task<Cliente> SelecionarAsync(int id);
        Task<PagedList<Cliente>> SelecionarTodosAsync(int pageNumber, int pageSize);
    }
}
