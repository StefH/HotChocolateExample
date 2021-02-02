using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace graphql_console
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero
        : IGetHero
    {
        public GetHero(
            global::graphql_console.ICharacter hero)
        {
            Hero = hero;
        }

        public global::graphql_console.ICharacter Hero { get; }
    }
}
