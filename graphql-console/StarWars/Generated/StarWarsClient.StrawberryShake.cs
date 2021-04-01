// HumanEntity.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    /// <summary>
    /// A human character in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class HumanEntity
    {
        public HumanEntity(
            global::System.Int32 id,
            global::System.String name,
            global::graphql_console.StarWarsClient.State.CharacterConnectionData? friends)
        {
            Id = id;
            Name = name;
            Friends = friends;
        }

        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public global::System.Int32 Id { get; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public global::System.String Name { get; }

        /// <summary>
        /// The ids of the character's friends.
        /// </summary>
        public global::graphql_console.StarWarsClient.State.CharacterConnectionData? Friends { get; }
    }
}


// DroidEntity.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    /// <summary>
    /// A droid in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class DroidEntity
    {
        public DroidEntity(
            global::System.Int32 id,
            global::System.String name,
            global::graphql_console.StarWarsClient.State.CharacterConnectionData? friends)
        {
            Id = id;
            Name = name;
            Friends = friends;
        }

        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public global::System.Int32 Id { get; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public global::System.String Name { get; }

        /// <summary>
        /// The ids of the character's friends.
        /// </summary>
        public global::graphql_console.StarWarsClient.State.CharacterConnectionData? Friends { get; }
    }
}


// GetHeroResultFactory.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHeroResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::graphql_console.StarWarsClient.GetHeroResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, GetHero_Hero_Human> _getHero_Hero_HumanFromHumanEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, GetHero_Hero_Droid> _getHero_Hero_DroidFromDroidEntityMapper;

        public GetHeroResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, GetHero_Hero_Human> getHero_Hero_HumanFromHumanEntityMapper,
            global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, GetHero_Hero_Droid> getHero_Hero_DroidFromDroidEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getHero_Hero_HumanFromHumanEntityMapper = getHero_Hero_HumanFromHumanEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_HumanFromHumanEntityMapper));
            _getHero_Hero_DroidFromDroidEntityMapper = getHero_Hero_DroidFromDroidEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_DroidFromDroidEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::graphql_console.StarWarsClient.IGetHeroResult);

        public GetHeroResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetHeroResultInfo info)
            {
                return new GetHeroResult(MapNonNullableIGetHero_Hero(
                    info.Hero,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetHeroResultInfo expected.");
        }

        private global::graphql_console.StarWarsClient.IGetHero_Hero MapNonNullableIGetHero_Hero(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Human",
                    global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_HumanFromHumanEntityMapper.Map(
                    snapshot.GetEntity<global::graphql_console.StarWarsClient.State.HumanEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }

            if (entityId.Name.Equals(
                    "Droid",
                    global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_DroidFromDroidEntityMapper.Map(
                    snapshot.GetEntity<global::graphql_console.StarWarsClient.State.DroidEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetHeroResultInfo.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHeroResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetHeroResultInfo(
            global::StrawberryShake.EntityId hero,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Hero = hero;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        /// <summary>
        /// Retrieve a hero by a particular Star Wars episode.
        /// </summary>
        public global::StrawberryShake.EntityId Hero { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetHeroResultInfo(
                Hero,
                _entityIds,
                version);
        }
    }
}


// GetHeroResult.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHeroResult
        : global::System.IEquatable<GetHeroResult>
        , IGetHeroResult
    {
        public GetHeroResult(global::graphql_console.StarWarsClient.IGetHero_Hero hero)
        {
            Hero = hero;
        }

        /// <summary>
        /// Retrieve a hero by a particular Star Wars episode.
        /// </summary>
        public global::graphql_console.StarWarsClient.IGetHero_Hero Hero { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetHeroResult)obj);
        }

        public global::System.Boolean Equals(GetHeroResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Hero.Equals(other.Hero));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Hero.GetHashCode();

                return hash;
            }
        }
    }
}


