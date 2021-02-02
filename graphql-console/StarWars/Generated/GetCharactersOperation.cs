using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace graphql_console
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetCharactersOperation
        : IOperation<IGetCharacters>
    {
        public string Name => "GetCharacters";

        public IDocument Document => Queries.Default;

        public OperationKind Kind => OperationKind.Query;

        public Type ResultType => typeof(IGetCharacters);

        public Optional<IReadOnlyList<int>> Ids { get; set; }

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            var variables = new List<VariableValue>();

            if (Ids.HasValue)
            {
                variables.Add(new VariableValue("ids", "Int", Ids.Value));
            }

            return variables;
        }
    }
}
