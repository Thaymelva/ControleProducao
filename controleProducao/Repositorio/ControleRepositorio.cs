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

        private readonly BancoContext _context;

        public ControleModel ControleDB { get; private set; }

        public ControleRepositorio(BancoContext bancoContext)
        {
            this._context = bancoContext;
        }

        public ControleModel ListarPorId(int id)
        {
            return _context.Controle.FirstOrDefault(x => x.Id == id);
        }
        public List<ControleModel> BuscarTodos()
        {
            return _context.Controle.ToList();
        }

        public ControleModel Adicionar(ControleModel controle)
        {
            _context.Controle.Add(controle);
            _context.SaveChanges();
            return controle;
            

            //gravar no banco de dados
        }

        public ControleModel Atualizar(ControleModel controle)
        {
            ControleModel controleDB = ListarPorId(controle.Id);

            if (controleDB == null) throw new System.Exception("Houve um erro na atualização do registro!");
            controleDB.Inicio = controle.Inicio;
            controleDB.Operacao = controle.Operacao;
            controleDB.TempoMinutos = controle.TempoMinutos;
            controleDB.Maquina = controle.Maquina;
            controleDB.Operador = controle.Operador;
            controleDB.Tarefa = controle.Tarefa;
            controleDB.OrdemProducao = controle.OrdemProducao;
            controleDB.QuantidadeProduzida = controle.QuantidadeProduzida;
            controleDB.QuantidadePerdida = controle.QuantidadePerdida;
            controleDB.Cliente = controle.Cliente;
            controleDB.Produto = controle.Produto;
            controleDB.Observação = controle.Observação;

            _context.Controle.Update(ControleDB);
            _context.SaveChanges();
            return controleDB;

        }


        public bool ApagarConfirm(int id)
        {
            ControleModel controleDB = ListarPorId(id);
            if (controleDB == null) throw new System.Exception("Houve um erro na deleção do registro!");

            _context.Controle.Remove(controleDB);

            _context.SaveChanges();

            return true;
        }
    }
}
