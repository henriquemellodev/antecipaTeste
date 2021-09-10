using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace TesteAntecipa
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            // Capturar o valor do Status: available, pending, sold
            string status = Console.ReadLine().Trim();

            // Endpoint
            client.BaseAddress = new Uri("https://petstore.swagger.io/v2/pet/findByStatus?status=available");
            
            // Limpar Cabeçalho
            client.DefaultRequestHeaders.Accept.Clear();

            // Adicionar o valor no Cabeçalho
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

            // Requisição GET
            var request = client.GetStreamAsync("?status=" + status);

            // Deserialização do JSON, transformando na lista do Objeto PET
            var listPet = await JsonSerializer.DeserializeAsync<List<Pet>>(await request);

            // Imprimir Requisição ID + Nome

            foreach (var print in listPet)
                Console.WriteLine("ID: " + print.Id + " Name: " + print.Name);
        }
    }
}