// GetHero_Hero_HumanFromHumanEntityMapper.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHero_Hero_HumanFromHumanEntityMapper
        : global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, GetHero_Hero_Human>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, GetHero_Hero_Friends_Edges_Node_Human> _getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, GetHero_Hero_Friends_Edges_Node_Droid> _getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper;

        public GetHero_Hero_HumanFromHumanEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, GetHero_Hero_Friends_Edges_Node_Human> getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper,
            global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, GetHero_Hero_Friends_Edges_Node_Droid> getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper = getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper));
            _getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper = getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper));
        }

        public GetHero_Hero_Human Map(
            global::graphql_console.StarWarsClient.State.HumanEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetHero_Hero_Human(
                entity.Id,
                entity.Name,
                MapIGetHero_Hero_Friends(
                    entity.Friends,
                    snapshot));
        }

        private global::graphql_console.StarWarsClient.IGetHero_Hero_Friends? MapIGetHero_Hero_Friends(
            global::graphql_console.StarWarsClient.State.CharacterConnectionData? data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetHero_Hero_Friends returnValue = default!;

            if (data?.__typename.Equals(
                    "CharacterConnection",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetHero_Hero_Friends_CharacterConnection(
                    MapIGetHero_Hero_Friends_EdgesNonNullableArray(
                        data.Edges,
                        snapshot),
                    data.TotalCount ?? throw new global::System.ArgumentNullException());
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges>? MapIGetHero_Hero_Friends_EdgesNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.State.CharacterEdgeData>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var characterEdges = new global::System.Collections.Generic.List<global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges>();

            foreach (global::graphql_console.StarWarsClient.State.CharacterEdgeData child in list)
            {
                characterEdges.Add(MapNonNullableIGetHero_Hero_Friends_Edges(
                    child,
                    snapshot));
            }

            return characterEdges;
        }

        private global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges MapNonNullableIGetHero_Hero_Friends_Edges(
            global::graphql_console.StarWarsClient.State.CharacterEdgeData data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetHero_Hero_Friends_Edges returnValue = default!;

            if (data.__typename.Equals(
                    "CharacterEdge",
                    global::System.StringComparison.Ordinal))
            {
                returnValue = new GetHero_Hero_Friends_Edges_CharacterEdge(MapIGetHero_Hero_Friends_Edges_Node(
                    data.Node,
                    snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges_Node? MapIGetHero_Hero_Friends_Edges_Node(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Human",
                    global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper.Map(
                    snapshot.GetEntity<global::graphql_console.StarWarsClient.State.HumanEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }

            if (entityId.Value.Name.Equals(
                    "Droid",
                    global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper.Map(
                    snapshot.GetEntity<global::graphql_console.StarWarsClient.State.DroidEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetHero_Hero_Human.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A human character in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHero_Hero_Human
        : global::System.IEquatable<GetHero_Hero_Human>
        , IGetHero_Hero_Human
    {
        public GetHero_Hero_Human(
            global::System.Int32 id,
            global::System.String name,
            global::graphql_console.StarWarsClient.IGetHero_Hero_Friends? friends)
        {
            Id = id;
            Name = name;
            Friends = friends;
        }

        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public global::System.Int32 Id { get; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public global::System.String Name { get; }

        /// <summary>
        /// The ids of the character's friends.
        /// </summary>
        public global::graphql_console.StarWarsClient.IGetHero_Hero_Friends? Friends { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetHero_Hero_Human)obj);
        }

        public global::System.Boolean Equals(GetHero_Hero_Human? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name)
                && ((Friends is null && other.Friends is null) ||Friends != null && Friends.Equals(other.Friends));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                if (!(Friends is null))
                {
                    hash ^= 397 * Friends.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetHero_Hero_DroidFromDroidEntityMapper.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHero_Hero_DroidFromDroidEntityMapper
        : global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, GetHero_Hero_Droid>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, GetHero_Hero_Friends_Edges_Node_Human> _getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, GetHero_Hero_Friends_Edges_Node_Droid> _getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper;

        public GetHero_Hero_DroidFromDroidEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, GetHero_Hero_Friends_Edges_Node_Human> getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper,
            global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, GetHero_Hero_Friends_Edges_Node_Droid> getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper = getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper));
            _getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper = getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper));
        }

        public GetHero_Hero_Droid Map(
            global::graphql_console.StarWarsClient.State.DroidEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetHero_Hero_Droid(
                entity.Id,
                entity.Name,
                MapIGetHero_Hero_Friends(
                    entity.Friends,
                    snapshot));
        }

        private global::graphql_console.StarWarsClient.IGetHero_Hero_Friends? MapIGetHero_Hero_Friends(
            global::graphql_console.StarWarsClient.State.CharacterConnectionData? data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetHero_Hero_Friends returnValue = default!;

            if (data?.__typename.Equals(
                    "CharacterConnection",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetHero_Hero_Friends_CharacterConnection(
                    MapIGetHero_Hero_Friends_EdgesNonNullableArray(
                        data.Edges,
                        snapshot),
                    data.TotalCount ?? throw new global::System.ArgumentNullException());
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges>? MapIGetHero_Hero_Friends_EdgesNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.State.CharacterEdgeData>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var characterEdges = new global::System.Collections.Generic.List<global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges>();

            foreach (global::graphql_console.StarWarsClient.State.CharacterEdgeData child in list)
            {
                characterEdges.Add(MapNonNullableIGetHero_Hero_Friends_Edges(
                    child,
                    snapshot));
            }

            return characterEdges;
        }

        private global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges MapNonNullableIGetHero_Hero_Friends_Edges(
            global::graphql_console.StarWarsClient.State.CharacterEdgeData data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            IGetHero_Hero_Friends_Edges returnValue = default!;

            if (data.__typename.Equals(
                    "CharacterEdge",
                    global::System.StringComparison.Ordinal))
            {
                returnValue = new GetHero_Hero_Friends_Edges_CharacterEdge(MapIGetHero_Hero_Friends_Edges_Node(
                    data.Node,
                    snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges_Node? MapIGetHero_Hero_Friends_Edges_Node(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Human",
                    global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper.Map(
                    snapshot.GetEntity<global::graphql_console.StarWarsClient.State.HumanEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }

            if (entityId.Value.Name.Equals(
                    "Droid",
                    global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper.Map(
                    snapshot.GetEntity<global::graphql_console.StarWarsClient.State.DroidEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetHero_Hero_Droid.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A droid in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHero_Hero_Droid
        : global::System.IEquatable<GetHero_Hero_Droid>
        , IGetHero_Hero_Droid
    {
        public GetHero_Hero_Droid(
            global::System.Int32 id,
            global::System.String name,
            global::graphql_console.StarWarsClient.IGetHero_Hero_Friends? friends)
        {
            Id = id;
            Name = name;
            Friends = friends;
        }

        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public global::System.Int32 Id { get; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public global::System.String Name { get; }

        /// <summary>
        /// The ids of the character's friends.
        /// </summary>
        public global::graphql_console.StarWarsClient.IGetHero_Hero_Friends? Friends { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetHero_Hero_Droid)obj);
        }

        public global::System.Boolean Equals(GetHero_Hero_Droid? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name)
                && ((Friends is null && other.Friends is null) ||Friends != null && Friends.Equals(other.Friends));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                if (!(Friends is null))
                {
                    hash ^= 397 * Friends.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetHero_Hero_Friends_CharacterConnection.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHero_Hero_Friends_CharacterConnection
        : global::System.IEquatable<GetHero_Hero_Friends_CharacterConnection>
        , IGetHero_Hero_Friends_CharacterConnection
    {
        public GetHero_Hero_Friends_CharacterConnection(
            global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges>? edges,
            global::System.Int32 totalCount)
        {
            Edges = edges;
            TotalCount = totalCount;
        }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges>? Edges { get; }

        public global::System.Int32 TotalCount { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetHero_Hero_Friends_CharacterConnection)obj);
        }

        public global::System.Boolean Equals(GetHero_Hero_Friends_CharacterConnection? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Edges,
                        other.Edges))
                && TotalCount == other.TotalCount;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Edges is null))
                {
                    foreach (var Edges_elm in Edges)
                    {
                        hash ^= 397 * Edges_elm.GetHashCode();
                    }
                }

                hash ^= 397 * TotalCount.GetHashCode();

                return hash;
            }
        }
    }
}


// GetHero_Hero_Friends_Edges_CharacterEdge.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// An edge in a connection.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHero_Hero_Friends_Edges_CharacterEdge
        : global::System.IEquatable<GetHero_Hero_Friends_Edges_CharacterEdge>
        , IGetHero_Hero_Friends_Edges_CharacterEdge
    {
        public GetHero_Hero_Friends_Edges_CharacterEdge(global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges_Node? node)
        {
            Node = node;
        }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges_Node? Node { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetHero_Hero_Friends_Edges_CharacterEdge)obj);
        }

        public global::System.Boolean Equals(GetHero_Hero_Friends_Edges_CharacterEdge? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Node is null && other.Node is null) ||Node != null && Node.Equals(other.Node)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Node is null))
                {
                    hash ^= 397 * Node.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper
        : global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, GetHero_Hero_Friends_Edges_Node_Human>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;

        public GetHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public GetHero_Hero_Friends_Edges_Node_Human Map(
            global::graphql_console.StarWarsClient.State.HumanEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetHero_Hero_Friends_Edges_Node_Human(
                entity.Id,
                entity.Name);
        }
    }
}


// GetHero_Hero_Friends_Edges_Node_Human.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A human character in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHero_Hero_Friends_Edges_Node_Human
        : global::System.IEquatable<GetHero_Hero_Friends_Edges_Node_Human>
        , IGetHero_Hero_Friends_Edges_Node_Human
    {
        public GetHero_Hero_Friends_Edges_Node_Human(
            global::System.Int32 id,
            global::System.String name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public global::System.Int32 Id { get; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public global::System.String Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetHero_Hero_Friends_Edges_Node_Human)obj);
        }

        public global::System.Boolean Equals(GetHero_Hero_Friends_Edges_Node_Human? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                return hash;
            }
        }
    }
}


// GetHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper
        : global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, GetHero_Hero_Friends_Edges_Node_Droid>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;

        public GetHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public GetHero_Hero_Friends_Edges_Node_Droid Map(
            global::graphql_console.StarWarsClient.State.DroidEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetHero_Hero_Friends_Edges_Node_Droid(
                entity.Id,
                entity.Name);
        }
    }
}


