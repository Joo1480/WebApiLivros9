using Microsoft.AspNetCore.Mvc;
using WebApiLivros9.API.Models;
using WebApiLivros9.Application.DTOs;
using WebApiLivros9.Application.Interfaces;
using WebApiLivros9.Domain.Account;

namespace WebApiLivros9.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IAuthenticate _authenticateService;
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IAuthenticate authenticateService, IUsuarioService usuarioService)
        {
            _authenticateService = authenticateService;
            _usuarioService = usuarioService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserToken>> Incluir(UsuarioDTO usuarioDTO)
        {
            if (usuarioDTO == null)
            {
                return BadRequest("Dados Inválidos");
            }

            var emailExiste = await _authenticateService.UserExists(usuarioDTO.Email);

            if (emailExiste)
            {
                return BadRequest("Este e-mail já possui um cadastro.");
            }

            var usuario = await _usuarioService.Incluir(usuarioDTO);
            if (usuario == null)
            {
                return BadRequest("Ocorreu erro ao cadastrar");
            }
            var token = _authenticateService.GenerateToken(usuario.Id, usuario.Email);

            return new UserToken
            {
                Token = token
            };

        }

        [HttpPost("login")]
        public async Task<ActionResult<UserToken>> Selecionar(LoginModel loginModel)
        {
            var existe = await _authenticateService.UserExists(loginModel.Email);
            if (!existe)
            {
                return Unauthorized("Usuário não existe.");
            }
            var result = await _authenticateService.AuthenticateAsync(loginModel.Email, loginModel.Password);
            if (!result)
            {
                return Unauthorized("Usuário pu senha errado.");
            }

            var usuario = await _authenticateService.GetUserbyEmail(loginModel.Email);

            var token = _authenticateService.GenerateToken(usuario.Id, usuario.Email);

            return new UserToken
            {
                Token = token
            };
        }
    }
}
