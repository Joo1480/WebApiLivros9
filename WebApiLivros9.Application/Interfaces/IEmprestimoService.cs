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
    public interface IEmprestimoService
    {
        Task<EmprestimoDTO> Incluir(EmprestimoPostDTO modelPostDTO);
        Task<EmprestimoDTO> Alterar(EmprestimoDTO modelDTO);
        Task<EmprestimoDTO> Excluir(int id);
        Task<EmprestimoDTO> SelecionarAsync(int id);
        Task<PagedList<EmprestimoDTO>> SelecionarTodosAsync(int pageNumber, int pageSize);
        Task<bool> VerificaDisponibilidadeAsync(int seqLivro);
    }
}
