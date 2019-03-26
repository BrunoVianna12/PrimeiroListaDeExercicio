using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuartoListaDeExercicio.Entities;
using System.IO;

namespace QuartoListaDeExercicio.Repositories
{
    public class EmpresaRepositories
    {
        public void ExportarParaTxt(Empresa empresa)
        {
            using (StreamWriter writer = new StreamWriter($"c:\\temp\\Empresa-{empresa.CodigoDaEmpresa}-{empresa.NomeDaEmpresa}.txt"))
            {
                writer.WriteLine("CADASTRO DA EMPRESA");
                writer.WriteLine($"\nCÓDIGO DA EMPRESA.....: {empresa.CodigoDaEmpresa}");
                writer.WriteLine($"NOME DA EMPRESA.........: {empresa.NomeDaEmpresa}");
                writer.WriteLine($"CNPJ....................: {empresa.CNPJ}");
                writer.WriteLine($"LOGRADOURO..............: {empresa.Endereco.Logradouro}");
                writer.WriteLine($"NUMERO..................: {empresa.Endereco.Numero}");
                writer.WriteLine($"BAIRRO..................: {empresa.Endereco.Bairro}");
                writer.WriteLine($"CIDADE..................: {empresa.Endereco.Cidade}");
                writer.WriteLine($"ESTADO..................: {empresa.Endereco.Estado}");
                writer.WriteLine($"CEP.....................: {String.Format("{0:#####-###}", Convert.ToInt64(empresa.Endereco.CEP))}");
                writer.WriteLine($"CONTATO TELEFONINCO FIXO: {String.Format("{0:(##) ####-####}",Convert.ToInt64(empresa.Contato.NumeroFixo))}");
                writer.WriteLine($"CONTATO TELEFONICO CEL..: {String.Format("{0:(##) #####-####}", Convert.ToInt64(empresa.Contato.NumeroCel))}");
                writer.WriteLine($"CONTATO POR EMAIL.......: {empresa.Contato.Email}");


            }


        }
    }
}
