using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegundoListaDeExercicio.Entities;
using System.IO;

namespace SegundoListaDeExercicio.Repositories
{
    public class ClienteRepositories
    {

        public void ExportarParaTXT(Cliente cliente)
        {
            using (StreamWriter writer = new StreamWriter("c:\\temp\\clientes.txt", true))
            {
                writer.WriteLine($"\tCliente {cliente.Nome.ToUpper()} ");
                writer.WriteLine($"Id do cliente.: {cliente.ID}");
                writer.WriteLine($"CPF do cliente: {cliente.CPF}");
                writer.WriteLine($"\tEndereço do  {cliente.Nome}");
                writer.WriteLine($"Id...........: {cliente.Endereco.Id}");
                writer.WriteLine($"Logradouro...: {cliente.Endereco.Logradouro}");
                writer.WriteLine($"Bairro.......: {cliente.Endereco.Bairro}");
                writer.WriteLine($"CEP..........: {cliente.Endereco.CEP}");
                writer.WriteLine($"Cidade.......: {cliente.Endereco.Cidade}");
                writer.WriteLine($"Estado.......: {cliente.Endereco.Estado}");
                
            }
        }
    }
}
