using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Terrain.Frostbite2_0
{
    public class TerrainStreamingTree : TerrainStreamingTreeBase, IFbSerializable
    {

        private HeightfieldNode LoadNodes(RimeReader p_Reader, uint p_NodeIndex, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId)
        {
            var s_Node = new HeightfieldNode();

            s_Node.ID = p_NodeId;
            s_Node.Lod0ChunkSize = p_Reader.ReadUInt32();
            s_Node.Lod0ChunkID = new GUID(p_Reader);
            s_Node.TreeNode = (GetHeightfieldTree() as HeightfieldTree)!.FindNode(p_NodeId);

            var s_Lod1Enabled = p_Reader.ReadBool();

            if (s_Lod1Enabled)
            {
                s_Node.Lod1ChunkSize = p_Reader.ReadUInt32();
                s_Node.Lod1ChunkID = new GUID(p_Reader);
            }

            s_Node.PersistentDedicatedServer = p_Reader.ReadBool();

            var s_HasChildren = p_Reader.ReadBool();

            if (!s_HasChildren)
                return s_Node;

            // Parse children nodes.
            s_Node.Children = new HeightfieldNode[4];

            var s_FirstChildIndex = p_FirstFreeNodeIndex + 4;
            s_FirstChildIndex += 4;

            for (var i = 0; i < 4; ++i)
            {
                var s_ChildNodeId = new QuadtreeNodeId(p_NodeId);
                ++s_ChildNodeId.Level;

                s_ChildNodeId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[i] + 2 * s_ChildNodeId.IndexX);
                s_ChildNodeId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[i] + 2 * s_ChildNodeId.IndexY);

                s_Node.Children[i] = LoadNodes(p_Reader, (uint)(i + s_FirstChildIndex), ref p_FirstFreeNodeIndex, s_ChildNodeId);
            }

            return s_Node;
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            var s_StartPosition = p_Reader.Position;

            UnblurredSamplesPerNodeSidePot = p_Reader.ReadUInt32();
            TrackTextureDetailFalloff = p_Reader.ReadBool();
            InvisibleDetailReductionFactor = p_Reader.ReadSingle();
            OccludedDetailReductionFactor = p_Reader.ReadSingle();
            ResourceBlurriness = p_Reader.ReadUInt32();
            NodeCount = p_Reader.ReadUInt32();
            FreeStreamingEnabled = p_Reader.ReadBool();

            RasterTrees = new List<RasterTree>();

            /*for (var i = 0; i < (int)RasterTree.RasterTreeTypes.RasterTreeTypeCount; ++i)
                RasterTrees.Add(null);*/

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
            RootNode = LoadNodes(p_Reader, 0, ref s_FirstFreeNodeIndex, s_RootNode);

            Debug.WriteLine("Read {0} out of {1} bytes.", p_Reader.Position - s_StartPosition, p_Reader.BaseStream.Length - s_StartPosition);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }

}
