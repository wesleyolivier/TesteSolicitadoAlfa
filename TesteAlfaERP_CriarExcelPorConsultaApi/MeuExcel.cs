using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAlfaERP_CriarExcelPorConsultaApi
{
    public static class MeuExcel
    {
        private static string caminho = @"C:\temp\teste.csv";
        
        public static void Gerar(DadosContato dadosContato) 
        {
            Console.WriteLine($"Caminho para geração do arquivo: {caminho}");
            var builder = new StringBuilder();
            builder.AppendLine("uuid;email;name;job_title");
            builder.AppendLine(dadosContato.uuid + ";" + dadosContato.email + ";" + dadosContato.name + ";" + dadosContato.job_title);
            File.WriteAllText(caminho, builder.ToString());
        }
    }
}
