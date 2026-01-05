using Microsoft.AspNetCore.Mvc;
using WebApiLivros9.Application.DTOs;
using WebApiLivros9.Application.Interfaces;
using WebApiLivros9.Infra.Ioc;

namespace WebApiLivros9.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoService _emprestimoService;

        public EmprestimoController(IEmprestimoService emprestimoService)
        {
            _emprestimoService = emprestimoService;
        }

        [HttpPost]
        public async Task<ActionResult> Incluir(EmprestimoPostDTO emprestimoPostDTO)
        {
            emprestimoPostDTO.DataEmprestimo = DateTime.Now;
            emprestimoPostDTO.Entregue = false;
            var emprestimoDTOIncluido = await _emprestimoService.Incluir(emprestimoPostDTO);
            if (emprestimoDTOIncluido == null)
            {
                return BadRequest("Ocorreu um erro ao incluir o emprestimo");
            }
            return Ok("Emprestimo Incluido com Sucesso!");
        }
        [HttpPut]
        public async Task<ActionResult> Alterar(EmprestimoPutDTO emprestimoPutDTO)
        {
            var emprestimoDTO = await _emprestimoService.SelecionarAsync(emprestimoPutDTO.Id);
            if (emprestimoDTO == null)
            {
                return NotFound("Emprestimo não encontrado");
            }

            emprestimoDTO.DataEntrega = emprestimoPutDTO.DataEntrega;
            emprestimoDTO.Entregue = emprestimoPutDTO.Entregue;

            var emprestimoDTOIncluido = await _emprestimoService.Alterar(emprestimoDTO);
            if (emprestimoDTOIncluido == null)
            {
                return BadRequest("Ocorreu um erro ao alterar o emprestimo");
            }
            return Ok("Emprestimo alterado com Sucesso!");
        }

        [HttpDelete]
        public async Task<ActionResult> Excluir(int id)
        {
            var emprestimoDTOExcluido = await _emprestimoService.Excluir(id);
            if (emprestimoDTOExcluido == null)
            {
                return BadRequest("Ocorreu um erro ao alterar o emprestimo");
            }
            return Ok("Emprestimo excluido com Sucesso!");
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Selecionar(int id)
        {
            var emprestimoDTO = await _emprestimoService.SelecionarAsync(id);
            if (emprestimoDTO == null)
            {
                return NotFound("Emprestimo não encontrado");
            }
            return Ok(emprestimoDTO);
        }
        [HttpGet]
        public async Task<ActionResult> SelecionarTodos()
        {
            var emprestimosDTO = await _emprestimoService.SelecionarTodosAsync();

            return Ok(emprestimosDTO);
        }
    }
}
