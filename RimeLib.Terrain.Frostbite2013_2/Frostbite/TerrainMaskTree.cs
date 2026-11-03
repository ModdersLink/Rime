using RimeLib.IO;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>Frostbite 2's mask tree with the first valid level after the tile counts and a persistent node's samples without their size.</summary>
public class TerrainMaskTree : Frostbite2_0.Frostbite.TerrainMask.TerrainMaskTree
{
    public uint FirstValidLevel { get; set; }

    protected override void DeserializeLevels(RimeReader p_Reader) => FirstValidLevel = p_Reader.ReadUInt32();

    protected override void SerializeLevels(RimeWriter p_Writer) => p_Writer.Write(FirstValidLevel);

    protected override bool SamplesSizePrefixed => false;
}
