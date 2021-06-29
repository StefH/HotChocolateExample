using HotChocolate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StarWars.Characters;
using StarWars.Repositories;
using StarWars.Reviews;

namespace StarWars
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Add the custom services like repositories etc ...
            services.AddSingleton<ICharacterRepository, CharacterRepository>();
            services.AddSingleton<IReviewRepository, ReviewRepository>();

            // Add in-memory event provider
            // services.AddInMemorySubscriptionProvider();
            services.AddInMemorySubscriptions();

            // Add GraphQL Services
            services.AddGraphQLServer()
                .AddQueryType(d => d.Name("Query"))
                .AddMutationType(d => d.Name("Mutation"))
                .AddSubscriptionType(d => d.Name("Subscription"))

                // No default filter convention found. Call `AddFiltering()` on the schema builder. (HotChocolate.Types.ObjectTypeExtension<StarWars.Characters.CharacterQueries>)
                .AddFiltering()

                // No default sorting convention found. Call `AddSorting()` on the schema builder. (HotChocolate.Types.ObjectTypeExtension<StarWars.Characters.CharacterQueries>)
                .AddSorting()

                .AddType<CharacterQueries>()
                .AddType<ReviewMutations>()
                .AddType<ReviewSubscriptions>()

                // A Union type must define one or more unique member types. (HotChocolate.Types.UnionType<StarWars.Characters.ISearchResult>)
                .AddType<Human>()
                .AddType<Droid>()
                .AddType<Starship>()
                ;

            //services.AddGraphQL(sp => SchemaBuilder.New()
            //    .AddServices(sp)
            //    .AddQueryType(d => d.Name("Query"))
            //    .AddMutationType(d => d.Name("Mutation"))
            //    .AddSubscriptionType(d => d.Name("Subscription"))
            //    .AddType<CharacterQueries>()
            //    .AddType<ReviewQueries>()
            //    .AddType<ReviewMutations>()
            //    .AddType<ReviewSubscriptions>()
            //    .AddType<Human>()
            //    .AddType<Droid>()
            //    .AddType<Starship>()
            //    .Create());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
                .UseRouting()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapGraphQL("/graphql");
                });
        }
    }
}