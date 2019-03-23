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

        }
    }
}
