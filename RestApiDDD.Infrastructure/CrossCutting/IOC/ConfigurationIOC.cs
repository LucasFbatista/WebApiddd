using Autofac;
using RestApiDDD.Application;
using RestApiDDD.Application.Interfaces;
using RestApiDDD.Application.Interfaces.Mappers;
using RestApiDDD.Application.Mappers;
using RestApiDDD.Domain.Core.Interfaces.Repositorys;
using RestApiDDD.Domain.Core.Interfaces.Services;
using RestApiDDD.Domain.Services;
using RestApiDDD.Infrastructure.Data.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDDD.Infrastructure.CrossCutting.IOC
{
    class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {   

            //AQUI ESTAMOS GERANDO A NOSSA INJECAO DE DEPENDENCIAS PARA QUE ASSIM
            //POSSAMOS CONSEGUIR UTILIZAR NOSSAS CLASSES E INSTERFACES
            #region IOC
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();

            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();

            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();

            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            #endregion
        }
    }
}
