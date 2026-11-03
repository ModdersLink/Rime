using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Picks, for each surface shader the mesh materials of a bundle use, the most similar shader of another mounted game by the parameters their materials set, and lists the picks with the texture parameters the stand-in does not take.")]
    public class MapShaderStandInsCommand : Command
    {
        [CommandArgument(Description = "Id of the mounted game to take stand-in shaders from.")]
        public int Target { get; set; }

        [CommandArgument(Description = "A bundle name (e.g. win32/levels/mp/mp_prison/mp_prison) or a partition name.")]
        public string Name { get; set; } = "";

        [CommandArgument(Description = "How many shaders to list.", Optional = true)]
        public int Top { get; set; } = 40;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Game = (GameContext)p_Context;
            var s_Source = s_Game.GetMounter();
            if (!((BaseContext)s_Game.Parent!).GetMounters().TryGetValue(Target, out var s_Target))
            {
                p_Writer.WriteLine($"No game is mounted with id {Target}.");
                return false;
            }

            var s_Engine = s_Target.GetEngineType();
            var s_Bindings = EngineInterfaceRegistry.Create<IShaderBindings>(s_Engine);
            var s_StandIns = Learn(s_Target, s_Bindings);
            p_Writer.WriteLine($"{s_StandIns.Count} shader(s) used by the target's mesh materials.");

            var s_Picks = Used(s_Source, s_Target, s_Bindings)
                .Where(p_U => !s_Target.TryGetPartitionByGuid(p_U.Key.Partition, out _, out _))
                .Select(p_U => (Shader: p_U.Key, p_U.Value.Parameters, Uses: p_U.Value.Materials, StandIn: s_StandIns.Choose(p_U.Value.Parameters)))
                .OrderByDescending(p_P => p_P.Uses)
                .ToList();

            foreach (var s_Pick in s_Picks.Take(Top))
            {
                p_Writer.WriteLine($"{s_Pick.Uses,5}  {NameOf(s_Source, s_Pick.Shader)}: {Describe(s_Pick.Parameters)}");
                if (s_Pick.StandIn == null)
                {
                    p_Writer.WriteLine("         no stand-in: no target shader shares a parameter name");
                    continue;
                }

                var s_Missing = s_Pick.Parameters.Textures.Except(s_Pick.StandIn.Takes.Textures).Order(StringComparer.Ordinal).ToList();
                p_Writer.WriteLine($"         -> {NameOf(s_Target, s_Pick.StandIn.Shader)} ({s_Pick.StandIn.Similarity:P0} alike): {Describe(s_Pick.StandIn.Takes)}"
                    + (s_Missing.Count > 0 ? $"; without {string.Join(", ", s_Missing)}" : ""));
            }

            var s_Without = s_Picks.Count(p_P => p_P.StandIn == null);
            p_Writer.WriteLine($"map_shader_stand_ins: {s_Picks.Count - s_Without}/{s_Picks.Count} shader(s) the target lacks have a stand-in.");
            return true;
        }

        /// <summary>The shaders of the target's own mesh materials, with the textures its mesh variation databases bind.</summary>
        private static ShaderStandIns Learn(IEngineMounter p_Target, IShaderBindings p_Bindings)
        {
            var s_Primary = EngineInterfaceRegistry.Create<IPartitionImportReader>(p_Target.GetEngineType());
            var s_Reader = EngineInterfaceRegistry.Create<IPartitionConverter>(p_Target.GetEngineType());
            var s_Shaders = new MaterialShaders();
            foreach (var (s_Name, s_Partition) in p_Target.GetPartitions().OrderBy(p_P => p_P.Key, StringComparer.Ordinal))
            {
                var s_Variant = s_Partition.FirstVariant;
                var s_Type = s_Primary.ReadPrimaryTypeName(s_Variant);
                if (s_Type != null && (s_Type.EndsWith("MeshAsset", StringComparison.Ordinal) || s_Type == "MeshVariationDatabase"))
                    s_Shaders.Add(p_Bindings, s_Reader.FromPartitionObject(s_Name, s_Variant));
            }

            return new ShaderStandIns(s_Shaders.ByShader());
        }

        /// <summary>The shaders the bundle's mesh materials use once converted to the target's types.</summary>
        private IReadOnlyDictionary<InstanceRef, (ShaderParameters Parameters, int Materials)> Used(IEngineMounter p_Source, IEngineMounter p_Target, IShaderBindings p_Bindings)
        {
            var s_Reader = EngineInterfaceRegistry.Create<IPartitionConverter>(p_Source.GetEngineType());
            var s_Conversion = new PartitionConversion(EngineInterfaceRegistry.Create<IEbxTypeLibrary>(p_Target.GetEngineType()));
            var s_Name = Name.ToLowerInvariant();
            var s_Names = p_Source.TryGetPartition(s_Name, out _) ? [s_Name] : p_Source.GetPartitionsInBundle(Name).ToList();

            var s_Shaders = new MaterialShaders();
            foreach (var s_Partition in s_Names)
            {
                if (!p_Source.TryGetPartition(s_Partition.ToLowerInvariant(), out var s_Mounted))
                    continue;

                try
                {
                    s_Shaders.Add(p_Bindings, s_Conversion.Convert(s_Reader.FromPartitionObject(s_Partition, s_Mounted.FirstVariant)));
                }
                catch (InvalidDataException)
                {
                    // A partition whose primary type the target lacks has no mesh materials to map.
                }
            }

            return s_Shaders.ByShader();
        }

        private static string Describe(ShaderParameters p_Parameters) =>
            $"textures [{string.Join(", ", p_Parameters.Textures.Order(StringComparer.Ordinal))}], {p_Parameters.Vectors.Count} vector(s), {p_Parameters.Bools.Count} bool(s)";

        private static string NameOf(IEngineMounter p_Mounter, InstanceRef p_Shader) =>
            p_Mounter.TryGetPartitionByGuid(p_Shader.Partition, out var s_Name, out _) ? s_Name : p_Shader.Partition.ToString();
    }
}
