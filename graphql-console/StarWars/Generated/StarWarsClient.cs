using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace graphql_console
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class StarWarsClient
        : IStarWarsClient
    {
        private const string _clientName = "StarWarsClient";

        private readonly global::StrawberryShake.IOperationExecutor _executor;

        public StarWarsClient(global::StrawberryShake.IOperationExecutorPool executorPool)
        {
            _executor = executorPool.CreateExecutor(_clientName);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::graphql_console.IGetHero>> GetHeroAsync(
            global::StrawberryShake.Optional<Episode> episode = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            return _executor.ExecuteAsync(
                new GetHeroOperation { Episode = episode },
                cancellationToken);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::graphql_console.IGetHero>> GetHeroAsync(
            GetHeroOperation operation,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::graphql_console.IGetCharacters>> GetCharactersAsync(
            global::StrawberryShake.Optional<IReadOnlyList<int>> ids = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (ids.HasValue && ids.Value is null)
            {
                throw new ArgumentNullException(nameof(ids));
            }

            return _executor.ExecuteAsync(
                new GetCharactersOperation { Ids = ids },
                cancellationToken);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::graphql_console.IGetCharacters>> GetCharactersAsync(
            GetCharactersOperation operation,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }
    }
}
