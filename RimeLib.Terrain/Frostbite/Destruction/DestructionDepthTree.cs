using System.Collections.Generic;
﻿
using fb;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Serialization.Frostbite2_0.Extensions;

namespace RimeLib.Terrain.Frostbite.Destruction;

public class DestructionDepthTree : RasterTree
{
    public uint NodeSamplesPerSide { get; set; }
    public uint BlurrinessFactor { get; set; }
    public uint NodeCount { get; set; }
    public uint PersistentNodeCount { get; set; }
    public uint LevelMax { get; set; }
    public uint NodeBorderWidth { get; set; }

    public uint NodeSamplesPerSidePot { get; set; }

    /// <summary>Every node that carries destruction depths, in tree order.</summary>
    public List<DestructionDepthTreeNode> Nodes { get; } = new List<DestructionDepthTreeNode>();

    private DestructionDepthTreeNode LoadNodes(RimeReader p_Reader, uint p_NodeIndex, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId, AxisAlignedBox p_NodeCoverage)
    {
        var s_Node = new DestructionDepthTreeNode()
        {
            ID = p_NodeId,
            WorldCoverage = p_NodeCoverage
        };
        
        var s_NodeHasData = p_Reader.ReadBool();
        var s_NodeHasPersistent = p_Reader.ReadBool();

        if (s_NodeHasData)
        {
            s_Node.Flags |= 0x10;
        }

        if (s_NodeHasData && s_NodeHasPersistent)
        {
            // Run-length encoded exactly as the material tree's samples are, so TerrainRle decodes
            // them. They were being read and dropped, which left the tree walk correct and the
            // depths -- how deep the ground has been blown out at each sample -- unreachable.
            var s_RleDataSize = p_Reader.ReadUInt32();

            s_Node.RleData = p_Reader.ReadBytes((int)s_RleDataSize);
            s_Node.LineSizes = new ushort[NodeSamplesPerSide];

            for (var i = 0; i < NodeSamplesPerSide; ++i)
                s_Node.LineSizes[i] = p_Reader.ReadUInt16();

            Nodes.Add(s_Node);
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
        }

        return s_Node;
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
        NodeBorderWidth = p_Reader.ReadUInt32();

        NodeSamplesPerSidePot = NodeSamplesPerSide - (2 * NodeBorderWidth) - 1;
        
        //if (!IsPowerOf2(NodeSamplesPerSidePot))
        //  throw new InvalidDataException("NodeSamplesPerSidePot is not a power of 2");
        
        var s_RootNodeId = new QuadtreeNodeId
        {
            Level = 0,
            IndexX = 0,
            IndexY = 0
        };

        uint s_FirstFreeNodeIndex = 1;

        RootNode = LoadNodes(p_Reader, 0, ref s_FirstFreeNodeIndex, s_RootNodeId, s_TreeCoverage);
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
