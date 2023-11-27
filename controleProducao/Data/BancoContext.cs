using controleProducao.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleProducao.Data
{
    //Nesta pasta dat, nos iremos herdar o contexto do Entit framework do banco de dados
    public class BancoContext : DbContext
    // Aqui, você está definindo uma classe chamada BancoContext que herda da classe DbContext. O DbContext é uma classe fundamental no Entity Framework Core e representa o contexto do banco de dados, que é usado para interagir com o banco de dados.
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        // public BancoContext(DbContextOptions<BancoContext> options) : base(options):
        // Este é o construtor da classe BancoContext.Ele aceita um parâmetro do tipo DbContextOptions<BancoContext>, que contém as opções de configuração para o contexto do banco de dados.O construtor chama o construtor da classe base (base(options)), que é necessário quando você herda de DbContext e é responsável por configurar o contexto do banco de dados com as opções fornecidas.
        // Essas opções incluem detalhes sobre o provedor de banco de dados, a cadeia de conexão e outras configurações específicas do banco de dados que podem ser definidas durante a configuração da aplicação.
        //Este é um metodo de construção para conexão do banco de dados
        {

        }

        public DbSet<ControleModel> Controle{get; set;}
      

     
    }
}
