using System;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using static RimeLib.Content.Mounting.PayloadStream;

namespace RimeLib.Content.Frostbite2013_2
{
    /// <summary>
    /// The dependencies Frostbite 2013.2 terrain resources name inside their payloads. Each payload
    /// is walked to its last byte, which is what checks the layout.
    /// </summary>
    public class ResourcePayloadReader : IResourcePayloadReader
    {
        public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2013_2 };

        public bool Handles(ResourceType p_Type)
        {
            return p_Type == ResourceType.VisualTerrain
                || p_Type == ResourceType.TerrainLayerCombinations
                || p_Type == ResourceType.TerrainDecals
                || p_Type == ResourceType.TerrainStreamingTree;
        }

        public ResourcePayloadNames Read(ResourceType p_Type, byte[] p_Data) => Walk(p_Data, true, (p_Reader, p_Result) =>
        {
            switch (p_Type)
            {
                case ResourceType.VisualTerrain:
                    ReadVisualTerrain(p_Reader, p_Result);
                    break;
                case ResourceType.TerrainLayerCombinations:
                    ReadLayerCombinations(p_Reader, p_Result);
                    break;
                case ResourceType.TerrainDecals:
                    ReadDecals(p_Reader, p_Result);
                    break;
                case ResourceType.TerrainStreamingTree:
                    ReadStreamingTree(p_Reader, p_Result);
                    break;
            }
        });

        // Cell, patch, atlas and texture detail tuning, as in Frostbite 2 but with more fields and
        // no surface shader name after them.
        private const int c_VisualTerrainHeaderSize = 0x54;

        // From the mesh resource id up to the texture atlas size: ids, density, scale, wind,
        // flags, spawn level counts, shadow distance, lod distances.
        private const int c_ScatteringFixedSize = 133;

        /// <summary>The meshes its layers scatter; everything else it uses EBX references by id.</summary>
        private static void ReadVisualTerrain(RimeReader p_Reader, ResourcePayloadNames p_Result)
        {
            p_Reader.Seek(c_VisualTerrainHeaderSize, SeekOrigin.Begin);

            var s_LayerCount = ReadCount(p_Reader, "VisualTerrain terrainLayerCount", 256);
            for (var i = 0u; i < s_LayerCount; ++i)
            {
                var s_TypeCount = ReadCount(p_Reader, "VisualTerrain meshScatteringTypeCount", 256);
                for (var j = 0u; j < s_TypeCount; ++j)
                {
                    // Bound as a MeshSet resource and as a MeshAsset partition, as in Frostbite 2.
                    var s_MeshName = ReadCString(p_Reader);
                    AddName(p_Result.ResourceNames, s_MeshName);
                    AddName(p_Result.PartitionNames, s_MeshName);

                    p_Reader.Seek(c_ScatteringFixedSize, SeekOrigin.Current);

                    // An atlas of more than one tile carries a cumulative weight per tile and their max.
                    var s_Tiles = (ulong)p_Reader.ReadUInt32() * p_Reader.ReadUInt32();
                    if (s_Tiles > 0xFFFF)
                        throw new InvalidDataException($"a scattering texture atlas of {s_Tiles} tiles, the walk is misaligned");
                    if (s_Tiles > 1)
                        p_Reader.Seek((long)(s_Tiles + 1) * 4, SeekOrigin.Current);

                    // Spawn level, rotation and orientation mode, slope weight, billboarding,
                    // instance data mode, ground clamp.
                    p_Reader.Seek(10, SeekOrigin.Current);
                }
            }
        }

        private static void ReadLayerCombinations(RimeReader p_Reader, ResourcePayloadNames p_Result)
        {
            AddName(p_Result.PartitionNames, ReadCString(p_Reader)); // defaultTerrainSurfaceShader
            p_Reader.ReadByte();

            var s_DrawCount = ReadCount(p_Reader, "TerrainLayerCombinations drawCount", 0xFFFF);
            for (var i = 0u; i < s_DrawCount; ++i)
            {
                SkipByteArray(p_Reader, "terrainLayerIndices");

                var s_MaskScaleCount = ReadCount(p_Reader, "meshScatteringMaskScaleDrawMethodCount", 256);
                p_Reader.ReadByte(); // meshScatteringMaskScaleLevelEnd
                for (var j = 0u; j < s_MaskScaleCount; ++j)
                {
                    SkipByteArray(p_Reader, "maskedTerrainLayerIndices");
                    SkipByteArray(p_Reader, "outputLayerOrder");
                    AddName(p_Result.PartitionNames, ReadCString(p_Reader));
                    p_Reader.ReadByte(); // level
                }

                var s_2dCount = ReadCount(p_Reader, "surface2dDrawMethodCount", 256);
                for (var j = 0u; j < s_2dCount; ++j)
                {
                    p_Reader.ReadUInt32(); // drawPassType
                    SkipByteArray(p_Reader, "maskedTerrainLayerIndices");
                    AddName(p_Result.PartitionNames, ReadCString(p_Reader));
                }

                var s_3dCount = ReadCount(p_Reader, "surface3dDrawMethodCount", 256);
                for (var j = 0u; j < s_3dCount; ++j)
                {
                    SkipByteArray(p_Reader, "maskedTerrainLayerIndices");
                    AddName(p_Result.PartitionNames, ReadCString(p_Reader));
                    p_Reader.Seek(2, SeekOrigin.Current); // level, drawDirectLayerCount
                }
            }
        }

