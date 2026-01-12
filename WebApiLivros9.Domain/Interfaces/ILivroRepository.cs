using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Domain.Entities;
using WebApiLivros9.Domain.Pagination;

namespace WebApiLivros9.Domain.Interfaces
{
    public interface ILivroRepository
    {
        Task<Livro> Incluir(Livro model);
        Task<Livro> Alterar(Livro model);
        Task<Livro> Excluir(int id);
        Task<Livro> SelecionarAsync(int id);
        Task<PagedList<Livro>> SelecionarTodosAsync(int pageNumber, int pageSize);
    }
}
