using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake;

namespace graphql_console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddHttpClient(
                "StarWarsClient",
                c => c.BaseAddress = new Uri("http://localhost:56098/graphql"));
            serviceCollection.AddStarWarsClient();

            IServiceProvider services = serviceCollection.BuildServiceProvider();
            IStarWarsClient client = services.GetRequiredService<IStarWarsClient>();



            IOperationResult<IGetHero> heroResult = await client.GetHeroAsync(Episode.Empire);

            var heroAsJson = JsonSerializer.Serialize(heroResult.Data.Hero, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(heroAsJson);

            var charactersByIdsResult = await client.GetCharactersAsync(new[] { 1000, 2000});

            var charactersByIdsJson = JsonSerializer.Serialize(charactersByIdsResult.Data.Character, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(charactersByIdsJson);
        }
    }
}