using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Application.DTOs;
using WebApiLivros9.Domain.Entities;

namespace WebApiLivros9.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioDTO> Incluir(UsuarioDTO modelDTO);
        Task<UsuarioDTO> Alterar(UsuarioDTO modelDTO);
        Task<UsuarioDTO> Excluir(int id);
        Task<UsuarioDTO> SelecionarAsync(int id);
        Task<IEnumerable<UsuarioDTO>> SelecionarTodosAsync();
        Task<bool> ExisteUsuarioCadastradoAsync();
    }
}
