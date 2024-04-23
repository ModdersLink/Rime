using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.Bundles;

public interface IPatchableEntry
{
	// For cas deltas
	// used in fb::BundleHelper::generateCasPatchBundleData
	// == 0, increases size by Align1000(OriginalSize)      | unchanged
        
	// == 1, sets bit 0x30000000 some id, and increases     | external patch
	//      possibly related to PatchEntryOpType.New?
	//      chunk   = 0x30000000 | Align1000(LogicalSize + (LogicalOffset & 0xFFFF)
	//      ebx,dbx = 0x30000000 | Align1000(OriginalSize) 
        
	// == 2, then it has sha1 or idelta, looks up in base   | 
	//      Look up patch in delta file
        
	public long? CasPatchType { get; }
        
	public Sha1? BaseHash { get; }
        
	// Either DeltaIndex or DeltaHash is valid. used to look up base in cas.
	public long? DeltaIndex { get; }
	public Sha1? DeltaHash { get; }
}