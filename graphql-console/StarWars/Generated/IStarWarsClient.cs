using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace graphql_console
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IStarWarsClient
    {
        Task<IOperationResult<global::graphql_console.IGetHero>> GetHeroAsync(
            Optional<Episode> episode = default,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::graphql_console.IGetHero>> GetHeroAsync(
            GetHeroOperation operation,
            CancellationToken cancellationToken = default);
    }
}