// GetHero_Hero_Friends_Edges_Node_Droid.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A droid in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHero_Hero_Friends_Edges_Node_Droid
        : global::System.IEquatable<GetHero_Hero_Friends_Edges_Node_Droid>
        , IGetHero_Hero_Friends_Edges_Node_Droid
    {
        public GetHero_Hero_Friends_Edges_Node_Droid(
            global::System.Int32 id,
            global::System.String name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public global::System.Int32 Id { get; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public global::System.String Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetHero_Hero_Friends_Edges_Node_Droid)obj);
        }

        public global::System.Boolean Equals(GetHero_Hero_Friends_Edges_Node_Droid? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetHeroResult.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHeroResult
    {
        /// <summary>
        /// Retrieve a hero by a particular Star Wars episode.
        /// </summary>
        public global::graphql_console.StarWarsClient.IGetHero_Hero Hero { get; }
    }
}


// IGetHero_Hero.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A character in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHero_Hero
    {
        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public global::System.Int32 Id { get; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public global::System.String Name { get; }

        /// <summary>
        /// The ids of the character's friends.
        /// </summary>
        public global::graphql_console.StarWarsClient.IGetHero_Hero_Friends? Friends { get; }
    }
}


// IGetHero_Hero_Human.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A human character in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHero_Hero_Human
        : IGetHero_Hero
    {
    }
}


// IGetHero_Hero_Droid.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A droid in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHero_Hero_Droid
        : IGetHero_Hero
    {
    }
}


// IGetHero_Hero_Friends.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHero_Hero_Friends
    {
        /// <summary>
        /// A list of edges.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges>? Edges { get; }

        public global::System.Int32 TotalCount { get; }
    }
}


// IGetHero_Hero_Friends_CharacterConnection.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHero_Hero_Friends_CharacterConnection
        : IGetHero_Hero_Friends
    {
    }
}


// IGetHero_Hero_Friends_Edges.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// An edge in a connection.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHero_Hero_Friends_Edges
    {
        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public global::graphql_console.StarWarsClient.IGetHero_Hero_Friends_Edges_Node? Node { get; }
    }
}


// IGetHero_Hero_Friends_Edges_CharacterEdge.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// An edge in a connection.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHero_Hero_Friends_Edges_CharacterEdge
        : IGetHero_Hero_Friends_Edges
    {
    }
}


// IGetHero_Hero_Friends_Edges_Node.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A character in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHero_Hero_Friends_Edges_Node
    {
        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public global::System.Int32 Id { get; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public global::System.String Name { get; }
    }
}


// IGetHero_Hero_Friends_Edges_Node_Human.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A human character in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHero_Hero_Friends_Edges_Node_Human
        : IGetHero_Hero_Friends_Edges_Node
    {
    }
}


// IGetHero_Hero_Friends_Edges_Node_Droid.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A droid in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHero_Hero_Friends_Edges_Node_Droid
        : IGetHero_Hero_Friends_Edges_Node
    {
    }
}


