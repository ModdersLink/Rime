using RimeLib.Frostbite.Containers;
using RimeLib.IO;
using System;

namespace RimeLib.Terrain
{
    public class DestructionDepthTree : RasterTree
    {
        public uint NodeSamplesPerSide { get; set; }
        public uint BlurrinessFactor { get; set; }
        public uint NodeCount { get; set; }
        public uint PersistentNodeCount { get; set; }
        public uint LevelMax { get; set; }
        public uint NodeBorderWidth { get; set; }

        public uint NodeSamplesPerSidePot { get; set; }

        private void LoadNodes(RimeReader p_Reader, uint p_NodeIndex, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId, AxisAlignedBox2 p_NodeCoverage)
        {
            var s_NodeHasData = p_Reader.ReadBool();

            if (s_NodeHasData)
            {
                // s_Node.m_Flags |= 0x10;
            }

            var s_NodeHasPersistent = p_Reader.ReadBool();

            if (s_NodeHasData && s_NodeHasPersistent)
            {
                // TODO: Proper node parsing.

                var s_RleDataSize = p_Reader.ReadUInt32();
                var s_RleData = p_Reader.ReadBytes((int)s_RleDataSize);

                for (var i = 0; i < NodeSamplesPerSide; ++i)
                {
                    var s_LineSize = p_Reader.ReadUInt16();
                }
            }

            var s_HasChildren = p_Reader.ReadBool();

            if (s_HasChildren)
            {
                // s_Node.m_FirstChildIndex = p_FirstFreeNodeIndex;
                var s_FirstChildIndex = p_FirstFreeNodeIndex;
                p_FirstFreeNodeIndex += 4;

                var s_V14 = 0;

                // TODO: Verify this is correct.
                float s_ChildNodeWidth = (float)((p_NodeCoverage.Min.Y - p_NodeCoverage.Min.X) * 0.5);

                do
                {
                    var s_ChildNodeId = new QuadtreeNodeId(p_NodeId);
                    ++s_ChildNodeId.Level;

                    s_ChildNodeId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[s_V14] + 2 * s_ChildNodeId.IndexX);
                    s_ChildNodeId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[s_V14] + 2 * s_ChildNodeId.IndexY);

                    var s_ChildCoverage = new AxisAlignedBox2();

                    // TODO: Verify these are correct.
                    s_ChildCoverage.Min = new Vec2(
                            QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[s_V14] * s_ChildNodeWidth + p_NodeCoverage.Min.X,
                            QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[s_V14] * s_ChildNodeWidth + p_NodeCoverage.Min.Y);

                    s_ChildCoverage.Max = new Vec2(
                        s_ChildCoverage.Min.X + s_ChildNodeWidth,
                        s_ChildCoverage.Min.Y + s_ChildNodeWidth);

                    LoadNodes(p_Reader, (uint)(s_V14 + s_FirstChildIndex), ref p_FirstFreeNodeIndex, s_ChildNodeId, s_ChildCoverage);
                    ++s_V14;
                } while (s_V14 < 4);
            }
        }

        public override bool Serialize(out byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

        public override void Deserialize(RimeReader p_Reader)
        {
            NodeSamplesPerSide = p_Reader.ReadUInt32();

            var s_Blurriness = p_Reader.ReadInt32();
            BlurrinessFactor = (uint)(1 << s_Blurriness);

            var s_TreeCoverage = new AxisAlignedBox2(p_Reader);

            NodeCount = p_Reader.ReadUInt32();
            PersistentNodeCount = p_Reader.ReadUInt32();
            LevelMax = p_Reader.ReadUInt32();
            NodeBorderWidth = p_Reader.ReadUInt32();

            NodeSamplesPerSidePot = NodeSamplesPerSide - (2 * NodeBorderWidth) - 1;

            var s_RootNodeId = new QuadtreeNodeId
            {
                Level = 0,
                IndexX = 0,
                IndexY = 0
            };

            uint s_FirstFreeNodeIndex = 1;

            LoadNodes(p_Reader, 0, ref s_FirstFreeNodeIndex, s_RootNodeId, s_TreeCoverage);
        }

        public override void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

        public override bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }
    }

}
