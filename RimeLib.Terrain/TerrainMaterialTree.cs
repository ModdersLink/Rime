using RimeLib.Frostbite.Containers;
using RimeLib.IO;
using System.Collections.Generic;

namespace RimeLib.Terrain
{
    public class TerrainMaterialTree : RasterTree
    {
        public uint NodeSamplesPerSide { get; set; }
        public uint BlurrinessFactor { get; set; }
        public uint NodeCount { get; set; }
        public uint PersistentNodeCount { get; set; }
        public uint LevelMax { get; set; }
        public List<uint> MaterialPairIndices { get; set; } = new List<uint>();
        public uint BackgroundMaterialIndex { get; set; }

        public Vec2 CoverageMin { get; set; } = new Vec2();
        public uint NodeGridCellsPerSide { get; set; }
        public float VirtualSamplesPerMeter { get; set; }
        public uint VirtualRasterSampleIndexMax { get; set; }

        private void LoadNodes(RimeReader p_Reader, uint p_NodeIndex, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId, AxisAlignedBox2 p_NodeCoverage)
        {
            var s_TempFlag1 = p_Reader.ReadBool();

            if (s_TempFlag1)
            {
                // s_Node.m_Flags |= 0x10;
            }

            var s_TempFlag2 = p_Reader.ReadBool();

            if (s_TempFlag1 && s_TempFlag2)
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

            var s_Blurriness = p_Reader.ReadInt32();
            BlurrinessFactor = (uint)(1 << s_Blurriness);

            var s_TreeCoverage = new AxisAlignedBox2(p_Reader);

            NodeCount = p_Reader.ReadUInt32();
            PersistentNodeCount = p_Reader.ReadUInt32();
            LevelMax = p_Reader.ReadUInt32();

            CoverageMin = new Vec2(s_TreeCoverage.Min.X, s_TreeCoverage.Min.Y);
            NodeGridCellsPerSide = (uint)(1 << (int)LevelMax);
            VirtualSamplesPerMeter = ((float)NodeGridCellsPerSide * (float)NodeSamplesPerSide) /
                                     (s_TreeCoverage.Max.X - s_TreeCoverage.Max.Y);
            VirtualRasterSampleIndexMax = (NodeGridCellsPerSide * NodeSamplesPerSide) - 1;

            var s_RootNodeId = new QuadtreeNodeId
            {
                Level = 0,
                IndexX = 0,
                IndexY = 0
            };

            uint s_FirstFreeNodeIndex = 0;

            LoadNodes(p_Reader, 0, ref s_FirstFreeNodeIndex, s_RootNodeId, s_TreeCoverage);

            var s_MaterialPairCount = p_Reader.ReadUInt32();

            MaterialPairIndices = new List<uint>();
            for (int i = 0; i < s_MaterialPairCount; ++i)
                MaterialPairIndices.Add(p_Reader.ReadUInt32());

            BackgroundMaterialIndex = p_Reader.ReadUInt32();
        }

        public override void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }

}
