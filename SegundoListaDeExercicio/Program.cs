using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoListaDeExercicio.Entities;
using SegundoListaDeExercicio.Repositories;

namespace SegundoListaDeExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Endereco = new Endereco();
            Console.Write("\tBem vindo ao programa de cadastrar cliente!");
            Console.Write("\nInforme o ID do cliente.....: ");
            cliente.ID = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do cliente...: ");
            cliente.Nome = Console.ReadLine();
            Console.Write("Informe o cpf do cliente....: ");
            cliente.CPF = Console.ReadLine();
            Console.Write("\tInforme o Endereço");
            Console.Write("\nInforme o ID do endereço....: ");
            cliente.Endereco.Id = int.Parse(Console.ReadLine());
            Console.Write("Informe o Logradouro........: ");
            cliente.Endereco.Logradouro = Console.ReadLine();
            Console.Write("Informe o Bairro............: ");
            cliente.Endereco.Bairro = Console.ReadLine();
            Console.Write("Informe o CEP...............: ");
            cliente.Endereco.CEP = Console.ReadLine();
            Console.Write("Informe a cidade............: ");
            cliente.Endereco.Cidade = Console.ReadLine();
            Console.WriteLine("Informe o Estado........: ");
            cliente.Endereco.Estado = Console.ReadLine();
            


            //Informações Impressas
            Console.WriteLine($"\tCliente {cliente.Nome.ToUpper()} ");
            Console.WriteLine($"Id do cliente.: {cliente.ID}");
            Console.WriteLine($"CPF do cliente: {cliente.CPF}");
            Console.WriteLine($"\tEndereço do  {cliente.Nome}");
            Console.WriteLine($"Id...........: {cliente.Endereco.Id}");
            Console.WriteLine($"Logradouro...: {cliente.Endereco.Logradouro}");
            Console.WriteLine($"Bairro.......: {cliente.Endereco.Bairro}");
            Console.WriteLine($"CEP..........: {cliente.Endereco.CEP}");
            Console.WriteLine($"Cidade.......: {cliente.Endereco.Cidade}");
            Console.WriteLine($"Estado.......: {cliente.Endereco.Estado}");

            try
            {
                ClienteRepositories clienteRepositories = new ClienteRepositories();
                clienteRepositories.ExportarParaTXT(cliente);
                Console.WriteLine("Exportados com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hilston, deu erro: " + e.Message);
                
            }

            Console.ReadKey();
        }
    }
}
