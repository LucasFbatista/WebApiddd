using RestApiDDD.Application.Dtos;
using RestApiDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {

        //AQUI ESTAMOS FAZENDO O CONTRATO DE UM MAPEAMENTO DE UMA DTO PARA UMA ENTIDADE
        Cliente MapperDtoToEntity(ClienteDto clienteDto);

        IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}