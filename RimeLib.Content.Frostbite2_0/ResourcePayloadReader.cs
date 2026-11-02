using System;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System.IO;
using static RimeLib.Content.Mounting.PayloadStream;

namespace RimeLib.Content.Frostbite2_0
{
    /// <summary>
    /// The dependencies Frostbite 2 resources name inside their own payloads.
    ///
    /// These four types are byte-packed sequential `fb::InStream` deserializations, unlike the
    /// memory-mapped MeshSet and DxTexture structs. There is no header, no relocation table, no
    /// alignment padding, and no fixed offset past the first variable-length field. A reader has to
    /// walk the payload instead of indexing into it.
    ///
    /// Conventions beyond <see cref="PayloadStream"/>: `bool` is one byte, and `LinearTransform` is
    /// 48 bytes in the stream, not 64 (the w of each row is skipped).
    /// </summary>
    public class ResourcePayloadReader : IResourcePayloadReader
    {
        public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

        public bool Handles(ResourceType p_Type)
        {
            return p_Type == ResourceType.Terrain
                || p_Type == ResourceType.VisualTerrain
                || p_Type == ResourceType.TerrainStreamingTree
                || p_Type == ResourceType.EnlightenDatabase;
        }

        // The walks stop once the names are read, so they don't have to reach the payload's end.
        public ResourcePayloadNames Read(ResourceType p_Type, byte[] p_Data) => Walk(p_Data, false, (p_Reader, p_Result) =>
        {
            switch (p_Type)
            {
                case ResourceType.Terrain:
                    ReadTerrain(p_Reader, p_Result);
                    break;
                case ResourceType.VisualTerrain:
                    ReadVisualTerrain(p_Reader, p_Result);
                    break;
                case ResourceType.TerrainStreamingTree:
                    ReadTerrainStreamingTree(p_Reader, p_Result);
                    break;
                case ResourceType.EnlightenDatabase:
                    ReadEnlightenDatabase(p_Reader, p_Result);
                    break;
            }
        });

        /// <summary>One string is the entire payload the engine reads.</summary>
        private static void ReadTerrain(RimeReader p_Reader, ResourcePayloadNames p_Result)
        {
            AddResource(p_Result, ReadCString(p_Reader));
        }

        private static void ReadVisualTerrain(RimeReader p_Reader, ResourcePayloadNames p_Result)
        {
            // 15 four-byte scalars of cell, patch, atlas and falloff tuning, none of them
            // dependencies. The shader name below starts at exactly 0x3C, measured against MP_007's
            // payload and confirmed across all 33 shipped payloads.
            p_Reader.Seek(0x3C, SeekOrigin.Begin);

            // defaultTerrainSurfaceShader. A shader name, not a resource, so it is read only to skip
            // past it.
            ReadCString(p_Reader);

            // The mesh scattering types nest one level under the terrain layers, so there is no
            // single flat count. The flat MeshScatteringFixup vector in the PDB is the runtime shape
            // and is not in the stream.
            var s_LayerCount = ReadCount(p_Reader, "VisualTerrain terrainLayerCount");
            for (var i = 0u; i < s_LayerCount; ++i)
            {
                p_Reader.ReadByte(); // virtualTextureEnable

                var s_TypeCount = ReadCount(p_Reader, "VisualTerrain meshScatteringTypeCount");
                for (var j = 0u; j < s_TypeCount; ++j)
                {
                    // Bound twice by VisualTerrain::postLoad: as a MeshSet resource, and as a MeshAsset
                    // EBX container whose variation hash then goes to the MeshVariationManager.
                    var s_MeshName = ReadCString(p_Reader);
                    AddResource(p_Result, s_MeshName);
                    if (s_MeshName.Length > 0)
                        p_Result.PartitionNames.Add(s_MeshName);

                    // variationAssetNameHash plus 21 scalars of density, scale, rotation and shadow
                    // tuning. Byte-packed, so this is not a multiple of 4.
                    p_Reader.Seek(70, SeekOrigin.Current);
                }
            }

            AddResource(p_Result, ReadCString(p_Reader)); // streamingTreeResourceName
            AddResource(p_Result, ReadCString(p_Reader)); // decalsResourceName
        }

