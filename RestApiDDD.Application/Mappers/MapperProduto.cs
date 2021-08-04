using RestApiDDD.Application.Dtos;
using RestApiDDD.Application.Interfaces.Mappers;
using RestApiDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiDDD.Application.Mappers
{
    //AQUI FAZEMOS O MAPEAMENTO DE TODAS AS NOSSAS ENTITDADES E DTO
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };
            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(c => new ProdutoDto
            {
                Id = c.Id,
                Nome = c.Nome,
                Valor = c.Valor
            });

            return dto;
        }
    }
}