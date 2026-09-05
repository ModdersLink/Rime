using RimeLib.IO;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using RimeLib.Terrain.Frostbite;
using RimeLib.Terrain.Frostbite.Heightfield;

namespace RimeLib.Terrain.Frostbite2_0
{
    public class HeightfieldTree : HeightfieldTreeBase
    {
        private HeightfieldTreeNode LoadNodes(RimeReader p_Reader, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId)
        {
            // TODO: Fix below
            //throw new NotImplementedException();
            
            var s_Node = new HeightfieldTreeNode(p_Reader)
            {
                ID = p_NodeId
            };

            s_Node.SamplesPerMeter = DensityMapNodeSamplesPerSidePot / (s_Node.BoundingBox.max.x - s_Node.BoundingBox.min.x);

            LevelMax = System.Math.Max(p_NodeId.Level, LevelMax);

            s_Node.Disabled = p_Reader.ReadBool();
            if (s_Node.Disabled)
            {
                s_Node.Flags |= 8; // the node is not in the terrain at all
                return s_Node;
            }

            s_Node.HasData1 = p_Reader.ReadBool();
            s_Node.HasData = p_Reader.ReadBool();

            if (s_Node.HasData)
                s_Node.Flags |= 16;
            else if (s_Node.HasData1)
                s_Node.Flags |= 256;
            else
                return s_Node;

            s_Node.HasPersistent = p_Reader.ReadBool();
            if (s_Node.HasData && s_Node.HasPersistent)
            {
                s_Node.EmbeddedData = p_Reader.ReadBytes((int)(NodeSamplesPerSide * NodeSamplesPerSide * 2));

                // Read rather than stepped over. These are the node's own bytes, and a writer that
                // does not have them cannot put the node back.
                if (MinMaxStackSize > 0)
                    s_Node.MinMaxData = p_Reader.ReadBytes((int)(MinMaxStackSize * 2));

                // if (m_LoadOccluderGridEnable)
                s_Node.OccluderGridData = p_Reader.ReadBytes((int)(OccluderGridStackSize * 2));
            }

            var s_HasChildren = p_Reader.ReadBool();
            if (s_HasChildren)
            {
                s_Node.Children = new RasterTreeNode[4];

                s_Node.FirstChildIndex = (ushort)p_FirstFreeNodeIndex;
                p_FirstFreeNodeIndex += 4;

                for (var i = 0; i < 4; ++i)
                {
                    var s_ChildNodeId = new QuadtreeNodeId(p_NodeId);
                    ++s_ChildNodeId.Level;

                    s_ChildNodeId.IndexX =
                        (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[i] + 2 * s_ChildNodeId.IndexX);
                    s_ChildNodeId.IndexY =
                        (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[i] + 2 * s_ChildNodeId.IndexY);

                    s_Node.Children[i] = LoadNodes(p_Reader, ref p_FirstFreeNodeIndex, s_ChildNodeId);
                }
            }

            return s_Node;
        }

        public HeightfieldTreeNode FindNode(QuadtreeNodeId p_ID)
        {
            if (!FindNodeInternal(p_ID, HeightfieldRootNode!, out var s_Node))
                throw new Exception($"Could not find node with id {p_ID}.");
            
            return s_Node;
        }

        /// <summary>
        /// The heightfield node for an id, or null where the tree has none.
        /// </summary>
        /// <remarks>
        /// A streaming tree may be deeper than the heightfield tree it accompanies: its nodes name
        /// the chunk their heights stream from, so one can exist with no heightfield node behind
        /// it. MP_017 is such a level, and demanding the node there aborts the whole read.
        /// </remarks>
        public HeightfieldTreeNode? TryFindNode(QuadtreeNodeId p_ID)
        {
            if (HeightfieldRootNode == null)
                return null;

            return FindNodeInternal(p_ID, HeightfieldRootNode, out var s_Node) ? s_Node : null;
        }

