using controleProducao.Data;
using controleProducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleProducao.Repositorio
{
   public class ControleRepositorio : IControleRepositorio
   {

        private readonly BancoContext _bancoContext;
        public ControleRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ControleModel ListarPorId(int id)
        {
            return _context.Controle.FirstOrDefault(x => x.Id==id);
        }
        public List<ControleModel> BuscarTodos()
        {
            return _bancoContext.Controle.ToList();
        }

        public ControleModel Adicionar(ControleModel controle)
        {
            _bancoContext.Controle.Add(controle);
            _bancoContext.SaveChanges();
            return controle;
            

            //gravar no banco de dados
        }


    }
}
