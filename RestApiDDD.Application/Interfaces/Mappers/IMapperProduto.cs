using RestApiDDD.Application.Dtos;
using RestApiDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {

        //AQUI ESTAMOS FAZENDO O CONTRATO DE UM MAPEAMENTO DE UMA DTO PARA UMA ENTIDADE
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos);

        ProdutoDto MapperEntityToDto(Produto produto);
    }
}