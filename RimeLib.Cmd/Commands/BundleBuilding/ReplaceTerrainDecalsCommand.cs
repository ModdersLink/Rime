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
    [CommandDescription("Replaces a TerrainDecals (.decals) resource's data straight from a JSON file (as produced by dump_terrain_decals_json), serializing it through the engine's converter while building the bundle. Keeps the original resource type, meta and id.")]
    internal class ReplaceTerrainDecalsCommand : Command
    {
        [CommandArgument(Description = "The name of the TerrainDecals resource to replace (must exist in a mounted game).")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Description = "The path to the JSON file containing the new TerrainDecals data.")]
        public FileInfo? FilePath { get; set; }

        [CommandArgument(Description = "Optional: raise/lower the WATER geometry to this absolute Y height (flat sea). Edits each water block's bbox Y and each water vertex's packed half-float Y in-engine, so you don't have to touch the JSON. Omit to keep the JSON's water as-is.", Optional = true)]
        public float WaterHeight { get; set; } = float.NaN;

        [CommandArgument(Description = "Optional: only raise water blocks whose surfaceShaderName EQUALS this (case-insensitive, exact), e.g. the ocean shader, so pool/puddle blocks that share the .decals are left alone. Exact (not substring) so a shader that is a PREFIX of another (e.g. '.../Water' vs '.../WaterPool') doesn't bleed across. Omit to raise all water blocks.", Optional = true)]
        public string? WaterShader { get; set; }

        // Wraps the original resource variant (type/meta/id) but serves NEW bytes from memory.
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

            // Prefer a cas variant in a cas build, but fall back to ANY bundle-contained variant
            // so DLC resources (often non-cas/inline) still resolve in a cas build.
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

            // Optional in-engine WATER-height raise: set the flat sea to an absolute Y.
            // The water geom's positions are packed half-floats (Position[1] = Y), and each
            // block carries float bboxes (Y at index 1 = min, 4 = max). Done here in C# so the
            // caller can feed the unmodified dump JSON and just pass --WaterHeight.
            if (!float.IsNaN(WaterHeight))
            {
                var s_Water = s_Decals.GeometryWater;
                var s_YBits = BitConverter.HalfToUInt16Bits((Half)WaterHeight);
                var s_Filter = string.IsNullOrWhiteSpace(WaterShader) ? null : WaterShader;
                // When filtering by shader, only the vertices used by matching blocks are raised.
                var s_RaiseVert = s_Water.WaterVertices != null ? new bool[s_Water.WaterVertices.Count] : null;
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
                    if (s_RaiseVert != null)
                        for (var v = (int)s_Block.VertexBegin; v < (int)s_Block.VertexEnd && v < s_RaiseVert.Length; v++)
                            s_RaiseVert[v] = true;
                }
                var s_VertCount = 0;
                if (s_Water.WaterVertices != null)
                {
                    for (var v = 0; v < s_Water.WaterVertices.Count; v++)
                    {
                        if (s_Filter != null && (s_RaiseVert == null || !s_RaiseVert[v]))
                            continue;
                        s_Water.WaterVertices[v].Position[1] = s_YBits;
                        s_VertCount++;
                    }
                }
                p_Writer.WriteLine($"Raised WATER geometry to Y={WaterHeight} ({s_BlockCount} blocks, {s_VertCount} vertices{(s_Filter != null ? $", shader~='{s_Filter}'" : "")}).");
            }

            var s_Converter = EngineInterfaceRegistry.Create<ITerrainDecalsConverter>(s_ContextEngineType);

            byte[] s_Bytes;
            using (var s_Ms = new MemoryStream())
            {
                using (var s_W = new RimeWriter(s_Ms, p_ShouldDispose: false))
                    s_Converter.Write(s_W, s_Decals);
                s_Bytes = s_Ms.ToArray();
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
