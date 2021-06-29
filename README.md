# StarWars
Creates a GraphQL StarWars Demo
- `dotnet new --install "HotChocolate.Templates.StarWars"`
- `dotnet new starwars`


## Always
``` cmd
cd StarWarsGeneratedClient
```

## First time
- `dotnet new tool-manifest`

- `dotnet tool install StrawberryShake.Tools --version 12.0.0-preview.19 --local`

- `dotnet add package StrawberryShake.Transport.Http --version 12.0.0-preview.19`

- `dotnet add package StrawberryShake.CodeGeneration.CSharp.Analyzers --version 12.0.0-preview.19`

- `dotnet add package Microsoft.Extensions.DependencyInjection`

- `dotnet add package Microsoft.Extensions.Http`

- Make sure the server is running

- `dotnet graphql init https://localhost:44339/starwars -n StarWarsGeneratedClient -p GraphQL`

- Add `Queries.graphql` to the `GraphQL` folder

- Build the StarWarsGeneratedClient project


## Updates to queries / schema
- Make sure the server is running

- `dotnet graphql init https://localhost:44339/starwars -n StarWarsGeneratedClient -p GraphQL`

- Update `Queries.graphql` in the `GraphQL` folder

- Build the StarWarsGeneratedClient project