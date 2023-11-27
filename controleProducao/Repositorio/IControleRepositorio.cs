using controleProducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleProducao.Repositorio
{
    public interface IControleRepositorio
    {
        ControleModel ListarPorId(int id);
        List<ControleModel> BuscarTodos();
        ControleModel Adicionar(ControleModel controle);

    }
}
