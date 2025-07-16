using Microsoft.AspNetCore.Mvc;
using WebApiLivros9.Application.DTOs;
using WebApiLivros9.Application.Interfaces;
using WebApiLivros9.Domain.Interfaces;

namespace WebApiLivros9.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public async Task<ActionResult> Incluir(ClienteDTO clienteDTO)
        {
            var clienteDTOIncluido = await _clienteService.Incluir(clienteDTO);
            if (clienteDTOIncluido == null)
            {
                return BadRequest("Ocorreu um erro ao incluir o cliente");
            }
            return Ok("Cliente Incluido com Sucesso!");
        }
        [HttpPut]
        public async Task<ActionResult> Alterar(ClienteDTO clienteDTO)
        {
            var clienteDTOIncluido = await _clienteService.Alterar(clienteDTO);
            if (clienteDTOIncluido == null)
            {
                return BadRequest("Ocorreu um erro ao alterar o cliente");
            }
            return Ok("Cliente alterado com Sucesso!");
        }

        [HttpDelete]
        public async Task<ActionResult> Excluir(int id)
        {
            var clienteDTOExcluido = await _clienteService.Excluir(id);
            if (clienteDTOExcluido == null)
            {
                return BadRequest("Ocorreu um erro ao alterar o cliente");
            }
            return Ok("Cliente excluido com Sucesso!");
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Selecionar(int id)
        {
            var clienteDTO = await _clienteService.SelecionarAsync(id);
            if (clienteDTO == null)
            {
                return BadRequest("Cliente não encontrado");
            }
            return Ok(clienteDTO);
        }
        [HttpGet]
        public async Task<ActionResult> SelecionarTodos()
        {
            var clientesDTO = await _clienteService.SelecionarTodosAsync();

            return Ok(clientesDTO);
        }
    }
}
