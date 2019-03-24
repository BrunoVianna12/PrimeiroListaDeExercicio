using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoListaDeExercicio.Entities
{
    public class Empresa
    {
        public string NomeDaEmpresa { get; set; }
        public int CodigoDaEmpresa { get; set; }
        public string CNPJ { get; set; }
        public Endereco Endereco{ get; set; }
        public Contato Contato { get; set; }

    }
}
