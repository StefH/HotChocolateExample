using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace graphql_console
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Queries
        : global::StrawberryShake.IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            50,
            98,
            54,
            102,
            49,
            55,
            99,
            52,
            57,
            49,
            57,
            55,
            100,
            100,
            50,
            99,
            57,
            57,
            57,
            55,
            55,
            49,
            97,
            49,
            51,
            101,
            56,
            97,
            51,
            101,
            55,
            51
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            103,
            101,
            116,
            72,
            101,
            114,
            111,
            40,
            36,
            101,
            112,
            105,
            115,
            111,
            100,
            101,
            58,
            32,
            69,
            112,
            105,
            115,
            111,
            100,
            101,
            33,
            41,
            32,
            123,
            32,
            104,
            101,
            114,
            111,
            40,
            101,
            112,
            105,
            115,
            111,
            100,
            101,
            58,
            32,
            36,
            101,
            112,
            105,
            115,
            111,
            100,
            101,
            41,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            105,
            100,
            32,
            110,
            97,
            109,
            101,
            32,
            102,
            114,
            105,
            101,
            110,
            100,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            101,
            100,
            103,
            101,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            111,
            100,
            101,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            97,
            109,
            101,
            32,
            125,
            32,
            125,
            32,
            116,
            111,
            116,
            97,
            108,
            67,
            111,
            117,
            110,
            116,
            32,
            125,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query getHero($episode: Episode!) {
              hero(episode: $episode) {
                id
                name
                friends {
                  edges {
                    node {
                      name
                    }
                  }
                  totalCount
                }
              }
            }";
    }
}
