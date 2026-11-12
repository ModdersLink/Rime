using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using RimeLib.Shader;

namespace RimeLib.Cmd
{
    /// <summary>The mounted shader databases and which shaders each holds, read once per mounter.</summary>
    internal sealed class ShaderDatabaseIndex
    {
        // One per mounter: converting reads the source game's and the target game's in turn.
        private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<IEngineMounter, ShaderDatabaseIndex> m_Indices = new();

        public IEngineMounter Mounter { get; }
        public IShaderDatabaseBuilder Builder { get; }

        /// <summary>By name, with a loader for the data and the shader keys held.</summary>
        public List<(string Name, Func<byte[]> Load, ISet<uint> Keys)> Databases { get; } = new();

        public HashSet<uint> AllKeys { get; } = new();

        /// <summary>Shader partition names by key, for the keys a mounted partition has.</summary>
        public Dictionary<uint, string> Names { get; } = new();

        private ShaderDatabaseIndex(IEngineMounter p_Mounter)
        {
            Mounter = p_Mounter;
            Builder = EngineInterfaceRegistry.Create<IShaderDatabaseBuilder>(p_Mounter.GetEngineType());

            foreach (var (s_Name, s_Resource) in p_Mounter.GetResources().OrderBy(p_R => p_R.Key, StringComparer.Ordinal))
            {
                if (s_Resource.FirstVariant.GetResourceType() is not (ResourceType.IShaderDatabase or ResourceType.DxShaderDatabase))
                    continue;

                var s_Variant = s_Resource.FirstVariant;
                byte[] Load()
                {
                    using var s_Reader = s_Variant.GetReader();
                    return s_Reader.ReadBytes((int)s_Reader.Length);
                }

                var s_Keys = Builder.GetShaderKeys(Load());
                Databases.Add((s_Name.ToLowerInvariant(), Load, s_Keys));
                AllKeys.UnionWith(s_Keys);
            }

            foreach (var s_Key in AllKeys)
            {
                if (p_Mounter.TryGetPartitionByHashLower(s_Key, out var s_Partition))
                    Names[s_Key] = s_Partition.OriginalName.ToLowerInvariant();
            }
        }

        public static ShaderDatabaseIndex Get(IEngineMounter p_Mounter)
        {
            lock (m_Indices)
                return m_Indices.GetValue(p_Mounter, p_M => new ShaderDatabaseIndex(p_M));
        }

        private ShaderDeclarations? m_Declarations;

        /// <summary>The vertex declarations each shader has solutions for, over every mounted database.</summary>
        public ShaderDeclarations Declarations => m_Declarations ??= ShaderDeclarations.Merge(Databases.Select(p_D => Builder.GetDeclarations(p_D.Load())));

        private HashSet<string>? m_Imported;

        /// <summary>
        /// The shaders some mounted partition imports. The engine's own shaders are looked up by
        /// name, so nothing imports them.
        /// </summary>
        public HashSet<string> Imported => m_Imported ??= FindImported();

        private HashSet<string> FindImported()
        {
            var s_Reader = EngineInterfaceRegistry.Create<IPartitionImportReader>(Mounter.GetEngineType());
            var s_Partitions = Mounter.GetPartitions().ToList();
            var s_Read = new (GUID Guid, IReadOnlyCollection<GUID> Imports)?[s_Partitions.Count];
            System.Threading.Tasks.Parallel.For(0, s_Partitions.Count, i =>
            {
                try
                {
                    s_Read[i] = s_Reader.ReadImports(s_Partitions[i].Value.FirstVariant);
                }
                catch (Exception)
                {
                    // An unreadable header imports nothing here.
                }
            });

            var s_ImportedGuids = s_Read.Where(p_R => p_R != null).SelectMany(p_R => p_R!.Value.Imports).ToHashSet();
            var s_Imported = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            for (var i = 0; i < s_Partitions.Count; i++)
            {
                var s_Name = s_Partitions[i].Key.ToLowerInvariant();
                if (s_Read[i] is { } s_Entry && s_ImportedGuids.Contains(s_Entry.Guid) && IsShader(s_Name))
                    s_Imported.Add(s_Name);
            }

            return s_Imported;
        }

        public bool IsShader(string p_Partition) => AllKeys.Contains(Builder.GetShaderKey(p_Partition));
    }
}
