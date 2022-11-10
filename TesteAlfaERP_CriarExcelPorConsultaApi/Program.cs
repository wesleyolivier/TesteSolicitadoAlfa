// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using TesteAlfaERP_CriarExcelPorConsultaApi;

Console.WriteLine("Iniciando...");

try
{    
    var respostaWebApiRD = MeuProxy.ChamarApiRD();
    var objetoDeserealizado = JsonSerializer.Deserialize<DadosContato>(respostaWebApiRD);    
    MeuExcel.Gerar(objetoDeserealizado);
    Console.WriteLine("Arquivo gerado.");
    Console.WriteLine("Fim.");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("Erro : " + ex.Message);
}