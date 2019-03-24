using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroListaDeExercicio.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public List<Dependente> Dependente { get; set; }



    }
}
