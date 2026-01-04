using Microsoft.AspNetCore.Mvc;
using WebApiLivros9.Application.DTOs;
using WebApiLivros9.Application.Interfaces;
using WebApiLivros9.Infra.Ioc;

namespace WebApiLivros9.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : Controller
    {

        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpPost]
        public async Task<ActionResult> Incluir(LivroDTO livroDTO)
        {
            var livroDTOIncluido = await _livroService.Incluir(livroDTO);
            if (livroDTOIncluido == null)
            {
                return BadRequest("Ocorreu um erro ao incluir o livro");
            }
            return Ok("Livro Incluido com Sucesso!");
        }
        [HttpPut]
        public async Task<ActionResult> Alterar(LivroDTO livroDTO)
        {
            var livroDTOIncluido = await _livroService.Alterar(livroDTO);
            if (livroDTOIncluido == null)
            {
                return BadRequest("Ocorreu um erro ao alterar o livro");
            }
            return Ok("Livro alterado com Sucesso!");
        }

        [HttpDelete]
        public async Task<ActionResult> Excluir(int id)
        {
            var livroDTOExcluido = await _livroService.Excluir(id);
            if (livroDTOExcluido == null)
            {
                return BadRequest("Ocorreu um erro ao alterar o livro");
            }
            return Ok("Livro excluido com Sucesso!");
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Selecionar(int id)
        {
            var livroDTO = await _livroService.SelecionarAsync(id);
            if (livroDTO == null)
            {
                return NotFound("Livro não encontrado");
            }
            return Ok(livroDTO);
        }
        [HttpGet]
        public async Task<ActionResult> SelecionarTodos()
        {
            var livrosDTO = await _livroService.SelecionarTodosAsync();
            return Ok(livrosDTO);
        }
    }
}
