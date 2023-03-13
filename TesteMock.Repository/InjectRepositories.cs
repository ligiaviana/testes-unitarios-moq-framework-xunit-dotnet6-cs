using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using TesteMock.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace TesteMock.Repository
{
    public static class InjectRepositories
    {
        public static void AddRepositories(this IServiceCollection service)
        {
            service.AddTransient<IProdutoRepository, ProdutoRepository>();

        }
    }
}
