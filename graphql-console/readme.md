``` cmd 
dotnet tool install StrawberryShake.Tools --version 12.0.0-preview.1 --local

dotnet add package StrawberryShake.Transport.Http --version 12.0.0-preview.1

dotnet add package StrawberryShake.CodeGeneration.CSharp.Analyzers --version 12.0.0-preview.1

dotnet add package Microsoft.Extensions.DependencyInjection

dotnet add package Microsoft.Extensions.Http
```

``` cmd
dotnet graphql init https://localhost:44339/graphql -n StarWarsClient -p ./StarWars
```