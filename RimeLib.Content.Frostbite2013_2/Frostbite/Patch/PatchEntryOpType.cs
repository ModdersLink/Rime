
namespace RimeLib.Content.Frostbite2013_2.Frostbite.Patch;

// patch reading in fb::turboMuxGetSegmentData
public enum PatchEntryOpType
{
	None = 0,
	CompressedSegment = 0x1,
	DecompressedSegment = 0x2,
	New = 0x3,
	Remove = 0x4,
	Count = 0x5,
}