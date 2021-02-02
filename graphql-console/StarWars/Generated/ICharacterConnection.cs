using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace graphql_console
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface ICharacterConnection
    {
        global::System.Collections.Generic.IReadOnlyList<global::graphql_console.ICharacterEdge> Edges { get; }

        int TotalCount { get; }
    }
}
