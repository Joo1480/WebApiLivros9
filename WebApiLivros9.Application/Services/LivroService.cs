using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Application.DTOs;
using WebApiLivros9.Application.Interfaces;
using WebApiLivros9.Domain.Entities;
using WebApiLivros9.Domain.Interfaces;
using WebApiLivros9.Domain.Pagination;

namespace WebApiLivros9.Application.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _repository;
        private readonly IMapper _mapper;

        public LivroService(ILivroRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<LivroDTO> Alterar(LivroDTO livroDTO)
        {
            var livro = _mapper.Map<Livro>(livroDTO);
            var livroAlterado = await _repository.Alterar(livro);
            return _mapper.Map<LivroDTO>(livroAlterado);
        }

        public async Task<LivroDTO> Excluir(int id)
        {
            var livroExcluido = await _repository.Excluir(id);
            return _mapper.Map<LivroDTO>(livroExcluido);
        }

        public async Task<LivroDTO> Incluir(LivroDTO livroDTO)
        {
            var livro = _mapper.Map<Livro>(livroDTO);
            var livroIncluido = await _repository.Incluir(livro);
            return _mapper.Map<LivroDTO>(livroIncluido);
        }
        public async Task<LivroDTO> SelecionarAsync(int id)
        {
            var livro = await _repository.SelecionarAsync(id);
            return _mapper.Map<LivroDTO>(livro);
        }
        public async Task<PagedList<LivroDTO>> SelecionarTodosAsync(int pageNumber, int pageSize)
        {
            var livros = await _repository.SelecionarTodosAsync(pageNumber, pageSize);
            var livrosDTO = _mapper.Map<IEnumerable<LivroDTO>>(livros);

            return new PagedList<LivroDTO>(livrosDTO, pageNumber, pageSize, livros.TotalCount);
        }
    }
}
