using Newtonsoft.Json;
using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Terrain.Resources;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Replaces a TerrainDecals resource's data from a JSON file, as produced by dump_terrain_decals_json. Keeps the original type, meta and id.")]
    internal class ReplaceTerrainDecalsCommand : Command
    {
        [CommandArgument(Description = "The TerrainDecals resource to replace. Must exist in a mounted game.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Description = "The path to the JSON file containing the new TerrainDecals data.")]
        public FileInfo? FilePath { get; set; }

        [CommandArgument(Description = "Move the water geometry to this absolute Y height. Omit to keep the JSON's water as it is.", Optional = true)]
        public float WaterHeight { get; set; } = float.NaN;

        // The match is exact rather than a prefix, so a shader that is a prefix of another does not
        // bleed across, e.g. '.../Water' will not also pick up '.../WaterPool'.
        [CommandArgument(Description = "Only move water blocks whose surfaceShaderName is exactly this, so pools sharing the .decals stay put. Omit to move all of them.", Optional = true)]
        public string? WaterShader { get; set; }

        // Wraps the original resource variant's type, meta and id but serves new bytes from memory.
        private class DecalsResource : IResourceObject
        {
            private readonly IResourceVariant m_Original;
            private readonly byte[] m_Data;

            public DecalsResource(IResourceVariant p_Original, byte[] p_Data)
            {
                m_Original = p_Original;
                m_Data = p_Data;
            }

            public ResourceType GetResourceType() => m_Original.GetResourceType();

            public bool TryGetMeta([NotNullWhen(true)] out byte[]? p_Meta) => m_Original.TryGetMeta(out p_Meta);

            public ResourceRef GetId(string? p_Name = null)
            {
                try { return m_Original.GetId(p_Name); }
                catch { return new ResourceRef(p_Name ?? string.Empty, this); }
            }

            public RimeReader GetReader() => new RimeReader(new MemoryStream(m_Data, false));

            public long GetSize() => m_Data.Length;
        }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("The specified resource could not be found.");
                return false;
            }

            if (!FilePath!.Exists)
            {
                p_Writer.WriteLine("The specified JSON file could not be found.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbBuildingContext = (SbBuildingContext?)s_BundleContext.Parent;
            if (s_SbBuildingContext == null)
            {
                p_Writer.WriteLine("Parent context is invalid.");
                return false;
            }

            var s_BaseContext = s_SbBuildingContext.Parent as BaseContext;
            if (s_BaseContext == null)
            {
                p_Writer.WriteLine("SbBuildingContext parent is invalid.");
                return false;
            }

            var s_Mounters = s_BaseContext.GetMounters();
            if (!s_Mounters.TryGetValue(Id, out var s_EngineMounter))
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first");
                return false;
            }

            var s_ContextEngineType = s_SbBuildingContext.EngineType;
            if (s_EngineMounter.GetEngineType() != s_ContextEngineType)
            {
                p_Writer.WriteLine($"Cross-engine support has not been added, ({s_EngineMounter.GetEngineType()} != {s_ContextEngineType})");
                return false;
            }

            if (!s_EngineMounter.TryGetResource(Name!, out var s_Resource))
            {
                p_Writer.WriteLine($"Could not find resource ({Name}).");
                return false;
            }

            // Prefer a cas variant in a cas build, but fall back to any bundle-contained variant so the
            // often inline DLC resources still resolve.
            IResourceVariant? s_Variant = null;
            if (s_BundleContext.Cas())
                s_Variant = s_Resource.Variants.FirstOrDefault(p_Resource => p_Resource.Cas && p_Resource.GetContainedBundle() != null);
            s_Variant ??= s_Resource.Variants.FirstOrDefault(p_Resource => p_Resource.GetContainedBundle() != null);

            if (s_Variant == null)
            {
                p_Writer.Write($"Could not find a valid variant of ({Name}).");
                return false;
            }

            // Deserialize the JSON and serialize it back to .decals bytes via the engine converter.
            var s_Decals = JsonConvert.DeserializeObject<TerrainDecalsResource>(File.ReadAllText(FilePath.FullName));
            if (s_Decals == null)
            {
                p_Writer.WriteLine("Failed to parse the TerrainDecals JSON.");
                return false;
            }

            // A block's bounding boxes hold Y at index 1 (min) and 4 (max), and a water vertex's
            // position is packed half-floats with Y at index 1.
            if (!float.IsNaN(WaterHeight))
            {
                var s_Water = s_Decals.GeometryWater;
                var s_YBits = BitConverter.HalfToUInt16Bits((Half)WaterHeight);
                var s_Filter = string.IsNullOrWhiteSpace(WaterShader) ? null : WaterShader;

                // When filtering by shader, only the vertices used by matching blocks move.
                var s_MoveVertex = s_Water.WaterVertices != null ? new bool[s_Water.WaterVertices.Count] : null;
                var s_BlockCount = 0;
                foreach (var s_Block in s_Water.Blocks)
                {
                    if (s_Filter != null &&
                        !string.Equals(s_Block.SurfaceShaderName, s_Filter, StringComparison.OrdinalIgnoreCase))
                        continue;

                    s_Block.BoundingBox[1] = WaterHeight;
                    s_Block.BoundingBox[4] = WaterHeight;
                    s_Block.BoundingBox2[1] = WaterHeight;
                    s_Block.BoundingBox2[4] = WaterHeight;
                    s_BlockCount++;

                    if (s_MoveVertex != null)
                        for (var i = (int)s_Block.VertexBegin; i < (int)s_Block.VertexEnd && i < s_MoveVertex.Length; i++)
                            s_MoveVertex[i] = true;
                }

                var s_VertexCount = 0;
                if (s_Water.WaterVertices != null)
                {
                    for (var i = 0; i < s_Water.WaterVertices.Count; i++)
                    {
                        if (s_Filter != null && (s_MoveVertex == null || !s_MoveVertex[i]))
                            continue;

                        s_Water.WaterVertices[i].Position[1] = s_YBits;
                        s_VertexCount++;
                    }
                }

                p_Writer.WriteLine($"Moved water geometry to Y={WaterHeight} ({s_BlockCount} blocks, {s_VertexCount} vertices{(s_Filter != null ? $", shader='{s_Filter}'" : "")}).");
            }

            var s_Converter = EngineInterfaceRegistry.Create<ITerrainDecalsConverter>(s_ContextEngineType);

            byte[] s_Bytes;
            using (var s_Stream = new MemoryStream())
            {
                using (var s_Writer = new RimeWriter(s_Stream, p_ShouldDispose: false))
                    s_Converter.Write(s_Writer, s_Decals);
                s_Bytes = s_Stream.ToArray();
            }

            var s_HasMeta = s_Variant.TryGetMeta(out var s_MetaBytes);
            var s_MetaHex = s_HasMeta && s_MetaBytes != null
                ? string.Concat(s_MetaBytes.Select(p_B => p_B.ToString("X2")))
                : "<none>";
            p_Writer.WriteLine($"Replacing '{Name}' (type {s_Variant.GetResourceType()}, meta {s_MetaHex}) with {s_Bytes.Length} bytes from {FilePath.Name}.");

            s_BundleContext.AddResource(Name!, new DecalsResource(s_Variant, s_Bytes));

            return true;
        }
    }
}