        private bool FindNodeInternal(QuadtreeNodeId p_ID, HeightfieldTreeNode p_Current, [NotNullWhen(true)] out HeightfieldTreeNode? p_Result)
        {
            p_Result = null;

            if (p_Current.ID == p_ID)
            {
                p_Result = p_Current;
                return true;
            }

            if (p_Current.Children == null)
                return false;

            foreach (var s_Child in p_Current.Children)
            {
                if (FindNodeInternal(p_ID, (HeightfieldTreeNode)s_Child, out p_Result))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// The exact inverse of <see cref="Deserialize(RimeReader)"/>.
        ///
        /// PersistentNodeCount is written back MINUS the dedicated-server count, because the reader
        /// folded the two together. Writing the field as it stands would add that count again on
        /// every round trip.
        /// </summary>
        public override bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(NodeSamplesPerSide);
            p_Writer.Write(ResourceAtlasSampleCountX);
            p_Writer.Write(ResourceAtlasSampleCountY);
            p_Writer.Write(ResourceBlurrinessFactorExponent);
            p_Writer.Write(WorldSizeY);
            p_Writer.Write(PhysicsMetersPerSample);
            p_Writer.Write(PhysicsCropWidth);
            p_Writer.Write(Ps3RsxHeightfieldEnable);
            p_Writer.Write(Ps3RsxHeightfieldCacheFraction);
            p_Writer.Write(MinMaxStackDepth);
            p_Writer.Write(OccluderGridStackDepth);
            p_Writer.Write(NodeCount);
            p_Writer.Write(PersistentNodeCount - PersistentDedicatedServerNodeCount);
            p_Writer.Write(PersistentDedicatedServerNodeCount);
            p_Writer.Write(NodeBorderWidth);

            if (RootNode is HeightfieldTreeNode s_Root)
                SaveNodes(p_Writer, s_Root);

            p_Writer.Write(Trailing);

            return true;
        }

        private static void SaveNodes(RimeWriter p_Writer, HeightfieldTreeNode p_Node)
        {
            p_Writer.Write(p_Node.BoundingBox.min.x);
            p_Writer.Write(p_Node.BoundingBox.min.y);
            p_Writer.Write(p_Node.BoundingBox.min.z);

            p_Writer.Write(p_Node.BoundingBox.max.x);
            p_Writer.Write(p_Node.BoundingBox.max.y);
            p_Writer.Write(p_Node.BoundingBox.max.z);

            p_Writer.Write(p_Node.Disabled);

            if (p_Node.Disabled)
                return;

            p_Writer.Write(p_Node.HasData1);
            p_Writer.Write(p_Node.HasData);

            if (!p_Node.HasData && !p_Node.HasData1)
                return;

            p_Writer.Write(p_Node.HasPersistent);

            if (p_Node.HasData && p_Node.HasPersistent)
            {
                p_Writer.Write(p_Node.EmbeddedData);
                p_Writer.Write(p_Node.MinMaxData);
                p_Writer.Write(p_Node.OccluderGridData);
            }

            var s_HasChildren = p_Node.Children != null && p_Node.Children.Length > 0;
            p_Writer.Write(s_HasChildren);

            if (!s_HasChildren)
                return;

            foreach (var s_Child in p_Node.Children!)
                SaveNodes(p_Writer, (HeightfieldTreeNode)s_Child);
        }

        public override bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new System.IO.MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        public override void Deserialize(RimeReader p_Reader)
        {
            NodeSamplesPerSide = p_Reader.ReadUInt32();
            ResourceAtlasSampleCountX = p_Reader.ReadUInt32();
            ResourceAtlasSampleCountY = p_Reader.ReadUInt32();
            ResourceBlurrinessFactorExponent = p_Reader.ReadInt32();
            ResourceBlurrinessFactor = (uint)(1 << ResourceBlurrinessFactorExponent);
            WorldSizeY = p_Reader.ReadSingle();
            WorldScaleY = WorldSizeY / (float)65535.0;
            PhysicsMetersPerSample = p_Reader.ReadSingle();
            PhysicsCropWidth = p_Reader.ReadSingle();
            Ps3RsxHeightfieldEnable = p_Reader.ReadBool();
            Ps3RsxHeightfieldCacheFraction = p_Reader.ReadSingle();
            MinMaxStackDepth = p_Reader.ReadUInt32();
            OccluderGridStackDepth = p_Reader.ReadUInt32();
            NodeCount = p_Reader.ReadUInt32();
            PersistentNodeCount = p_Reader.ReadUInt32();
            PersistentDedicatedServerNodeCount = p_Reader.ReadUInt32();

            // if ( v4->m_dedicatedServerEnable )
            {
                PersistentNodeCount += PersistentDedicatedServerNodeCount;
            }

            NodeBorderWidth = p_Reader.ReadUInt32();

            MinMaxStackSize = 0;

            var s_CurrentDepth = (1 << ((int)MinMaxStackDepth - 1));

            for (var i = 0; i < MinMaxStackDepth; ++i)
                MinMaxStackSize += (uint)((s_CurrentDepth >> i) * (s_CurrentDepth >> i) * 2);

            OccluderGridStackSize = 0;
            var s_NewCurrentDepth = (1 << (int)(OccluderGridStackDepth - 1));

            for (var i = 0; i < OccluderGridStackDepth; ++i)
            {
                var s_V12 = (s_NewCurrentDepth >> i) + 1;
                OccluderGridStackSize += (uint)(s_V12 * s_V12);
            }

            var s_NodeId = new QuadtreeNodeId
            {
                Level = 0,
                IndexX = 0,
                IndexY = 0
            };

            uint s_FirstIndex = 1;
            RootNode = LoadNodes(p_Reader, ref s_FirstIndex, s_NodeId);

            // Whatever the block still holds past the root node. Nothing here claims to know what
            // it is; keeping it is what lets the tree be written back unchanged, and its length is
            // the honest measure of how much of the format is still unread.
            if (p_Reader.CanSeek && p_Reader.Length > p_Reader.Position)
                Trailing = p_Reader.ReadBytes((int)(p_Reader.Length - p_Reader.Position));
        }

        public override void Deserialize(byte[] p_Data)
        {
            Raw = p_Data;

            using var s_Reader = new RimeReader(new System.IO.MemoryStream(p_Data));
            Deserialize(s_Reader);
        }
    }

}
