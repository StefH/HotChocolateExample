using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace graphql_console
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CharacterEdge
        : ICharacterEdge
    {
        public CharacterEdge(
            global::graphql_console.ICharacter1 node)
        {
            Node = node;
        }

        public global::graphql_console.ICharacter1 Node { get; }
    }
}
