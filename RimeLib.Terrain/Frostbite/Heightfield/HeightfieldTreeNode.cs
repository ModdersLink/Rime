using fb;
using RimeLib.IO;
using System;


namespace RimeLib.Terrain.Frostbite.Heightfield;

public class HeightfieldTreeNode : RasterTreeNode
{
    public AxisAlignedBox BoundingBox { get; set; } = new AxisAlignedBox();
    public float SamplesPerMeter { get; set; }
    public byte[] EmbeddedData { get; set; } = Array.Empty<byte>();

    // Warsaw addition
    public bool PartialNonPhysics { get; set; }

    /// <summary>
    /// The four flag bytes as they appear, rather than only their effect on
    /// <see cref="RasterTreeNode.Flags"/>.
    ///
    /// Flags cannot stand in for them. A node carrying data sets bit 16 and never looks at
    /// <see cref="HasData1"/>, so that byte's value is not recoverable from the flags -- and a
    /// node with data but no persistent copy reads no samples at all, which nothing in the flags
    /// records either. Writing the node back needs both.
    /// </summary>
    public bool Disabled { get; set; }
    public bool HasData1 { get; set; }
    public bool HasData { get; set; }
    public bool HasPersistent { get; set; }

    /// <summary>
    /// The min/max and occluder-grid stacks that follow the samples. The reader stepped over them
    /// by length; they are the node's own bytes and it cannot be written back without them.
    /// </summary>
    public byte[] MinMaxData { get; set; } = Array.Empty<byte>();
    public byte[] OccluderGridData { get; set; } = Array.Empty<byte>();

    public HeightfieldTreeNode()
    {

    }

    public HeightfieldTreeNode(RimeReader p_Reader)
    {
        BoundingBox = new AxisAlignedBox();

        // The padding isn't actually in the file so we have to read them out separately
        BoundingBox.min.x = p_Reader.ReadSingle();
        BoundingBox.min.y = p_Reader.ReadSingle();
        BoundingBox.min.z = p_Reader.ReadSingle();

        BoundingBox.max.x = p_Reader.ReadSingle();
        BoundingBox.max.y = p_Reader.ReadSingle();
        BoundingBox.max.z = p_Reader.ReadSingle();
    }
}