// GetCharactersResultFactory.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetCharactersResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::graphql_console.StarWarsClient.GetCharactersResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, GetCharacters_Character_Human> _getCharacters_Character_HumanFromHumanEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, GetCharacters_Character_Droid> _getCharacters_Character_DroidFromDroidEntityMapper;

        public GetCharactersResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, GetCharacters_Character_Human> getCharacters_Character_HumanFromHumanEntityMapper,
            global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, GetCharacters_Character_Droid> getCharacters_Character_DroidFromDroidEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getCharacters_Character_HumanFromHumanEntityMapper = getCharacters_Character_HumanFromHumanEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getCharacters_Character_HumanFromHumanEntityMapper));
            _getCharacters_Character_DroidFromDroidEntityMapper = getCharacters_Character_DroidFromDroidEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getCharacters_Character_DroidFromDroidEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::graphql_console.StarWarsClient.IGetCharactersResult);

        public GetCharactersResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetCharactersResultInfo info)
            {
                return new GetCharactersResult(MapNonNullableIGetCharacters_CharacterNonNullableArray(
                    info.Character,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetCharactersResultInfo expected.");
        }

        private global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.IGetCharacters_Character> MapNonNullableIGetCharacters_CharacterNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                throw new global::System.ArgumentNullException();
            }

            var characters = new global::System.Collections.Generic.List<global::graphql_console.StarWarsClient.IGetCharacters_Character>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                characters.Add(MapNonNullableIGetCharacters_Character(
                    child,
                    snapshot));
            }

            return characters;
        }

        private global::graphql_console.StarWarsClient.IGetCharacters_Character MapNonNullableIGetCharacters_Character(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Human",
                    global::System.StringComparison.Ordinal))
            {
                return _getCharacters_Character_HumanFromHumanEntityMapper.Map(
                    snapshot.GetEntity<global::graphql_console.StarWarsClient.State.HumanEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }

            if (entityId.Name.Equals(
                    "Droid",
                    global::System.StringComparison.Ordinal))
            {
                return _getCharacters_Character_DroidFromDroidEntityMapper.Map(
                    snapshot.GetEntity<global::graphql_console.StarWarsClient.State.DroidEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetCharactersResultInfo.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetCharactersResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetCharactersResultInfo(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> character,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Character = character;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        /// <summary>
        /// Gets a character by it`s id.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> Character { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetCharactersResultInfo(
                Character,
                _entityIds,
                version);
        }
    }
}


// GetCharactersResult.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetCharactersResult
        : global::System.IEquatable<GetCharactersResult>
        , IGetCharactersResult
    {
        public GetCharactersResult(global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.IGetCharacters_Character> character)
        {
            Character = character;
        }

        /// <summary>
        /// Gets a character by it`s id.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.IGetCharacters_Character> Character { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetCharactersResult)obj);
        }

        public global::System.Boolean Equals(GetCharactersResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Character,
                        other.Character));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                foreach (var Character_elm in Character)
                {
                    hash ^= 397 * Character_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetCharacters_Character_HumanFromHumanEntityMapper.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetCharacters_Character_HumanFromHumanEntityMapper
        : global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, GetCharacters_Character_Human>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;

        public GetCharacters_Character_HumanFromHumanEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public GetCharacters_Character_Human Map(
            global::graphql_console.StarWarsClient.State.HumanEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetCharacters_Character_Human(
                entity.Id,
                entity.Name);
        }
    }
}


// GetCharacters_Character_Human.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A human character in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetCharacters_Character_Human
        : global::System.IEquatable<GetCharacters_Character_Human>
        , IGetCharacters_Character_Human
    {
        public GetCharacters_Character_Human(
            global::System.Int32 id,
            global::System.String name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public global::System.Int32 Id { get; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public global::System.String Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetCharacters_Character_Human)obj);
        }

        public global::System.Boolean Equals(GetCharacters_Character_Human? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                return hash;
            }
        }
    }
}


// GetCharacters_Character_DroidFromDroidEntityMapper.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetCharacters_Character_DroidFromDroidEntityMapper
        : global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, GetCharacters_Character_Droid>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;

        public GetCharacters_Character_DroidFromDroidEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public GetCharacters_Character_Droid Map(
            global::graphql_console.StarWarsClient.State.DroidEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetCharacters_Character_Droid(
                entity.Id,
                entity.Name);
        }
    }
}


// GetCharacters_Character_Droid.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A droid in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetCharacters_Character_Droid
        : global::System.IEquatable<GetCharacters_Character_Droid>
        , IGetCharacters_Character_Droid
    {
        public GetCharacters_Character_Droid(
            global::System.Int32 id,
            global::System.String name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public global::System.Int32 Id { get; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public global::System.String Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetCharacters_Character_Droid)obj);
        }

        public global::System.Boolean Equals(GetCharacters_Character_Droid? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetCharactersResult.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetCharactersResult
    {
        /// <summary>
        /// Gets a character by it`s id.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.IGetCharacters_Character> Character { get; }
    }
}


// IGetCharacters_Character.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A character in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetCharacters_Character
    {
        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        public global::System.Int32 Id { get; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        public global::System.String Name { get; }
    }
}


// IGetCharacters_Character_Human.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A human character in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetCharacters_Character_Human
        : IGetCharacters_Character
    {
    }
}


// IGetCharacters_Character_Droid.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// A droid in the Star Wars universe.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetCharacters_Character_Droid
        : IGetCharacters_Character
    {
    }
}


// Episode.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public enum Episode
    {
        /// <summary>
        /// Star Wars Episode IV: A New Hope
        /// </summary>
        Newhope,
        /// <summary>
        /// Star Wars Episode V: Empire Strikes Back
        /// </summary>
        Empire,
        /// <summary>
        /// Star Wars Episode VI: Return of the Jedi
        /// </summary>
        Jedi
    }
}


