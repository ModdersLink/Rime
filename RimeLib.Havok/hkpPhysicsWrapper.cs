using System.Numerics;

namespace RimeLib.Havok;

/// <summary>
/// The Frostbite wrapper a HavokPhysicsData carries around its packfiles.
///
/// Reading the shapes is not enough to reproduce the resource: the file opens with part metadata --
/// MEHouse01Large declares 21 parts -- and a rebuild that emits only the packfiles writes PartCount
/// 1 and differs from byte 0. Measured layout, four count/offset arrays followed by scale and the
/// packed material counts:
///
///   [0]      PartCount
///   [1..3]   PartTranslations         count, offset, 0   (16 bytes each)
///   [4..6]   LocalAabbs               count, offset, 0   (32 bytes each)
///   [7..9]   MaterialIndices          count, offset, 0   (1 byte each, padded)
///   [10..12] MaterialFlagsAndIndices  count, offset, 0   (4 bytes each)
///   [13]     Scale as float
///   [14]     MaterialCountUsed | HighestMaterialIndex &lt;&lt; 8
/// </summary>
public class hkpPhysicsWrapper
{
    public uint PartCount { get; set; }
    public float Scale { get; set; }
    public byte MaterialCountUsed { get; set; }
    public byte HighestMaterialIndex { get; set; }
    public List<Vector3> PartTranslations { get; set; } = new();
    public List<float[]> LocalAabbs { get; set; } = new();
    public List<byte> MaterialIndices { get; set; } = new();
    public List<uint> MaterialFlagsAndIndices { get; set; } = new();
}
