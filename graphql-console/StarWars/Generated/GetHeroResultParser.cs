using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Configuration;
using StrawberryShake.Http;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Transport;

namespace graphql_console
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroResultParser
        : JsonResultParserBase<IGetHero>
    {
        private readonly IValueSerializer _intSerializer;
        private readonly IValueSerializer _stringSerializer;

        public GetHeroResultParser(IValueSerializerCollection serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _intSerializer = serializerResolver.Get("Int");
            _stringSerializer = serializerResolver.Get("String");
        }

        protected override IGetHero ParserData(JsonElement data)
        {
            return new GetHero
            (
                ParseGetHeroHero(data, "hero")
            );

        }

        private global::graphql_console.ICharacter ParseGetHeroHero(
            JsonElement parent,
            string field)
        {
            JsonElement obj = parent.GetProperty(field);

            return new Character
            (
                DeserializeInt(obj, "id"),
                DeserializeString(obj, "name"),
                ParseGetHeroHeroFriends(obj, "friends")
            );
        }

        private global::graphql_console.ICharacterConnection ParseGetHeroHeroFriends(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return new CharacterConnection
            (
                ParseGetHeroHeroFriendsEdges(obj, "edges"),
                DeserializeInt(obj, "totalCount")
            );
        }

        private global::System.Collections.Generic.IReadOnlyList<global::graphql_console.ICharacterEdge> ParseGetHeroHeroFriendsEdges(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            int objLength = obj.GetArrayLength();
            var list = new global::graphql_console.ICharacterEdge[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new CharacterEdge
                (
                    ParseGetHeroHeroFriendsEdgesNode(element, "node")
                );

            }

            return list;
        }

        private global::graphql_console.ICharacter1 ParseGetHeroHeroFriendsEdgesNode(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return new Character1
            (
                DeserializeString(obj, "name")
            );
        }

        private int DeserializeInt(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (int)_intSerializer.Deserialize(value.GetInt32());
        }

        private string DeserializeString(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (string)_stringSerializer.Deserialize(value.GetString());
        }
    }
}
