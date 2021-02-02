using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace graphql_console
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Character
        : ICharacter
    {
        public Character(
            int id, 
            string name, 
            global::graphql_console.ICharacterConnection friends)
        {
            Id = id;
            Name = name;
            Friends = friends;
        }

        public int Id { get; }

        public string Name { get; }

        public global::graphql_console.ICharacterConnection Friends { get; }
    }
}
