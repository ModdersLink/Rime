using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Commands.Game;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Serialization;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Adds the textures that a shader database's shaders bind for the shaders this bundle's
    /// content uses. The level's shader database lives in the main bundle, but the textures its
    /// shaders bind ship with the shaders' users, so a gamemode bundle carries the ones for its
    /// own content.
    /// </summary>
    [CommandDescription("Adds the textures a shader database binds for the shaders this bundle's partitions use, with their closure.")]
    public class AddShaderTexturesCommand : Command
    {
        [CommandArgument(Description = "The shader database resource, e.g. levels/mp_subway/mp_subway/shaderdb.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The level partition whose content's shaders count (LevelData or SubWorldData), or * for every shader of the database. Default: the bundle's own partitions.", Optional = true)]
        public string? Partition { get; set; }

        [CommandArgument(Description = "The id of the mounted game.", Optional = true)]
        public int Id { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbContext.Parent!;
            if (!s_BaseContext.GetMounters().TryGetValue(Id, out var s_Mounter) || s_Mounter.GetEngineType() != s_SbContext.EngineType)
            {
                p_Writer.WriteLine($"Id ({Id}) is not a mounted game of this engine.");
                return false;
            }

            // The bundle's own database when it built one, else the game's.
            IResourceObject? s_Database = null;
            if (!string.IsNullOrWhiteSpace(Name))
            {
                if (s_BundleContext.GetResources().TryGetValue(Name.ToLowerInvariant(), out var s_Built))
                    s_Database = s_Built;
                else if (s_Mounter.TryGetResource(Name.ToLowerInvariant(), out var s_Resource))
                    s_Database = s_Resource.FirstVariant;
            }

            if (s_Database == null)
            {
                p_Writer.WriteLine($"Could not find resource ({Name}).");
                return false;
            }

            var s_Resolver = EngineInterfaceRegistry.Create<IShaderResolver>(s_SbContext.EngineType);
            s_Resolver.Initialize(s_Database, s_Mounter);
            var s_ByShader = s_Resolver.GetTexturesByShader();

            // The shaders the level's content uses: everything its partition reaches (meshes from
            // dependency bundles included), or the bundle's own partitions.
            var s_Partitions = BundlePartitionVariant.All(s_BundleContext);
            IEnumerable<DataContainerBase> s_Content;
            if (Partition == "*")
            {
                s_Content = Enumerable.Empty<DataContainerBase>();
            }
            else if (Partition != null)
            {
                var s_Deriver = new RegistryDeriver(s_Mounter, p_N => s_Partitions.GetValueOrDefault(p_N), s_Partitions.Keys);
                s_Content = s_Deriver.ReachedContent(Partition.ToLowerInvariant()).Content;
            }
            else
            {
                var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SbContext.EngineType);
                s_Content = s_Partitions.SelectMany(p_P =>
                {
                    try { return s_Converter.FromPartitionObject(p_P.Key, p_P.Value).Instances.Where(p_I => p_I != null); }
                    catch (Exception) { return Enumerable.Empty<DataContainerBase>(); }
                }).ToList();
            }

            var s_Shaders = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            if (Partition == "*")
            {
                s_Shaders.UnionWith(s_ByShader.Keys);
            }
            else
            {
                foreach (var s_Instance in s_Content)
                foreach (var (_, s_Ref) in AnalyzeRegistryCommand.References(s_Instance, s_Instance.GetType().Name, 0))
                {
                    if (s_Mounter.TryGetPartitionByGuid(s_Ref.PartitionGuid, out var s_Target, out _) && s_ByShader.ContainsKey(s_Target))
                        s_Shaders.Add(s_Target);
                }
            }

            // For every shader of the database, what the superbundle's other bundles carry is theirs:
            // a gamemode's meshes bring the textures they bind.
            var s_Siblings = Partition == "*"
                ? s_SbContext.GetBundles().Values.SelectMany(p_B => p_B.Partitions.Keys).Select(p_N => p_N.ToLowerInvariant()).ToHashSet()
                : new HashSet<string>();

            var s_Textures = s_Shaders.SelectMany(p_S => s_ByShader[p_S]).Select(p_T => p_T.ToLowerInvariant())
                .Where(p_T => !s_BundleContext.GetPartitions().ContainsKey(p_T) && !s_Siblings.Contains(p_T) && s_Mounter.TryGetPartition(p_T, out _))
                .Distinct().OrderBy(p_T => p_T, StringComparer.Ordinal).ToList();

            if (PartitionClosure.Create((BundleBuildingContext)p_Context, Id, [], TextWriter.Null) is not { } s_Adder)
            {
                p_Writer.WriteLine($"No game {Id} of this bundle's engine is mounted to add their closure from.");
                return false;
            }

            s_Adder.AddAll(s_Textures, p_Writer);

            p_Writer.WriteLine($"{s_Shaders.Count} shader(s) of '{Name}' used by the bundle; {s_Textures.Count} texture(s) they bind not in the bundle, added unless a dependency carries them.");
            return true;
        }
    }
}