// EpisodeSerializer.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class EpisodeSerializer
        : global::StrawberryShake.Serialization.IInputValueFormatter
        , global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, Episode>
    {
        public global::System.String TypeName => "Episode";

        public Episode Parse(global::System.String serializedValue)
        {
            return serializedValue switch
            {
                "NEWHOPE" => Episode.Newhope,
                "EMPIRE" => Episode.Empire,
                "JEDI" => Episode.Jedi,
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }

        public global::System.Object Format(global::System.Object? runtimeValue)
        {
            return runtimeValue switch
            {
                Episode.Newhope => "NEWHOPE",
                Episode.Empire => "EMPIRE",
                Episode.Jedi => "JEDI",
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }
    }
}


// GetHeroQueryDocument.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// Represents the operation service of the GetHero GraphQL operation
    /// <code>
    /// query GetHero($episode: Episode!) {
    ///   hero(episode: $episode) {
    ///     __typename
    ///     id
    ///     name
    ///     friends {
    ///       __typename
    ///       edges {
    ///         __typename
    ///         node {
    ///           __typename
    ///           id
    ///           name
    ///           ... on Human {
    ///             id
    ///           }
    ///           ... on Droid {
    ///             id
    ///           }
    ///         }
    ///       }
    ///       totalCount
    ///     }
    ///     ... on Human {
    ///       id
    ///     }
    ///     ... on Droid {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHeroQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetHeroQueryDocument()
        {
        }

        public static GetHeroQueryDocument Instance { get; } = new GetHeroQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x48, 0x65, 0x72, 0x6f, 0x28, 0x24, 0x65, 0x70, 0x69, 0x73, 0x6f, 0x64, 0x65, 0x3a, 0x20, 0x45, 0x70, 0x69, 0x73, 0x6f, 0x64, 0x65, 0x21, 0x29, 0x20, 0x7b, 0x20, 0x68, 0x65, 0x72, 0x6f, 0x28, 0x65, 0x70, 0x69, 0x73, 0x6f, 0x64, 0x65, 0x3a, 0x20, 0x24, 0x65, 0x70, 0x69, 0x73, 0x6f, 0x64, 0x65, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x66, 0x72, 0x69, 0x65, 0x6e, 0x64, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x65, 0x64, 0x67, 0x65, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6e, 0x6f, 0x64, 0x65, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x48, 0x75, 0x6d, 0x61, 0x6e, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x44, 0x72, 0x6f, 0x69, 0x64, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x74, 0x6f, 0x74, 0x61, 0x6c, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x7d, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x48, 0x75, 0x6d, 0x61, 0x6e, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x44, 0x72, 0x6f, 0x69, 0x64, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "e6739920dd11e46380fe651d5481ed005afde586");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetHeroQuery.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// Represents the operation service of the GetHero GraphQL operation
    /// <code>
    /// query GetHero($episode: Episode!) {
    ///   hero(episode: $episode) {
    ///     __typename
    ///     id
    ///     name
    ///     friends {
    ///       __typename
    ///       edges {
    ///         __typename
    ///         node {
    ///           __typename
    ///           id
    ///           name
    ///           ... on Human {
    ///             id
    ///           }
    ///           ... on Droid {
    ///             id
    ///           }
    ///         }
    ///       }
    ///       totalCount
    ///     }
    ///     ... on Human {
    ///       id
    ///     }
    ///     ... on Droid {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHeroQuery
        : global::graphql_console.StarWarsClient.IGetHeroQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetHeroResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _episodeFormatter;

        public GetHeroQuery(
            global::StrawberryShake.IOperationExecutor<IGetHeroResult> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _episodeFormatter = serializerResolver.GetInputValueFormatter("Episode");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetHeroResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetHeroResult>> ExecuteAsync(
            global::graphql_console.StarWarsClient.Episode episode,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(episode);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetHeroResult>> Watch(
            global::graphql_console.StarWarsClient.Episode episode,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(episode);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::graphql_console.StarWarsClient.Episode episode)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "episode",
                FormatEpisode(episode));

            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetHeroQueryDocument.Instance.Hash.Value,
                name: "GetHero",
                document: GetHeroQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default,
                variables:variables);
        }

        private global::System.Object? FormatEpisode(global::graphql_console.StarWarsClient.Episode value)
        {
            return _episodeFormatter.Format(value);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}


// IGetHeroQuery.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// Represents the operation service of the GetHero GraphQL operation
    /// <code>
    /// query GetHero($episode: Episode!) {
    ///   hero(episode: $episode) {
    ///     __typename
    ///     id
    ///     name
    ///     friends {
    ///       __typename
    ///       edges {
    ///         __typename
    ///         node {
    ///           __typename
    ///           id
    ///           name
    ///           ... on Human {
    ///             id
    ///           }
    ///           ... on Droid {
    ///             id
    ///           }
    ///         }
    ///       }
    ///       totalCount
    ///     }
    ///     ... on Human {
    ///       id
    ///     }
    ///     ... on Droid {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetHeroQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetHeroResult>> ExecuteAsync(
            global::graphql_console.StarWarsClient.Episode episode,
            global::System.Threading.CancellationToken cancellationToken = default);

        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetHeroResult>> Watch(
            global::graphql_console.StarWarsClient.Episode episode,
            global::StrawberryShake.ExecutionStrategy? strategy = null);
    }
}


