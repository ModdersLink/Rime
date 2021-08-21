using RimeLib.IO;
using System;
using System.Diagnostics;

namespace RimeLib.Terrain.Frostbite2_0
{
    public class HeightfieldTree : HeightfieldTreeBase
    {
        private HeightfieldTreeNode LoadNodes(RimeReader p_Reader, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId)
        {
            var s_Node = new HeightfieldTreeNode(p_Reader)
            {
                ID = p_NodeId
            };

            s_Node.SamplesPerMeter = DensityMapNodeSamplesPerSidePot / (s_Node.BoundingBox.Max.X - s_Node.BoundingBox.Min.X);

            LevelMax = System.Math.Max(p_NodeId.Level, LevelMax);

            var s_NodeDisabled = p_Reader.ReadBool();
            if (s_NodeDisabled)
            {
                s_Node.Flags |= 8; // What the fuck is this shit
                return s_Node;
            }

            var s_HasData1 = p_Reader.ReadBool();
            var s_HasData2 = p_Reader.ReadBool();

            if (s_HasData2)
                s_Node.Flags |= 16;
            else if (s_HasData1)
                s_Node.Flags |= 256;
            else
                return s_Node;

            var s_TempFlag1 = p_Reader.ReadBool();
            if (s_HasData2 && s_TempFlag1)
            {
                Debug.WriteLine("Has HeightfieldTree Data!");

                // TODO: Properly read data because this is just nonsense.

                s_Node.EmbeddedData = p_Reader.ReadBytes((int)(NodeSamplesPerSide * NodeSamplesPerSide * 2));

                if (MinMaxStackSize > 0)
                {
                    p_Reader.ReadBytes((int)(MinMaxStackSize * 2));
                }

                if (true) // if (m_LoadOccluderGridEnable)
                {
                    p_Reader.ReadBytes((int)(OccluderGridStackSize * 2));
                }
            }

            var s_HasChildren = p_Reader.ReadBool();

            if (!s_HasChildren)
                return s_Node;

            s_Node.Children = new RasterTreeNode[4];

            s_Node.FirstChildIndex = (ushort)p_FirstFreeNodeIndex;
            p_FirstFreeNodeIndex += 4;

            for (var i = 0; i < 4; ++i)
            {
                var s_ChildNodeId = new QuadtreeNodeId(p_NodeId);
                ++s_ChildNodeId.Level;

                s_ChildNodeId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[i] + 2 * s_ChildNodeId.IndexX);
                s_ChildNodeId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[i] + 2 * s_ChildNodeId.IndexY);

                s_Node.Children[i] = LoadNodes(p_Reader, ref p_FirstFreeNodeIndex, s_ChildNodeId);
            }

            return s_Node;
        }

        public HeightfieldTreeNode FindNode(QuadtreeNodeId p_ID)
        {
            HeightfieldTreeNode s_Node;
            FindNodeInternal(p_ID, RootNode, out s_Node);
            return s_Node;
        }

        private bool FindNodeInternal(QuadtreeNodeId p_ID, HeightfieldTreeNode p_Current, out HeightfieldTreeNode p_Result)
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

        public override bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public override bool Serialize(out byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

        public override void Deserialize(RimeReader p_Reader)
        {
            NodeSamplesPerSide = p_Reader.ReadUInt32();
            ResourceAtlasSampleCountX = p_Reader.ReadUInt32();
            ResourceAtlasSampleCountY = p_Reader.ReadUInt32();
            ResourceBlurrinessFactor = (uint)(1 << p_Reader.ReadInt32());
            WorldSizeY = p_Reader.ReadSingle();
            WorldScaleY = WorldSizeY / (float)65535.0;
            var s_PhysicsMetersPerSample = p_Reader.ReadSingle();
            var s_PhysicsCropWidth = p_Reader.ReadSingle();
            Ps3RsxHeightfieldEnable = p_Reader.ReadBool();
            Ps3RsxHeightfieldCacheFraction = p_Reader.ReadSingle();
            MinMaxStackDepth = p_Reader.ReadUInt32();
            OccluderGridStackDepth = p_Reader.ReadUInt32();
            NodeCount = p_Reader.ReadUInt32();
            PersistentNodeCount = p_Reader.ReadUInt32();
            var s_PersistentDedicatedServerNodeCount = p_Reader.ReadUInt32();

            // if ( v4->m_dedicatedServerEnable )
            {
                PersistentNodeCount += s_PersistentDedicatedServerNodeCount;
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
        }

        public override void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }

}
