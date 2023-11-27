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
            //Este m�todo adiciona os servi�os necess�rios para suportar controladores MVC (Model-View-Controller) em sua aplica��o.
            //Isso inclui suporte para roteamento, gerenciamento de views, entre outros recursos relacionados ao MVC.
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<BancoContext>(o =>o.UseSqlServer(Configuration.GetConnectionString("Database" )));
            //Esta linha de c�digo adiciona os servi�os necess�rios para o Entity Framework Core e configura um contexto de banco de dados (BancoContext) para ser usado pela aplica��o.
            //Vamos dividir em partes:
            //services.AddEntityFrameworkSqlServer(): Adiciona o servi�o necess�rio para o Entity Framework Core com suporte ao provedor de banco de dados SQL Server.
            //.AddDbContext<BancoContext>(): Adiciona um contexto de banco de dados � aplica��o. O BancoContext especifica qual DbContext deve ser usado pela aplica��o. Isso indica ao Entity Framework Core que a aplica��o utilizar� o contexto BancoContext para interagir com o banco de dados.
            //O Entity Framework Core usar� as configura��es definidas no construtor de BancoContext para conectar-se ao banco de dados.
            //Em resumo, essas linhas de c�digo est�o configurando servi�os necess�rios para suportar MVC na aplica��o e configurando o Entity Framework Core para uso com um banco de dados SQL Server, especificamente usando o contexto de banco de dados BancoContext. Isso � comum em aplica��es ASP.NET Core que utilizam o padr�o MVC e necessitam de acesso a um banco de dados.
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
