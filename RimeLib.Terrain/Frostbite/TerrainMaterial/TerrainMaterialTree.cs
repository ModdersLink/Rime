using fb;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Serialization.Frostbite2_0.Extensions;
using AxisAlignedBox2 = fb.AxisAlignedBox;

namespace RimeLib.Terrain.Frostbite.TerrainMaterial;
public class TerrainMaterialTree : RasterTree
{
    public uint NodeSamplesPerSide { get; set; }
    public uint BlurrinessFactor { get; set; }
    public uint NodeCount { get; set; }
    public uint PersistentNodeCount { get; set; }
    public uint LevelMax { get; set; }
    public List<uint> MaterialPairIndices { get; set; } = new List<uint>();
    public uint BackgroundMaterialIndex { get; set; }

    /// <summary>Every node that carries material samples, in tree order.</summary>
    public List<TerrainMaterialNode> Nodes { get; } = new List<TerrainMaterialNode>();

    public Vec2 CoverageMin { get; set; } = new Vec2();
    public uint NodeGridCellsPerSide { get; set; }
    public float VirtualSamplesPerMeter { get; set; }
    public uint VirtualRasterSampleIndexMax { get; set; }

    private void LoadNodes(RimeReader p_Reader, uint p_NodeIndex, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId, AxisAlignedBox2 p_NodeCoverage)
    {
        
        
        
        var s_NodeHasData = p_Reader.ReadBool();
        var s_NodeHasPersistent = p_Reader.ReadBool();

        if (s_NodeHasData)
        {
            // s_Node.m_Flags |= 0x10;
        }


        if (s_NodeHasData && s_NodeHasPersistent)
        {
            // The samples are run-length encoded, one run of lines per node, with the length of
            // each line following the payload. Kept rather than skipped: this is the only record
            // of which material covers which part of the terrain.
            var s_RleDataSize = p_Reader.ReadUInt32();
            var s_RleData = p_Reader.ReadBytes((int)s_RleDataSize);

            var s_LineSizes = new ushort[NodeSamplesPerSide];

            for (var i = 0; i < NodeSamplesPerSide; ++i)
                s_LineSizes[i] = p_Reader.ReadUInt16();

            var s_MaterialNode = new TerrainMaterialNode
            {
                Level = p_NodeId.Level,
                IndexX = p_NodeId.IndexX,
                IndexY = p_NodeId.IndexY,
                MinX = p_NodeCoverage.min.x,
                MinY = p_NodeCoverage.min.y,
                MaxX = p_NodeCoverage.max.x,
                MaxY = p_NodeCoverage.max.y,
                RleData = s_RleData,
                LineSizes = s_LineSizes
            };

            Nodes.Add(s_MaterialNode);
        }

        var s_HasChildren = p_Reader.ReadBool();
        if (s_HasChildren)
        {
            // s_Node.m_FirstChildIndex = p_FirstFreeNodeIndex;
            var s_FirstChildIndex = p_FirstFreeNodeIndex;
            p_FirstFreeNodeIndex += 4;

            
            float s_ChildNodeWidth = (float)((p_NodeCoverage.max.x - p_NodeCoverage.min.x) * 0.5);

            for(var i=0; i < 4; i++)
            {
                var s_ChildNodeId = new QuadtreeNodeId(p_NodeId);
                ++s_ChildNodeId.Level;

                s_ChildNodeId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[i] + 2 * s_ChildNodeId.IndexX);
                s_ChildNodeId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[i] + 2 * s_ChildNodeId.IndexY);

                
                var s_ChildCoverage = new AxisAlignedBox();

                // TODO: Verify these are correct.
                s_ChildCoverage.min = new Vec3
                {
                    x = QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[i] * s_ChildNodeWidth + p_NodeCoverage.min.x,
                    y = QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[i] * s_ChildNodeWidth + p_NodeCoverage.min.y,
                };

                s_ChildCoverage.max = new Vec3
                {
                    x = s_ChildCoverage.min.x + s_ChildNodeWidth,
                    y = s_ChildCoverage.min.y + s_ChildNodeWidth
                };

                LoadNodes(p_Reader, (uint)(i + s_FirstChildIndex), ref p_FirstFreeNodeIndex, s_ChildNodeId, s_ChildCoverage);
            }
            
