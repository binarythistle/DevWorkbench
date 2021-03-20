using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DevWorkBench.Models;

namespace DevWorkBench.DataServices
{
    public class CommandDataService : ICommandDataService
    {
        private readonly HttpClient _httpClient;

        public CommandDataService(HttpClient httpCLient)
        {
            _httpClient = httpCLient;
        }

        public async Task<Command[]> GetAllCommandsGraphQL()
        {
            var queryObject = new{
                query = @"query{command{id howTo commandLine platform{name}}}",
                variables = new { }
            };

            var commandQuery = new StringContent(
                JsonSerializer.Serialize(queryObject),
                Encoding.UTF8,
                "application/json");
            
            var response = await _httpClient.PostAsync("graphql", commandQuery);

            if (response.IsSuccessStatusCode)
            {
                var gqlData = await JsonSerializer.DeserializeAsync<GQLData>(await response.Content.ReadAsStreamAsync());

                return gqlData.Data.Commands;
            }

            return null;
        }

        public async Task<Command[]> GetSelectedCommandsGraphQL(string cmdQuery)
        {
            var queryObject = new{
                query = "query{command(where: {howTo : {contains: \"" + cmdQuery + "\"}}){id howTo commandLine platform{name}}}",
                variables = new { }
            };

            Console.WriteLine($"-> Formulated query: {queryObject.query}");

            var commandQuery = new StringContent(
                JsonSerializer.Serialize(queryObject),
                Encoding.UTF8,
                "application/json");
            
            var response = await _httpClient.PostAsync("graphql", commandQuery);

            if (response.IsSuccessStatusCode)
            {
                var gqlData = await JsonSerializer.DeserializeAsync<GQLData>(await response.Content.ReadAsStreamAsync());

                return gqlData.Data.Commands;
            }

            return null;
        }
    }
}