using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Terrain.Resources;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Reads every mounted terrain resource (VisualTerrain, TerrainLayerCombinations, TerrainDecals, TerrainStreamingTree) and writes it back, reporting any that do not come out byte-identical.")]
    public class RoundTripTerrainCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Engine = s_Mounter.GetEngineType();

            T? Create<T>() where T : class, IEngineInterface =>
                EngineInterfaceRegistry.IsSupported<T>(s_Engine) ? EngineInterfaceRegistry.Create<T>(s_Engine) : null;

            var s_VisualTerrain = Create<IVisualTerrain>();
            var s_LayerCombinations = Create<ITerrainLayerCombinations>();
            var s_Decals = Create<ITerrainDecalsConverter>();
            var s_Heightfield = Create<ITerrainHeightfield>();

            var s_RoundTrips = new Dictionary<ResourceType, Func<IResourceVariant, (byte[]? Original, byte[]? Rebuilt)>>();
            if (s_VisualTerrain != null)
                s_RoundTrips[ResourceType.VisualTerrain] = p_V => s_VisualTerrain.RoundTripVisualTerrain(p_V, out var s_O, out var s_R) ? (s_O, s_R) : (s_O, null);
            if (s_LayerCombinations != null)
                s_RoundTrips[ResourceType.TerrainLayerCombinations] = p_V => s_LayerCombinations.RoundTripLayerCombinations(p_V, out var s_O, out var s_R) ? (s_O, s_R) : (s_O, null);
            if (s_Decals != null)
                s_RoundTrips[ResourceType.TerrainDecals] = p_V => RoundTripDecals(s_Decals, p_V);

            var s_Same = 0;
            var s_Total = 0;
            foreach (var (s_Name, s_Resource) in s_Mounter.GetResources().OrderBy(p_R => p_R.Key, StringComparer.Ordinal))
            {
                var s_Variant = s_Resource.FirstVariant;
                var s_Type = s_Variant.GetResourceType();

                bool s_Identical;
                string s_Detail;
                try
                {
                    if (s_Type == ResourceType.TerrainStreamingTree && s_Heightfield != null)
                    {
                        if (!s_Heightfield.ReadHeightfield(s_Variant, s_Mounter, out var s_Tree) || s_Tree == null)
                            continue;

                        s_Identical = s_Tree.StreamingTreeRewritesExactly;
                        s_Detail = $"{s_Tree.StreamingTreeRawLength} bytes read, {s_Tree.StreamingTreeWrittenLength} written, first difference at {s_Tree.StreamingTreeFirstDiff}; " +
                            $"heightfield {s_Tree.HeightfieldRewritesExactly}, mask {s_Tree.MaskRewritesExactly}, material {s_Tree.MaterialRewritesExactly}, destruction {s_Tree.DestructionRewritesExactly}";
                    }
                    else if (s_RoundTrips.TryGetValue(s_Type, out var s_RoundTrip))
                    {
                        var (s_Original, s_Rebuilt) = s_RoundTrip(s_Variant);
                        s_Identical = s_Original != null && s_Rebuilt != null && s_Original.AsSpan().SequenceEqual(s_Rebuilt);
                        s_Detail = s_Rebuilt == null
                            ? "the writer refused"
                            : $"{s_Original?.Length} bytes read, {s_Rebuilt.Length} written, first difference at {FirstDifference(s_Original!, s_Rebuilt)}";
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (Exception s_Ex)
                {
                    s_Identical = false;
                    s_Detail = s_Ex.Message;
                }

                s_Total++;
                if (s_Identical)
                    s_Same++;
                else
                    p_Writer.WriteLine($"DIFF {s_Type} {s_Name}: {s_Detail}");
            }

            p_Writer.WriteLine($"round_trip_terrain: {s_Same}/{s_Total} byte-identical.");
            return s_Same == s_Total;
        }

        private static (byte[]? Original, byte[]? Rebuilt) RoundTripDecals(ITerrainDecalsConverter p_Converter, IResourceVariant p_Variant)
        {
            byte[] s_Original;
            using (var s_Reader = p_Variant.GetReader())
                s_Original = s_Reader.ReadBytes((int)s_Reader.Length);

            TerrainDecalsResource s_Decals;
            using (var s_Reader = new RimeReader(new MemoryStream(s_Original, false)))
            {
                s_Decals = p_Converter.Read(s_Reader);
                if (s_Reader.Position != s_Reader.Length)
                    throw new InvalidDataException($"the reader stopped {s_Reader.Length - s_Reader.Position} byte(s) before the end");
            }

            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                p_Converter.Write(s_Writer, s_Decals);

            return (s_Original, s_Stream.ToArray());
        }

        private static int FirstDifference(byte[] p_A, byte[] p_B)
        {
            for (var i = 0; i < System.Math.Min(p_A.Length, p_B.Length); ++i)
            {
                if (p_A[i] != p_B[i])
                    return i;
            }

            return p_A.Length == p_B.Length ? -1 : System.Math.Min(p_A.Length, p_B.Length);
        }
    }
}