// GetCharactersQueryDocument.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// Represents the operation service of the GetCharacters GraphQL operation
    /// <code>
    /// query GetCharacters($ids: [Int!]!) {
    ///   character(ids: $ids) {
    ///     __typename
    ///     id
    ///     name
    ///     ... on Human {
    ///       id
    ///     }
    ///     ... on Droid {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetCharactersQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetCharactersQueryDocument()
        {
        }

        public static GetCharactersQueryDocument Instance { get; } = new GetCharactersQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x43, 0x68, 0x61, 0x72, 0x61, 0x63, 0x74, 0x65, 0x72, 0x73, 0x28, 0x24, 0x69, 0x64, 0x73, 0x3a, 0x20, 0x5b, 0x49, 0x6e, 0x74, 0x21, 0x5d, 0x21, 0x29, 0x20, 0x7b, 0x20, 0x63, 0x68, 0x61, 0x72, 0x61, 0x63, 0x74, 0x65, 0x72, 0x28, 0x69, 0x64, 0x73, 0x3a, 0x20, 0x24, 0x69, 0x64, 0x73, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x48, 0x75, 0x6d, 0x61, 0x6e, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x44, 0x72, 0x6f, 0x69, 0x64, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "1fa2dab6d96412cf7a6fcaa3e3777f6bf246cc36");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetCharactersQuery.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// Represents the operation service of the GetCharacters GraphQL operation
    /// <code>
    /// query GetCharacters($ids: [Int!]!) {
    ///   character(ids: $ids) {
    ///     __typename
    ///     id
    ///     name
    ///     ... on Human {
    ///       id
    ///     }
    ///     ... on Droid {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetCharactersQuery
        : global::graphql_console.StarWarsClient.IGetCharactersQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetCharactersResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _intFormatter;

        public GetCharactersQuery(
            global::StrawberryShake.IOperationExecutor<IGetCharactersResult> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _intFormatter = serializerResolver.GetInputValueFormatter("Int");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetCharactersResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetCharactersResult>> ExecuteAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.Int32> ids,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(ids);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetCharactersResult>> Watch(
            global::System.Collections.Generic.IReadOnlyList<global::System.Int32> ids,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(ids);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyList<global::System.Int32> ids)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "ids",
                FormatIds(ids));

            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetCharactersQueryDocument.Instance.Hash.Value,
                name: "GetCharacters",
                document: GetCharactersQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default,
                variables:variables);
        }

        private global::System.Object? FormatIds(global::System.Collections.Generic.IReadOnlyList<global::System.Int32> value)
        {
            var value_list = new global::System.Collections.Generic.List<global::System.Object?>();

            foreach (var value_elm in value)
            {
                value_list.Add(_intFormatter.Format(value_elm));
            }
            return value_list;
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}


// IGetCharactersQuery.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// Represents the operation service of the GetCharacters GraphQL operation
    /// <code>
    /// query GetCharacters($ids: [Int!]!) {
    ///   character(ids: $ids) {
    ///     __typename
    ///     id
    ///     name
    ///     ... on Human {
    ///       id
    ///     }
    ///     ... on Droid {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IGetCharactersQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetCharactersResult>> ExecuteAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.Int32> ids,
            global::System.Threading.CancellationToken cancellationToken = default);

        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetCharactersResult>> Watch(
            global::System.Collections.Generic.IReadOnlyList<global::System.Int32> ids,
            global::StrawberryShake.ExecutionStrategy? strategy = null);
    }
}


// GetHeroBuilder.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetHeroBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::graphql_console.StarWarsClient.IGetHeroResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::graphql_console.StarWarsClient.IGetHeroResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::graphql_console.StarWarsClient.Episode> _episodeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;

        public GetHeroBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::graphql_console.StarWarsClient.IGetHeroResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _episodeParser = serializerResolver.GetLeafValueParser<global::System.String, global::graphql_console.StarWarsClient.Episode>("Episode")
                 ?? throw new global::System.ArgumentException("No serializer for type `Episode` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetHeroResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetHeroResult Result, GetHeroResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }
                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch(global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[] {
                    new global::StrawberryShake.ClientError(
                        ex.Message,
                        exception: ex)
                };
            }

            return new global::StrawberryShake.OperationResult<IGetHeroResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetHeroResult, GetHeroResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::StrawberryShake.EntityId heroId = default!;
            _entityStore.Update(session => 
            {
                heroId = UpdateNonNullableIGetHero_HeroEntity(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "hero"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetHeroResultInfo(
                heroId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetHero_HeroEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Human",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::graphql_console.StarWarsClient.State.HumanEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.HumanEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeIGetHero_Hero_Friends(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "friends"),
                                entityIds)));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.HumanEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeIGetHero_Hero_Friends(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "friends"),
                                entityIds)));
                }

                return entityId;
            }

            if (entityId.Name.Equals(
                    "Droid",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::graphql_console.StarWarsClient.State.DroidEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.DroidEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeIGetHero_Hero_Friends(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "friends"),
                                entityIds)));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.DroidEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeIGetHero_Hero_Friends(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "friends"),
                                entityIds)));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::graphql_console.StarWarsClient.State.CharacterConnectionData? DeserializeIGetHero_Hero_Friends(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("CharacterConnection", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::graphql_console.StarWarsClient.State.CharacterConnectionData(
                    typename,
                    edges: DeserializeIGetHero_Hero_Friends_EdgesNonNullableArray(
                        session,
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "edges"),
                        entityIds),
                    totalCount: DeserializeNonNullableInt32(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "totalCount")));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.State.CharacterEdgeData>? DeserializeIGetHero_Hero_Friends_EdgesNonNullableArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var characterEdges = new global::System.Collections.Generic.List<global::graphql_console.StarWarsClient.State.CharacterEdgeData>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                characterEdges.Add(DeserializeNonNullableIGetHero_Hero_Friends_Edges(
                    session,
                    child,
                    entityIds));
            }

            return characterEdges;
        }

        private global::graphql_console.StarWarsClient.State.CharacterEdgeData DeserializeNonNullableIGetHero_Hero_Friends_Edges(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("CharacterEdge", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::graphql_console.StarWarsClient.State.CharacterEdgeData(
                    typename,
                    node: UpdateIGetHero_Hero_Friends_Edges_NodeEntity(
                        session,
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "node"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::StrawberryShake.EntityId? UpdateIGetHero_Hero_Friends_Edges_NodeEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Human",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::graphql_console.StarWarsClient.State.HumanEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.HumanEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            entity.Friends));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.HumanEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            default!));
                }

                return entityId;
            }

            if (entityId.Name.Equals(
                    "Droid",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::graphql_console.StarWarsClient.State.DroidEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.DroidEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            entity.Friends));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.DroidEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            default!));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }
    }
}


