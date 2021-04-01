using System;
using System.Text.Json;
using System.Threading.Tasks;
using graphql_console.StarWarsClient;
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
                c => c.BaseAddress = new Uri("https://localhost:44339/graphql"));
            serviceCollection.AddStarWarsClient();

            IServiceProvider services = serviceCollection.BuildServiceProvider();
            IStarWarsClient client = services.GetRequiredService<IStarWarsClient>();
            
            var getHeroResult = await client.GetHero.ExecuteAsync(Episode.Empire);

            var heroAsJson = JsonSerializer.Serialize(getHeroResult.Data.Hero, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(heroAsJson);

            var charactersByIdsResult = await client.GetCharacters.ExecuteAsync(new[] { 1000, 2000});

            var charactersByIdsJson = JsonSerializer.Serialize(charactersByIdsResult.Data.Character, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(charactersByIdsJson);
        }
    }
}