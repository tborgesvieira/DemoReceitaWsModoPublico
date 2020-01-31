using Newtonsoft.Json;
using ReceitaWs.Helpers;
using ReceitaWs.View;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReceitaWs
{
    class Program
    {
        private static readonly HttpClient _client = new HttpClient();
        static async Task Main(string[] args)
        {
            Console.Write("Informe o CNPJ: ");

            var cnpj = Console.ReadLine().LimparCnpj();        

            if (ValidarCnpj(cnpj))
            {
                var receitaws = await _client.GetStringAsync($"http://receitaws.com.br/v1/cnpj/{cnpj}");

                var empresa = JsonConvert.DeserializeObject<Empresa>(receitaws);

                Console.WriteLine($"Nome: {empresa.Nome}");

                Console.WriteLine($"Telefone: {empresa.Telefone}");
            }
            else
            {
                Console.WriteLine("CNPJ incorreto!");
            }

            Console.WriteLine("--------------------------------------------------------------------");
        }

        private static bool ValidarCnpj(string cnpj)
        {
            return cnpj.Length.Equals(14);
        }        
    }
}