// GetCharactersBuilder.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class GetCharactersBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::graphql_console.StarWarsClient.IGetCharactersResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::graphql_console.StarWarsClient.IGetCharactersResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;

        public GetCharactersBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::graphql_console.StarWarsClient.IGetCharactersResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetCharactersResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetCharactersResult Result, GetCharactersResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }
                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch(global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[] {
                    new global::StrawberryShake.ClientError(
                        ex.Message,
                        exception: ex)
                };
            }

            return new global::StrawberryShake.OperationResult<IGetCharactersResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetCharactersResult, GetCharactersResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> characterId = default!;
            _entityStore.Update(session => 
            {
                characterId = UpdateNonNullableIGetCharacters_CharacterEntityNonNullableArray(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "character"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetCharactersResultInfo(
                characterId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> UpdateNonNullableIGetCharacters_CharacterEntityNonNullableArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var characters = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                characters.Add(UpdateNonNullableIGetCharacters_CharacterEntity(
                    session,
                    child,
                    entityIds));
            }

            return characters;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetCharacters_CharacterEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Human",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::graphql_console.StarWarsClient.State.HumanEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.HumanEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            entity.Friends));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.HumanEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            default!));
                }

                return entityId;
            }

            if (entityId.Name.Equals(
                    "Droid",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::graphql_console.StarWarsClient.State.DroidEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.DroidEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            entity.Friends));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::graphql_console.StarWarsClient.State.DroidEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            default!));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }
    }
}


// CharacterConnectionData.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class CharacterConnectionData
    {
        public CharacterConnectionData(
            global::System.String __typename,
            global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.State.CharacterEdgeData>? edges = null,
            global::System.Int32? totalCount = null)
        {
            this.__typename = __typename
                 ?? throw new global::System.ArgumentNullException(nameof(__typename));
            Edges = edges;
            TotalCount = totalCount;
        }

        public global::System.String __typename { get; }

        /// <summary>
        /// A list of edges.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::graphql_console.StarWarsClient.State.CharacterEdgeData>? Edges { get; }

        public global::System.Int32? TotalCount { get; }
    }
}


// CharacterEdgeData.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    /// <summary>
    /// An edge in a connection.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class CharacterEdgeData
    {
        public CharacterEdgeData(
            global::System.String __typename,
            global::StrawberryShake.EntityId? node = null)
        {
            this.__typename = __typename
                 ?? throw new global::System.ArgumentNullException(nameof(__typename));
            Node = node;
        }

        public global::System.String __typename { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public global::StrawberryShake.EntityId? Node { get; }
    }
}


// StarWarsClient.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// Represents the StarWarsClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class StarWarsClient
        : global::graphql_console.StarWarsClient.IStarWarsClient
    {
        private readonly global::graphql_console.StarWarsClient.IGetHeroQuery _getHero;
        private readonly global::graphql_console.StarWarsClient.IGetCharactersQuery _getCharacters;

        public StarWarsClient(
            global::graphql_console.StarWarsClient.IGetHeroQuery getHero,
            global::graphql_console.StarWarsClient.IGetCharactersQuery getCharacters)
        {
            _getHero = getHero
                 ?? throw new global::System.ArgumentNullException(nameof(getHero));
            _getCharacters = getCharacters
                 ?? throw new global::System.ArgumentNullException(nameof(getCharacters));
        }

        public static global::System.String ClientName => "StarWarsClient";

        public global::graphql_console.StarWarsClient.IGetHeroQuery GetHero => _getHero;

        public global::graphql_console.StarWarsClient.IGetCharactersQuery GetCharacters => _getCharacters;
    }
}


// IStarWarsClient.cs
#nullable enable

namespace graphql_console.StarWarsClient
{
    /// <summary>
    /// Represents the StarWarsClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public interface IStarWarsClient
    {
        global::graphql_console.StarWarsClient.IGetHeroQuery GetHero { get; }

        global::graphql_console.StarWarsClient.IGetCharactersQuery GetCharacters { get; }
    }
}


// StarWarsClientEntityIdFactory.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class StarWarsClientEntityIdFactory
        : global::StrawberryShake.IEntityIdSerializer
    {
        private static readonly global::System.Text.Json.JsonWriterOptions _options = new global::System.Text.Json.JsonWriterOptions(){ Indented = false };

        public global::StrawberryShake.EntityId Parse(global::System.Text.Json.JsonElement obj)
        {
            global::System.String __typename = obj
                .GetProperty("__typename")
                .GetString()!;

            return __typename switch
            {
                "Human" => ParseHumanEntityId(
                    obj,
                    __typename),
                "Droid" => ParseDroidEntityId(
                    obj,
                    __typename),
                _ => throw new global::System.NotSupportedException()
            };
        }

        public global::System.String Format(global::StrawberryShake.EntityId entityId)
        {
            return entityId.Name switch
            {
                "Human" => FormatHumanEntityId(entityId),
                "Droid" => FormatDroidEntityId(entityId),
                _ => throw new global::System.NotSupportedException()
            };
        }

        private global::StrawberryShake.EntityId ParseHumanEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetInt32()!);
        }

        private global::System.String FormatHumanEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteNumber(
                "id",
                (global::System.Int32)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseDroidEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetInt32()!);
        }

        private global::System.String FormatDroidEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteNumber(
                "id",
                (global::System.Int32)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }
    }
}


