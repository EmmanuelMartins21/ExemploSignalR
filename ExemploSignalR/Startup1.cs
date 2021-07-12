using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(ExemploSignalR.Startup1))]

namespace ExemploSignalR
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR(); // cria uma rota para chamar o serviço
        }
    }
}