            // var s_V14 = 0;
            //float s_ChildNodeWidth = (float)((p_NodeCoverage.Min.Y - p_NodeCoverage.Min.X) * 0.5);

            //do
            //{
            //    var s_ChildNodeId = new QuadtreeNodeId(p_NodeId);
            //    ++s_ChildNodeId.Level;

            //    s_ChildNodeId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[s_V14] + 2 * s_ChildNodeId.IndexX);
            //    s_ChildNodeId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[s_V14] + 2 * s_ChildNodeId.IndexY);

            //    var s_ChildCoverage = new AxisAlignedBox2();

            //    // TODO: Verify these are correct.
            //    s_ChildCoverage.Min = new Vec2(
            //            QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[s_V14] * s_ChildNodeWidth + p_NodeCoverage.Min.X,
            //            QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[s_V14] * s_ChildNodeWidth + p_NodeCoverage.Min.Y);

            //    s_ChildCoverage.Max = new Vec2(
            //        s_ChildCoverage.Min.X + s_ChildNodeWidth,
            //        s_ChildCoverage.Min.Y + s_ChildNodeWidth);

            //    LoadNodes(p_Reader, (uint)(s_V14 + s_FirstChildIndex), ref p_FirstFreeNodeIndex, s_ChildNodeId, s_ChildCoverage);
            //    ++s_V14;
            //} while (s_V14 < 4);
        }
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }

    public override bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;
        throw new System.NotImplementedException();
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        NodeSamplesPerSide = p_Reader.ReadUInt32();

        var s_Blurriness = p_Reader.ReadInt32();
        BlurrinessFactor = (uint)(1 << s_Blurriness);
        if (BlurrinessFactor != 1)
            throw new InvalidDataException("Blurrinessfactor must be 1");

        var s_TreeCoverage = new AxisAlignedBox();
        s_TreeCoverage.DeserializeVec2(p_Reader);

        NodeCount = p_Reader.ReadUInt32();
        if (NodeCount >= 10000)
            throw new InvalidDataException("Nodecount exceeds 10000");

        PersistentNodeCount = p_Reader.ReadUInt32();
        LevelMax = p_Reader.ReadUInt32();

        CoverageMin = new Vec2 
        { 
            x = s_TreeCoverage.min.x,
            y = s_TreeCoverage.min.y
        };
        NodeGridCellsPerSide = (uint)(1 << (int)LevelMax);
        VirtualSamplesPerMeter = ((float)NodeGridCellsPerSide * (float)NodeSamplesPerSide) /
                                 (s_TreeCoverage.max.x - s_TreeCoverage.max.y);
        VirtualRasterSampleIndexMax = (NodeGridCellsPerSide * NodeSamplesPerSide) - 1;

        var s_RootNodeId = new QuadtreeNodeId
        {
            Level = 0,
            IndexX = 0,
            IndexY = 0
        };

        uint s_FirstFreeNodeIndex = 1; // TODO: This is 1 in ida??
        LoadNodes(p_Reader, 0, ref s_FirstFreeNodeIndex, s_RootNodeId, s_TreeCoverage);

        var s_MaterialPairCount = p_Reader.ReadUInt32();

        MaterialPairIndices = new List<uint>();
        for (var i = 0; i < s_MaterialPairCount; ++i)
            MaterialPairIndices.Add(p_Reader.ReadUInt32());

        BackgroundMaterialIndex = p_Reader.ReadUInt32();
    }

    public override void Deserialize(byte[] p_Data)
    {
        throw new System.NotImplementedException();
    }
}

