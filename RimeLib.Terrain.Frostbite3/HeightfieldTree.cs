using RimeLib.IO;
using System.Diagnostics;

namespace RimeLib.Terrain.Frostbite3
{
    public class HeightfieldTree : HeightfieldTreeBase
    {
        private void LoadNodes(RimeReader p_Reader, uint p_NodeIndex, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId)
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
                return;
            }

            var s_HasData1 = p_Reader.ReadBool();
            var s_HasData2 = p_Reader.ReadBool();

            if (s_HasData2)
                s_Node.Flags |= 16;
            else if (s_HasData1)
                s_Node.Flags |= 256;
            else
                return;

            // Warsaw addition
            s_Node.PartialNonPhysics = p_Reader.ReadBool();

            var s_TempFlag1 = p_Reader.ReadBool();
            if (s_HasData2 && s_TempFlag1)
            {
                Debug.WriteLine("Has HeightfieldTree Data!");

                // TODO: Properly read data because this is just nonsense.

                for (int i = 0; i < NodeSamplesPerSide; ++i)
                {
                    p_Reader.ReadBytes((int)(NodeSamplesPerSide * 2));
                }

                if (MinMaxStackSize > 0)
                {
                    p_Reader.ReadBytes((int)(MinMaxStackSize * 2));
                }

                if (true) // if (m_LoadOccluderGridEnable)
                {
                    p_Reader.ReadBytes((int)(OccluderGridStackSize * 2));
                }

                for (var i = 0; i < DensityMapNodeSamplesPerSide; ++i)
                {
                    p_Reader.ReadBytes((int)DensityMapNodeSamplesPerSide);
                }
            }
            // Warsaw Addition
            else if (s_HasData1 && MinMaxStackSize > 0)
            {
                Debug.WriteLine("Reading {0} bytes of whatever this is data.", MinMaxStackSize * 2);
                p_Reader.ReadBytes((int)(2 * MinMaxStackSize));
            }

            var s_TempFlag2 = p_Reader.ReadBool();

            if (s_TempFlag2)
            {
                FirstChildIndex = (ushort)p_FirstFreeNodeIndex;
                p_FirstFreeNodeIndex += 4;

                var s_V14 = 0;

                do
                {
                    var s_ChildNodeId = new QuadtreeNodeId(p_NodeId);
                    ++s_ChildNodeId.Level;

                    s_ChildNodeId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[s_V14] + 2 * s_ChildNodeId.IndexX);
                    s_ChildNodeId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[s_V14] + 2 * s_ChildNodeId.IndexY);

                    LoadNodes(p_Reader, (uint)(s_V14 + FirstChildIndex), ref p_FirstFreeNodeIndex, s_ChildNodeId);
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

            // Warsaw Addition
            DensityMapNodeSamplesPerSide = p_Reader.ReadUInt32();
            DensityMapBorderWidth = p_Reader.ReadUInt32();
            DensityMapNodeSamplesPerSidePot = p_Reader.ReadUInt32();
            DensityMapResolutionRatio = p_Reader.ReadSingle();

            NodeCount = p_Reader.ReadUInt32();
            PersistentNodeCount = p_Reader.ReadUInt32();
            var s_PersistentDedicatedServerNodeCount = p_Reader.ReadUInt32();

            // if ( v4->m_dedicatedServerEnable )
            {
                PersistentNodeCount += s_PersistentDedicatedServerNodeCount;
            }

            // Warsaw only
            var s_Unknown00 = p_Reader.ReadUInt32(); // v4 + 224

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
            LoadNodes(p_Reader, 0, ref s_FirstIndex, s_NodeId);
        }

        public override void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }

}
