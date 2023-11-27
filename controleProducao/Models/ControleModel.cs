using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleProducao.Models
{
    //Modelagem de classe com conexão com o banco
    public class ControleModel
    {
        //representação da tabela do banco de dados    

        public int Id { get; set; }

        public DateTime Inicio { get; set; } = DateTime.Now;

        public int TempoMinutos { get; set; }

        public string Maquina { get; set; }

        public string Operador { get; set; }

        public string Tarefa { get; set; }

        public int OrdemProducao { get; set; }

        public int QuantidadeProduzida { get; set; }

        public int QuantidadePerdida { get; set; }

        public string Cliente { get; set; }

        public string Produto { get; set; }

        public string Observação { get; set; }





        public void InicializarInicio()
            {
                Inicio = DateTime.Now;
            }
        }







    }
