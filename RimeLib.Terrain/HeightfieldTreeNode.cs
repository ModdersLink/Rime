using fb;
using RimeLib.IO;
using System;

namespace RimeLib.Terrain
{
    public class HeightfieldTreeNode : RasterTreeNode
    {
        public AxisAlignedBox BoundingBox { get; set; } = new AxisAlignedBox();
        public float SamplesPerMeter { get; set; }
        public byte[] EmbeddedData { get; set; } = Array.Empty<byte>();

        // Warsaw addition
        public bool PartialNonPhysics { get; set; }

        public HeightfieldTreeNode()
        {

        }

        public HeightfieldTreeNode(RimeReader p_Reader)
        {
            BoundingBox = new AxisAlignedBox();

            // The padding isn't actually in the file so we have to read them out separately
            // TODO: Fix below
            throw new NotImplementedException();
            //BoundingBox.Min.X = p_Reader.ReadSingle();
            //BoundingBox.Min.Y = p_Reader.ReadSingle();
            //BoundingBox.Min.Z = p_Reader.ReadSingle();

            //BoundingBox.Max.X = p_Reader.ReadSingle();
            //BoundingBox.Max.Y = p_Reader.ReadSingle();
            //BoundingBox.Max.Z = p_Reader.ReadSingle();
        }
    }

}
