using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace RimeLib.Terrain.Frostbite3
{
    public class TerrainStreamingTree : TerrainStreamingTreeBase, IFbSerializable
    {
        private void LoadNodes(RimeReader p_Reader, uint p_NodeIndex, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId)
        {
            var s_Lod0ChunkSize = p_Reader.ReadUInt32();
            var s_Lod0ChunkId = new GUID(p_Reader);

            var s_Lod1Enabled = p_Reader.ReadBool();

            if (s_Lod1Enabled)
            {
                var s_Lod1ChunkSize = p_Reader.ReadUInt32();
                var s_Lod1ChunkId = new GUID(p_Reader);
            }

            var s_PersistentDedicatedServer = p_Reader.ReadBool();

            var s_HasChildren = p_Reader.ReadBool();

            if (s_HasChildren)
            {
                var s_FirstChildIndex = p_FirstFreeNodeIndex;
                s_FirstChildIndex += 4;

                var s_V18 = 0;

                do
                {
                    var s_ChildNodeId = new QuadtreeNodeId(p_NodeId);
                    ++s_ChildNodeId.Level;

                    s_ChildNodeId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[s_V18] + 2 * s_ChildNodeId.IndexX);
                    s_ChildNodeId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[s_V18] + 2 * s_ChildNodeId.IndexY);

                    LoadNodes(p_Reader, (uint)(s_V18 + s_FirstChildIndex), ref p_FirstFreeNodeIndex, s_ChildNodeId);
                    ++s_V18;
                }
                while (s_V18 < 4);
            }
        }

        public void Deserialize(RimeReader p_Reader)
        {
            var s_StartPosition = p_Reader.Position;

            UnblurredSamplesPerNodeSidePot = p_Reader.ReadUInt32();
            TrackTextureDetailFalloff = p_Reader.ReadBool();
            InvisibleDetailReductionFactor = p_Reader.ReadSingle();
            OccludedDetailReductionFactor = p_Reader.ReadSingle();
            ResourceBlurriness = p_Reader.ReadUInt32();
            var s_Unknown01 = p_Reader.ReadUInt32(); // Warsaw Addition
            NodeCount = p_Reader.ReadUInt32();
            FreeStreamingEnabled = p_Reader.ReadBool();

            RasterTrees = new List<RasterTree>();

            for (var i = 0; i < (int)RasterTree.RasterTreeTypes.RasterTreeTypeCount; ++i)
                RasterTrees.Add(null);

            for (; ; )
            {
                var s_RasterTreeType = (RasterTree.RasterTreeTypes)p_Reader.ReadByte();
                if (s_RasterTreeType == RasterTree.RasterTreeTypes.RasterTreeTypeInvalid)
                    break;

                var s_RasterTreeLoadSize = p_Reader.ReadUInt32();

                Debug.WriteLine("Parsing '{0}' raster tree with size '{1}'.", s_RasterTreeType, s_RasterTreeLoadSize);

                var s_InitialPosition = p_Reader.Position;

                if (s_RasterTreeLoadSize < 1)
                    throw new InvalidDataException("Raster tree load size is invalid.");

                if (s_RasterTreeType == RasterTree.RasterTreeTypes.HeightfieldTreeType)
                {
                    RasterTrees[(int)s_RasterTreeType] = new HeightfieldTree();
                    RasterTrees[(int)s_RasterTreeType].Deserialize(p_Reader);
                }
                else if (s_RasterTreeType == RasterTree.RasterTreeTypes.TerrainMaterialTreeType)
                {
                    RasterTrees[(int)s_RasterTreeType] = new TerrainMaterialTree();
                    RasterTrees[(int)s_RasterTreeType].Deserialize(p_Reader);
                }
                else if (s_RasterTreeType == RasterTree.RasterTreeTypes.DestructionDepthTreeType)
                {
                    RasterTrees[(int)s_RasterTreeType] = new DestructionDepthTree();
                    RasterTrees[(int)s_RasterTreeType].Deserialize(p_Reader);
                }
                else
                {
                    Debug.WriteLine("Skipping raster tree loading of type '{0}'.", s_RasterTreeType);
                    p_Reader.Seek(s_RasterTreeLoadSize, SeekOrigin.Current);
                }

                Debug.WriteLine("Read '{0}' bytes.", p_Reader.Position - s_InitialPosition);
            }

            var s_RootNode = new QuadtreeNodeId()
            {
                IndexY = 0,
                IndexX = 0,
                Level = 0
            };

            var s_RasterTreeNodeIndices = new ushort[] { 0xFFFF, 0xFFFF, 0xFFFF };
            for (var l_Index = 0; l_Index < s_RasterTreeNodeIndices.Length; ++l_Index)
            {

            }

            uint s_FirstFreeNodeIndex = 1;
            LoadNodes(p_Reader, 0, ref s_FirstFreeNodeIndex, s_RootNode);

            Debug.WriteLine("Read {0} out of {1} bytes.", p_Reader.Position - s_StartPosition, p_Reader.BaseStream.Length - s_StartPosition);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

        bool IFbSerializable.Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new NotImplementedException();
        }
    }

}
