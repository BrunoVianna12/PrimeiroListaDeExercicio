using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroListaDeExercicio.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public Decimal Preco { get; set; }
        public DateTime DataValidade { get; set; }
        public Categoria Categoria { get; set; }



    }
}
