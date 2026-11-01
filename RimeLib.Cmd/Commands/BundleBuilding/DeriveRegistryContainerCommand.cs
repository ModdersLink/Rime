using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Derives the registry of the bundle being built with the engine's registry rules (see
    /// derive_registry), reading the bundle's own partitions first and the mounted game for the rest.
    /// The result replaces what generate_registry_container would store, for emit_subworld_registry.
    /// </summary>
    [CommandDescription("Derives the bundle's registry from its level partition with the engine's measured registry rules.")]
    public class DeriveRegistryContainerCommand : Command
    {
        [CommandArgument(Description = "The level partition (LevelData or SubWorldData). Default: the bundle name without its platform prefix.", Optional = true)]
        public string? Partition { get; set; }

        [CommandArgument(Description = "The id of the mounted game to resolve everything outside the bundle with.", Optional = true)]
        public int Id { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbContext.Parent!;

            if (!s_BaseContext.GetMounters().TryGetValue(Id, out var s_Mounter))
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first.");
                return false;
            }

            if (s_Mounter.GetEngineType() != s_SbContext.EngineType)
            {
                p_Writer.WriteLine($"Cross-engine support has not been added, ({s_Mounter.GetEngineType()} != {s_SbContext.EngineType})");
                return false;
            }

            var s_BundleName = s_BundleContext.BundleName.ToLowerInvariant();
            var s_Root = (Partition ?? (s_BundleName.StartsWith("win32/") ? s_BundleName["win32/".Length..] : s_BundleName)).ToLowerInvariant();

            // The bundle's partitions as variants the partition converter can read.
            var s_Partitions = s_BundleContext.GetPartitions()
                .ToDictionary(p_P => p_P.Key.ToLowerInvariant(), p_P => p_P.Value as IObjectVariant ?? new BundlePartition(p_P.Value, s_BundleName), StringComparer.OrdinalIgnoreCase);

            var s_Deriver = new RegistryDeriver(s_Mounter, p_N => s_Partitions.GetValueOrDefault(p_N), s_Partitions.Keys);
            if (s_Deriver.GetVariant(s_Root) == null)
            {
                p_Writer.WriteLine($"No partition named '{s_Root}' in the bundle or the mounted game.");
                return false;
            }

            var s_Result = s_Deriver.Derive(s_Root, null, p_Writer);
            var s_Entries = s_Result.Entries.ToDictionary(p_P => p_P.Key, p_P => p_P.Value.Select(s_Deriver.ToReference).ToList());
            s_BundleContext.SetDerivedRegistry(s_Deriver.Rules.CreateRegistry(s_Entries));

            p_Writer.WriteLine("Registry derived and stored in context.");
            foreach (var (s_Kind, s_List) in s_Entries)
                p_Writer.WriteLine($"- {s_Kind}: {s_List.Count}");

            return true;
        }

        /// <summary>A partition of the bundle being built, readable like a mounted one.</summary>
        private class BundlePartition : IObjectVariant
        {
            private readonly IReadableObject m_Object;
            private readonly string m_Bundle;

            public BundlePartition(IReadableObject p_Object, string p_Bundle)
            {
                m_Object = p_Object;
                m_Bundle = p_Bundle;
            }

            public bool Cas => false;
            public RimeReader GetReader() => m_Object.GetReader();
            public long GetSize() => m_Object.GetSize();
            public Sha1? GetSha1() => (m_Object as IObjectWithHash)?.GetSha1();
            public string GetContainedSuperbundle() => "";
            public string? GetContainedBundle() => m_Bundle;
        }
    }
}
