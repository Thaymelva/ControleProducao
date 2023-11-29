using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        

        public string Operacao { get; set; }
        [Required(ErrorMessage= "Selecione a operação")]

        public int TempoMinutos { get; set; }
        

        public string Maquina { get; set; }
        [Required(ErrorMessage = "Selecione a máquina")]

        public string Operador { get; set; }
        [Required(ErrorMessage = "Selecione o Operador")]

        public string Tarefa { get; set; }
        [Required(ErrorMessage = "Selecione a Tarefa")]

        public int OrdemProducao { get; set; }
        [Required(ErrorMessage = "Digite o número da OP")]

        public int QuantidadeProduzida { get; set; }
        [Required(ErrorMessage = "Digite a quantidade produzida")]
        public int QuantidadePerdida { get; set; }
        [Required(ErrorMessage = "Digite o número de perdas")]

        public string Cliente { get; set; }
        [Required(ErrorMessage = "Selecione o Cliente")]

        public string Produto { get; set; }
        [Required(ErrorMessage = "Selecione o Produto")]

        public string Observação { get; set; }





        public void InicializarInicio()
            {
                Inicio = DateTime.Now;
            }
        }







    }
