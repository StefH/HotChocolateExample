using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace graphql_console
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetCharacters
        : IGetCharacters
    {
        public GetCharacters(
            global::System.Collections.Generic.IReadOnlyList<global::graphql_console.ICharacter2> character)
        {
            Character = character;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::graphql_console.ICharacter2> Character { get; }
    }
}
