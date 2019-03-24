using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerceiroListaDeExercicio.Entities;
namespace TerceiroListaDeExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Dependente = new List<Dependente>();
            Console.Write("Informe o Id do funcionário: ");
            funcionario.Id = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Informe a data de admissão: ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de Dependentes: ");
            int qtdDependentes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdDependentes; i++)
            {
                Dependente dependente = new Dependente();
                Console.Write("Informe o ID do Dependente: ");
                dependente.Id = int.Parse(Console.ReadLine());
                Console.Write("Informe o Nome do depentente: ");
                dependente.Nome = Console.ReadLine();
                Console.WriteLine("Informe a data de nascimento: ");
                dependente.DataNascimento = DateTime.Parse(Console.ReadLine());

                funcionario.Dependente.Add(dependente);

            }


            Console.WriteLine("Id do funcionário: " + funcionario.Id);
            Console.WriteLine("Nome do funcionário: " + funcionario.Nome);
            Console.WriteLine("Data de Admissão : " + funcionario.DataAdmissao.ToString("dd/MM/yyyy"));

            foreach (var dependente in funcionario.Dependente)
            {

                Console.WriteLine("Id do dependente: " + dependente.Id);
                Console.WriteLine("Nome do dependente: " + dependente.Nome);
                Console.WriteLine("Data de nascimento : " + dependente.DataNascimento.ToString("dd/MM/yyyy"));
            }

            Console.WriteLine("Dados Impressos com Sucesso.");
            Console.ReadKey();


        }
    }
}
