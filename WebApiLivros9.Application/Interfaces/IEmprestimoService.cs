using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Application.DTOs;
using WebApiLivros9.Domain.Entities;

namespace WebApiLivros9.Application.Interfaces
{
    public interface IEmprestimoService
    {
        Task<EmprestimoDTO> Incluir(EmprestimoPostDTO modelPostDTO);
        Task<EmprestimoDTO> Alterar(EmprestimoDTO modelDTO);
        Task<EmprestimoDTO> Excluir(int id);
        Task<EmprestimoDTO> SelecionarAsync(int id);
        Task<IEnumerable<EmprestimoDTO>> SelecionarTodosAsync();
        Task<bool> VerificaDisponibilidadeAsync(int seqLivro);
    }
}
