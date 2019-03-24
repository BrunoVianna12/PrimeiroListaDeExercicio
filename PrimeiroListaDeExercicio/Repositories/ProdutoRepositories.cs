using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PrimeiroListaDeExercicio.Entities;
namespace PrimeiroListaDeExercicio.Repositories
{
    public class ProdutoRepositories
    {
        public void ExportarParaTxt(Produto produto)
        {
            using (StreamWriter writer = new StreamWriter("c:\\temp\\produtos.txt", true))
            {

                writer.WriteLine($"Produto {produto.Nome}");
                writer.WriteLine($"\tId do produto.........: {produto.IdProduto}");
                writer.WriteLine($"\tPreco do Produto......: {produto.Preco.ToString("c")}");
                writer.WriteLine($"\tData de Validade......: {produto.DataValidade.ToString("dd/MM/yyyy")}");
                writer.WriteLine($"\tId Categoria..........: {produto.Categoria.IdCategoria}");
                writer.WriteLine($"\tDescrição da categoria: {produto.Categoria.Descricao}");
                

            }
        }
    }
}
