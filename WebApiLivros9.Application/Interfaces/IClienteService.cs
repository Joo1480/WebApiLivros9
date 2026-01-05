using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Application.DTOs;
using WebApiLivros9.Domain.Entities;
using WebApiLivros9.Domain.Pagination;

namespace WebApiLivros9.Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDTO> Incluir(ClienteDTO clienteDTO);
        Task<ClienteDTO> Alterar(ClienteDTO clienteDTO);
        Task<ClienteDTO> Excluir(int id);
        Task<ClienteDTO> SelecionarAsync(int id);
        Task<PagedList<ClienteDTO>> SelecionarTodosAsync(int pageNumber, int pageSize);
    }
}
