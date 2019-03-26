using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoListaDeExercicio.Entities
{
    public class Cliente : Pessoa
    {
        public string CPF { get; set; }
        public Endereco Endereco { get; set; }


    }
}