// StarWarsClientServiceCollectionExtensions.cs
#nullable enable

namespace Microsoft.Extensions.DependencyInjection
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public static partial class StarWarsClientServiceCollectionExtensions
    {
        public static global::StrawberryShake.IClientBuilder<global::graphql_console.StarWarsClient.State.StarWarsClientStoreAccessor> AddStarWarsClient(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var serviceCollection = ConfigureClientDefault(
                        sp,
                        strategy);

                    return new ClientServiceProvider(
                        global::Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(serviceCollection));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => new global::graphql_console.StarWarsClient.State.StarWarsClientStoreAccessor(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityIdSerializer>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::graphql_console.StarWarsClient.GetHeroQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::graphql_console.StarWarsClient.GetCharactersQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::graphql_console.StarWarsClient.StarWarsClient>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::graphql_console.StarWarsClient.IStarWarsClient>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            return new global::StrawberryShake.ClientBuilder<global::graphql_console.StarWarsClient.State.StarWarsClientStoreAccessor>(
                "StarWarsClient",
                services);
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClientDefault(
            global::System.IServiceProvider parentServices,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            var services = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IEntityStore, global::StrawberryShake.EntityStore>(services);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IOperationStore>(
                services,
                sp => new global::StrawberryShake.OperationStore(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var clientFactory = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Net.Http.IHttpClientFactory>(parentServices);
                    return new global::StrawberryShake.Transport.Http.HttpConnection(() => clientFactory.CreateClient("StarWarsClient"));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, global::graphql_console.StarWarsClient.GetHero_Hero_Human>, global::graphql_console.StarWarsClient.State.GetHero_Hero_HumanFromHumanEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, global::graphql_console.StarWarsClient.GetHero_Hero_Droid>, global::graphql_console.StarWarsClient.State.GetHero_Hero_DroidFromDroidEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, global::graphql_console.StarWarsClient.GetHero_Hero_Friends_Edges_Node_Human>, global::graphql_console.StarWarsClient.State.GetHero_Hero_Friends_Edges_Node_HumanFromHumanEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, global::graphql_console.StarWarsClient.GetHero_Hero_Friends_Edges_Node_Droid>, global::graphql_console.StarWarsClient.State.GetHero_Hero_Friends_Edges_Node_DroidFromDroidEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.HumanEntity, global::graphql_console.StarWarsClient.GetCharacters_Character_Human>, global::graphql_console.StarWarsClient.State.GetCharacters_Character_HumanFromHumanEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::graphql_console.StarWarsClient.State.DroidEntity, global::graphql_console.StarWarsClient.GetCharacters_Character_Droid>, global::graphql_console.StarWarsClient.State.GetCharacters_Character_DroidFromDroidEntityMapper>(services);

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::graphql_console.StarWarsClient.EpisodeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UuidSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver>(
                services,
                sp => new global::StrawberryShake.Serialization.SerializerResolver(
                    global::System.Linq.Enumerable.Concat(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            parentServices),
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::graphql_console.StarWarsClient.IGetHeroResult>, global::graphql_console.StarWarsClient.State.GetHeroResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::graphql_console.StarWarsClient.IGetHeroResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::graphql_console.StarWarsClient.IGetHeroQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::graphql_console.StarWarsClient.IGetHeroResult>, global::graphql_console.StarWarsClient.State.GetHeroBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::graphql_console.StarWarsClient.IGetHeroResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::graphql_console.StarWarsClient.IGetHeroResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::graphql_console.StarWarsClient.IGetHeroResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::graphql_console.StarWarsClient.GetHeroQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::graphql_console.StarWarsClient.IGetHeroQuery>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::graphql_console.StarWarsClient.GetHeroQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::graphql_console.StarWarsClient.IGetCharactersResult>, global::graphql_console.StarWarsClient.State.GetCharactersResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::graphql_console.StarWarsClient.IGetCharactersResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::graphql_console.StarWarsClient.IGetCharactersQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::graphql_console.StarWarsClient.IGetCharactersResult>, global::graphql_console.StarWarsClient.State.GetCharactersBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::graphql_console.StarWarsClient.IGetCharactersResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::graphql_console.StarWarsClient.IGetCharactersResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::graphql_console.StarWarsClient.IGetCharactersResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::graphql_console.StarWarsClient.GetCharactersQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::graphql_console.StarWarsClient.IGetCharactersQuery>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::graphql_console.StarWarsClient.GetCharactersQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityIdSerializer, global::graphql_console.StarWarsClient.State.StarWarsClientEntityIdFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::graphql_console.StarWarsClient.StarWarsClient>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::graphql_console.StarWarsClient.IStarWarsClient>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::graphql_console.StarWarsClient.StarWarsClient>(sp));
            return services;
        }

        private class ClientServiceProvider
            : System.IServiceProvider
            , System.IDisposable
        {
            private readonly System.IServiceProvider _provider;

            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}


// StarWarsClientStoreAccessor.cs
#nullable enable

namespace graphql_console.StarWarsClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.0.0.0")]
    public partial class StarWarsClientStoreAccessor
        : global::StrawberryShake.StoreAccessor
    {
        public StarWarsClientStoreAccessor(
            global::StrawberryShake.IOperationStore operationStore,
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer entityIdSerializer,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory> requestFactories,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory> resultDataFactories)
            : base(
                operationStore,
                entityStore,
                entityIdSerializer,
                requestFactories,
                resultDataFactories)
        {
        }
    }
}


