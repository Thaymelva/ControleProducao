using controleProducao.Data;
using controleProducao.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleProducao
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //Este método adiciona os serviços necessários para suportar controladores MVC (Model-View-Controller) em sua aplicação.
            //Isso inclui suporte para roteamento, gerenciamento de views, entre outros recursos relacionados ao MVC.
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<BancoContext>(o =>o.UseSqlServer(Configuration.GetConnectionString("Database" )));
            //Esta linha de código adiciona os serviços necessários para o Entity Framework Core e configura um contexto de banco de dados (BancoContext) para ser usado pela aplicação.
            //Vamos dividir em partes:
            //services.AddEntityFrameworkSqlServer(): Adiciona o serviço necessário para o Entity Framework Core com suporte ao provedor de banco de dados SQL Server.
            //.AddDbContext<BancoContext>(): Adiciona um contexto de banco de dados à aplicação. O BancoContext especifica qual DbContext deve ser usado pela aplicação. Isso indica ao Entity Framework Core que a aplicação utilizará o contexto BancoContext para interagir com o banco de dados.
            //O Entity Framework Core usará as configurações definidas no construtor de BancoContext para conectar-se ao banco de dados.
            //Em resumo, essas linhas de código estão configurando serviços necessários para suportar MVC na aplicação e configurando o Entity Framework Core para uso com um banco de dados SQL Server, especificamente usando o contexto de banco de dados BancoContext. Isso é comum em aplicações ASP.NET Core que utilizam o padrão MVC e necessitam de acesso a um banco de dados.
            services.AddScoped<IControleRepositorio, ControleRepositorio>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
