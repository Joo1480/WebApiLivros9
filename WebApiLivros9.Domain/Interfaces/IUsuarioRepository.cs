using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Domain.Entities;

namespace WebApiLivros9.Domain.Interfaces
{
    public  interface IUsuarioRepository
    {
        Task<Usuario> Incluir(Usuario model);
        Task<Usuario> Alterar(Usuario model);
        Task<Usuario> Excluir(int id);
        Task<Usuario> SelecionarAsync(int id);
        Task<IEnumerable<Usuario>> SelecionarTodosAsync();
    }
}
