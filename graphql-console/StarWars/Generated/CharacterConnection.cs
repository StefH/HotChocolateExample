using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace graphql_console
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CharacterConnection
        : ICharacterConnection
    {
        public CharacterConnection(
            global::System.Collections.Generic.IReadOnlyList<global::graphql_console.ICharacterEdge> edges, 
            int totalCount)
        {
            Edges = edges;
            TotalCount = totalCount;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::graphql_console.ICharacterEdge> Edges { get; }

        public int TotalCount { get; }
    }
}