        // Start index, primitive count, two bounding boxes, draw distance, vertex range, tangent space flag.
        private const int c_DecalBlockFixedSize = 4 + 4 + 2 * 24 + 4 + 4 + 4 + 1;

        private static void ReadDecals(RimeReader p_Reader, ResourcePayloadNames p_Result)
        {
            // 3d far and 2d near draw distance, cells per heightfield tile side, destruction mask.
            p_Reader.Seek(4 + 4 + 4 + 1, SeekOrigin.Begin);

            // 2d, 3d and water geometry.
            for (var i = 0; i < 3; ++i)
            {
                var s_BlockCount = ReadCount(p_Reader, "TerrainDecals blockCount", 0xFFFF);
                if (s_BlockCount == 0)
                    continue;

                for (var j = 0u; j < s_BlockCount; ++j)
                {
                    AddName(p_Result.PartitionNames, ReadCString(p_Reader)); // surface shader
                    AddName(p_Result.PartitionNames, ReadCString(p_Reader)); // z-only surface shader
                    AddName(p_Result.PartitionNames, ReadCString(p_Reader)); // mesh scattering mask shader
                    p_Reader.Seek(c_DecalBlockFixedSize, SeekOrigin.Current);
                }

                var s_VertexBytes = p_Reader.ReadUInt32();
                var s_IndexBytes = p_Reader.ReadUInt32();
                if ((long)s_VertexBytes + s_IndexBytes > p_Reader.Length - p_Reader.Position)
                    throw new InvalidDataException($"decal geometry of {s_VertexBytes} + {s_IndexBytes} byte(s) overruns the payload");
                p_Reader.Seek((long)s_VertexBytes + s_IndexBytes, SeekOrigin.Current);
            }
        }

        /// <summary>Frostbite 2's streaming tree with the skip level count before the node count.</summary>
        private static void ReadStreamingTree(RimeReader p_Reader, ResourcePayloadNames p_Result)
        {
            p_Reader.Seek(4, SeekOrigin.Current); // unblurredSamplesPerNodeSidePot
            p_Reader.Seek(1, SeekOrigin.Current); // trackTextureDetailFalloff
            p_Reader.Seek(8, SeekOrigin.Current); // invisible/occludedDetailReductionFactor
            p_Reader.Seek(4, SeekOrigin.Current); // resourceBlurriness
            p_Reader.Seek(4, SeekOrigin.Current); // skipLevels

            var s_NodeCount = ReadCount(p_Reader, "TerrainStreamingTree nodeCount");

            p_Reader.Seek(1, SeekOrigin.Current); // freeStreamingEnabled

            // Raster tree blocks, each with its own length; 0xFF ends the list.
            while (true)
            {
                if (p_Reader.Position >= p_Reader.Length)
                    throw new InvalidDataException("payload ended inside the raster tree list");

                if (p_Reader.ReadByte() == 0xFF)
                    break;

                var s_Size = p_Reader.ReadUInt32();
                if (s_Size > p_Reader.Length - p_Reader.Position)
                    throw new InvalidDataException($"raster tree block of {s_Size} byte(s) overruns the payload");

                p_Reader.Seek(s_Size, SeekOrigin.Current);
            }

            var s_Read = 0u;
            ReadStreamingTreeNode(p_Reader, p_Result, s_NodeCount, ref s_Read);
        }

        private static void ReadStreamingTreeNode(RimeReader p_Reader, ResourcePayloadNames p_Result, uint p_NodeCount, ref uint p_Read)
        {
            if (++p_Read > p_NodeCount)
                throw new InvalidDataException($"the walk passed the {p_NodeCount} declared node(s)");

            // A lod without tile data has size 0, and the loader skips its id.
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
    }
}
