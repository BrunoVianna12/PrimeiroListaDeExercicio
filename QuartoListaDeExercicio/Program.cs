using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuartoListaDeExercicio.Entities;
using QuartoListaDeExercicio.Repositories;

namespace QuartoListaDeExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();
            empresa.Contato = new Contato();
            empresa.Endereco = new Endereco();
            
            Console.WriteLine("\tBem vindo ao sistema de Cadastro da Empresa");
            Console.Write("\nInforme o código da empresa: ");
            empresa.CodigoDaEmpresa = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome da empresa...: ");
            empresa.NomeDaEmpresa = Console.ReadLine();
            Console.Write("Informe o CNPJ..............: ");
            empresa.CNPJ = Console.ReadLine();
            Console.Write("Informe o Logradouro........: ");
            empresa.Endereco.Logradouro = Console.ReadLine();
            Console.Write("Informe o Numero............: ");
            empresa.Endereco.Numero = int.Parse(Console.ReadLine());
            Console.Write("Informe o Bairro............: ");
            empresa.Endereco.Bairro= Console.ReadLine();
            Console.Write("Informe o Cidade............: ");
            empresa.Endereco.Cidade = Console.ReadLine();
            Console.Write("Informe o Estado............: ");
            empresa.Endereco.Estado = Console.ReadLine();
            Console.Write("Informe o CEP...............: ");
            empresa.Endereco.CEP = Console.ReadLine();
            Console.WriteLine("Informe o telefone fixo.: ");
            empresa.Contato.NumeroFixo = Console.ReadLine();
            Console.WriteLine("Informe o telefone CEL..: ");
            empresa.Contato.NumeroCel = Console.ReadLine();
            Console.WriteLine("Contato por Email.......: ");
            empresa.Contato.Email = Console.ReadLine();

            EmpresaRepositories empresaRepositories = new EmpresaRepositories();

            try
            {
                empresaRepositories.ExportarParaTxt(empresa);
                Console.WriteLine("Dados exportados com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hilston, tivemos um problema: " + e.Message);
                
            }



            Console.ReadKey();

        }
    }
}