        /// <summary>
        /// The streaming terrain quadtree. Every node names the chunk holding its own tile data, so
        /// these chunks appear nowhere else: not in the EBX, and not through the chunkMeta mechanism
        /// that textures and meshes use. The loader keys them into its own validChunkIds map.
        /// </summary>
        private static void ReadTerrainStreamingTree(RimeReader p_Reader, ResourcePayloadNames p_Result)
        {
            p_Reader.Seek(4, SeekOrigin.Current); // unblurredSamplesPerNodeSidePot
            p_Reader.Seek(1, SeekOrigin.Current); // trackTextureDetailFalloff, a bool despite the name
            p_Reader.Seek(8, SeekOrigin.Current); // invisible/occludedDetailReductionFactor
            p_Reader.Seek(4, SeekOrigin.Current); // resourceBlurriness

            var s_NodeCount = ReadCount(p_Reader, "TerrainStreamingTree nodeCount");

            p_Reader.Seek(1, SeekOrigin.Current); // freeStreamingEnabled

            // Raster tree blocks. Each carries its own length so the loader can skip one whose
            // factory is not registered, which is also what lets us skip all of them. 0xFF ends
            // the list.
            while (true)
            {
                if (p_Reader.Position >= p_Reader.Length)
                    throw new Exception("payload ended inside the raster tree list");

                if (p_Reader.ReadByte() == 0xFF)
                    break;

                var s_Size = p_Reader.ReadUInt32();
                if (s_Size > p_Reader.Length - p_Reader.Position)
                    throw new Exception($"raster tree block of {s_Size} byte(s) overruns the payload");

                p_Reader.Seek(s_Size, SeekOrigin.Current);
            }

            var s_Read = 0u;
            ReadStreamingTreeNode(p_Reader, p_Result, s_NodeCount, ref s_Read);
        }

        private static void ReadStreamingTreeNode(RimeReader p_Reader, ResourcePayloadNames p_Result, uint p_NodeCount,
            ref uint p_Read)
        {
            // The tree has no index and no node count per level, so a misaligned walk would recurse
            // on garbage. The declared node count bounds it.
            if (++p_Read > p_NodeCount)
                throw new Exception($"the walk passed the {p_NodeCount} declared node(s)");

            // A zero size means the lod has no tile data, and the loader then skips the id. Emitting
            // it anyway would ask for a chunk the game never fetches.
            var s_Lod0Size = p_Reader.ReadUInt32();
            var s_Lod0Id = new GUID(p_Reader);
            if (s_Lod0Size != 0)
                AddChunk(p_Result, s_Lod0Id);

            if (p_Reader.ReadByte() != 0) // lod1Enabled
            {
                var s_Lod1Size = p_Reader.ReadUInt32();
                var s_Lod1Id = new GUID(p_Reader);
                if (s_Lod1Size != 0)
                    AddChunk(p_Result, s_Lod1Id);
            }

            p_Reader.Seek(1, SeekOrigin.Current); // persistentDedicatedServer

            if (p_Reader.ReadByte() == 0) // hasChildren
                return;

            for (var i = 0; i < 4; ++i)
                ReadStreamingTreeNode(p_Reader, p_Result, p_NodeCount, ref p_Read);
        }

        private static void ReadEnlightenDatabase(RimeReader p_Reader, ResourcePayloadNames p_Result)
        {
            // A disabled database has no payload past this byte.
            if (p_Reader.ReadByte() == 0)
                return;

            var s_DynamicDataEnable = p_Reader.ReadByte() != 0;

            p_Reader.Seek(8, SeekOrigin.Current); // outputAtlasWidth, outputAtlasHeight

            // The names are always in the stream, but postLoad binds the systems only when dynamic
            // data is on. With it off the game ships no EnlightenSystem for them, so treating them
            // as dependencies invents references that cannot resolve.
            var s_SystemCount = ReadCount(p_Reader, "EnlightenDatabase systemNameCount");
            for (var i = 0u; i < s_SystemCount; ++i)
            {
                var s_System = ReadCString(p_Reader);
                if (s_DynamicDataEnable)
                    AddResource(p_Result, s_System);
            }

            // Per lightmap: AxisAlignedBox 24, uvTransform Vec4 16, uvTranslation Vec2 8.
            var s_TerrainLightMapCount = ReadCount(p_Reader, "EnlightenDatabase terrainLightMapCount");
            p_Reader.Seek(s_TerrainLightMapCount * 48L, SeekOrigin.Current);

            // Per instance: Guid 16, LinearTransform 48, Vec4 16, Vec2 8.
            var s_InstanceCount = ReadCount(p_Reader, "EnlightenDatabase instanceCount");
            p_Reader.Seek(s_InstanceCount * 88L, SeekOrigin.Current);

            // Probe sets bind unconditionally.
            var s_ProbeSetCount = ReadCount(p_Reader, "EnlightenDatabase probeSetNameCount");
            for (var i = 0u; i < s_ProbeSetCount; ++i)
                AddResource(p_Result, ReadCString(p_Reader));

            p_Reader.Seek(4, SeekOrigin.Current); // probeCount
        }

        private static void AddResource(ResourcePayloadNames p_Result, string p_Name) => AddName(p_Result.ResourceNames, p_Name);
    }
}
