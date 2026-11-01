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
using RimeLib.Terrain.Frostbite;
using RimeLib.Terrain.Frostbite.Destruction;
using RimeLib.Terrain.Frostbite.Heightfield;
using RimeLib.Terrain.Frostbite.TerrainMask;
using RimeLib.Terrain.Frostbite.TerrainMaterial;

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
            // Optional: see HeightfieldTree.TryFindNode. A streaming node without a heightfield
            // node still carries the chunk its heights come from.
            var s_TreeNode = (HeightfieldTree as HeightfieldTree)?.TryFindNode(p_NodeId);

            if (s_TreeNode != null)
                s_Node.TreeNode = s_TreeNode;

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

        /// <summary>
        /// The exact inverse of <see cref="Deserialize(RimeReader)"/>: the header, then each raster
        /// tree as a type byte and a LENGTH followed by its payload, then the terminator, then the
        /// stream nodes.
        ///
        /// Each tree's length is measured from what its writer actually produced rather than
        /// carried over from the read, so a tree that has been edited records its new size. Getting
        /// that wrong does not fail loudly -- the loader resyncs on the declared length and reads
        /// the NEXT tree's type byte out of the middle of this one's data.
        /// </summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(UnblurredSamplesPerNodeSidePot);
            p_Writer.Write(TrackTextureDetailFalloff);
            p_Writer.Write(InvisibleDetailReductionFactor);
            p_Writer.Write(OccludedDetailReductionFactor);
            p_Writer.Write(ResourceBlurriness);
            p_Writer.Write(NodeCount);
            p_Writer.Write(FreeStreamingEnabled);

            foreach (var s_Entry in RasterTreeOrder)
            {
                byte[]? s_Payload = s_Entry.Raw;

                if (s_Payload == null)
                {
                    var s_Tree = s_Entry.Type < RasterTrees.Count ? RasterTrees[s_Entry.Type] : null;

                    if (s_Tree == null || !s_Tree.Serialize(out s_Payload) || s_Payload == null)
                        return false;
                }

                p_Writer.Write((byte)s_Entry.Type);
                p_Writer.Write((uint)s_Payload.Length);
                p_Writer.Write(s_Payload);
            }

            p_Writer.Write((byte)RasterTree.RasterTreeTypes.RasterTreeTypeInvalid);

            SaveNodes(p_Writer, RootNode);

            return true;
        }

        private static void SaveNodes(RimeWriter p_Writer, HeightfieldNode p_Node)
        {
            p_Writer.Write(p_Node.Lod0ChunkSize);

            if (!p_Node.Lod0ChunkID.Serialize(p_Writer))
                return;

            // Lod1 is optional and its flag is the only record that it was there.
            var s_Lod1 = p_Node.Lod1ChunkID != GUID.Empty || p_Node.Lod1ChunkSize != 0;
            p_Writer.Write(s_Lod1);

            if (s_Lod1)
            {
                p_Writer.Write(p_Node.Lod1ChunkSize);
                p_Node.Lod1ChunkID.Serialize(p_Writer);
            }

            p_Writer.Write(p_Node.PersistentDedicatedServer);

            var s_HasChildren = p_Node.Children != null && p_Node.Children.Length > 0;
            p_Writer.Write(s_HasChildren);

            if (!s_HasChildren)
                return;

            foreach (var s_Child in p_Node.Children!)
                SaveNodes(p_Writer, s_Child);
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        /// <summary>Every raster tree the stream announced, as (type, byte size). Diagnostic: it is
        /// the only way to tell "this level has no material tree" from "the parse lost it".</summary>
        public List<(int Type, uint Size, long Consumed)> SeenRasterTrees { get; } = new();

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

            // Capacity is not size: the loop below assigns BY INDEX, so the list has to hold the
            // slots up front or deserialising any streaming tree throws before it reads a tree.
            RasterTrees = new List<RasterTree>((int)RasterTree.RasterTreeTypes.RasterTreeTypeCount);

            for (var i = 0; i < (int)RasterTree.RasterTreeTypes.RasterTreeTypeCount; ++i)
                RasterTrees.Add(null!);

            for (; ; )
            {
                var s_RasterTreeType = (RasterTree.RasterTreeTypes)p_Reader.ReadByte();
                if (s_RasterTreeType == RasterTree.RasterTreeTypes.RasterTreeTypeInvalid)
                    break;

                var s_RasterTreeLoadSize = p_Reader.ReadUInt32();


                Debug.WriteLine("Parsing '{0}' raster tree with size '{1}'.", s_RasterTreeType, s_RasterTreeLoadSize);

                var s_InitialPosition = p_Reader.Position;
                byte[]? s_Unparsed = null;

                if (s_RasterTreeLoadSize < 1)
                    throw new InvalidDataException("Raster tree load size is invalid.");

                if (s_RasterTreeType == RasterTree.RasterTreeTypes.HeightfieldTreeType)
                {
                    // Read the block whole, as the mask tree below is. The heightfield parser stops
                    // at the root node and keeps the remainder as Trailing, which is only the
                    // heightfield's own remainder if it cannot see past the end of its block.
                    var s_HeightfieldBytes = p_Reader.ReadBytes((int)s_RasterTreeLoadSize);
                    var s_Heightfield = new HeightfieldTree();

                    s_Heightfield.Deserialize(s_HeightfieldBytes);
                    RasterTrees[(int)s_RasterTreeType] = s_Heightfield;
                }
                else if (s_RasterTreeType == RasterTree.RasterTreeTypes.TerrainMaskTreeType)
                {
                    // Read the block whole first: the mask tree's layout is still being worked out,
                    // and keeping the bytes lets a caller see what a partial parse left behind.
                    var s_MaskBytes = p_Reader.ReadBytes((int)s_RasterTreeLoadSize);
                    var s_Mask = new TerrainMaskTree { Raw = s_MaskBytes };

                    s_Mask.Deserialize(s_MaskBytes);
                    RasterTrees[(int)s_RasterTreeType] = s_Mask;
                }
                else if (s_RasterTreeType == RasterTree.RasterTreeTypes.TerrainMaterialTreeType)
                {
                    var s_MaterialBytes = p_Reader.ReadBytes((int)s_RasterTreeLoadSize);
                    var s_Material = new TerrainMaterialTree();

                    s_Material.Deserialize(s_MaterialBytes);
                    RasterTrees[(int)s_RasterTreeType] = s_Material;
                }
                else if (s_RasterTreeType == RasterTree.RasterTreeTypes.DestructionDepthTreeType)
                {
                    var s_DestructionBytes = p_Reader.ReadBytes((int)s_RasterTreeLoadSize);
                    var s_Destruction = new DestructionDepthTree();

                    s_Destruction.Deserialize(s_DestructionBytes);
                    RasterTrees[(int)s_RasterTreeType] = s_Destruction;
                }
                else
                {
                    // No parser for this type -- keep the bytes so it can be written back.
                    Debug.WriteLine("Skipping raster tree loading of type '{0}'.", s_RasterTreeType);
                    s_Unparsed = p_Reader.ReadBytes((int)s_RasterTreeLoadSize);
                }

                Debug.WriteLine("Read '{0}' bytes.", p_Reader.Position - s_InitialPosition);

                // Resync on the size the stream declared, whatever the sub-parser consumed.
                //
                // Each raster tree announces its length, and only the UNKNOWN branch above was
                // using it. A tree whose parser reads a byte too few or too many therefore
                // misaligned everything after it -- which is why a level's material tree came back
                // missing: the heightfield before it left the cursor in the wrong place, and its
                // type byte was then read out of the middle of somebody else's data.
                // Recorded after parsing so the caller can see a sub-parser that read the wrong
                // number of bytes -- silent misalignment is how the material tree came back empty.
                SeenRasterTrees.Add(((int)s_RasterTreeType, s_RasterTreeLoadSize,
                    p_Reader.Position - s_InitialPosition));
                RasterTreeOrder.Add(((int)s_RasterTreeType, s_Unparsed));

                var s_Expected = s_InitialPosition + s_RasterTreeLoadSize;

                if (p_Reader.Position != s_Expected)
                {
                    Debug.WriteLine("Raster tree '{0}' read {1} of {2} bytes; resyncing.",
                        s_RasterTreeType, p_Reader.Position - s_InitialPosition, s_RasterTreeLoadSize);

                    p_Reader.Seek(s_Expected, SeekOrigin.Begin);
                }
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
            Raw = p_Data;

            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            Deserialize(s_Reader);
        }
    }

}
