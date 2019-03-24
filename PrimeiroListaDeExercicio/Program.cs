using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeiroListaDeExercicio.Entities;
using PrimeiroListaDeExercicio.Repositories;
namespace PrimeiroListaDeExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Categoria = new Categoria();

            Console.WriteLine("\tBem vindo ao Sistema de Cadastro de Produtos");
            Console.WriteLine("Informe o Id do Produto....: ");
            produto.IdProduto = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do produto..: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto.: ");
            produto.Preco = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Data de Validade.: ");
            produto.DataValidade = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ID da categoria");
            produto.Categoria.IdCategoria = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe uma descrição para a categoria: ");
            produto.Categoria.Descricao = Console.ReadLine();


            ProdutoRepositories produtoRepositories = new ProdutoRepositories();
            try
            {
                produtoRepositories.ExportarParaTxt(produto);
                Console.WriteLine($"Exportação do produto {produto.Nome} feita com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hilston temos um erro: " + e.Message);
            }

            Console.WriteLine("Deseja cadastrar outro produto? (S)im ou (N)ão");
            string operacao = Console.ReadLine();

            if (operacao.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Main(args);
            }
            else
                Console.WriteLine("Fim do Programa");

            Console.ReadKey();
        }
    }
}
