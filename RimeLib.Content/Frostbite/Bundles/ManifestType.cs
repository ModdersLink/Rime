namespace RimeLib.Content.Frostbite.Bundles;

public enum ManifestType : uint
{
	
	Dbx = 0xFE1FBEEF,
	Ebx = 0xED1CEDB8,

	// BF3 alpha/beta (Sep 2011, pre-release Frostbite 2): bundle manifests predate the Fb2
	// magic obfuscation AND the retail Ebx magic's high nibble — raw 0x0D1CEDB8 on disk.
	// Same header/record layout as Fb2Ebx otherwise (verified against the alpha's Globals.sb).
	EbxAlpha = 0x0D1CEDB8,
	
	// this bundlemanifest seems completly dbobject based. probably what they use on backend/avalanche
	Spec = 0x73706563,
	SpecDbx = (Dbx ^ Spec),
	SpecEbx = (Ebx ^ Spec),
	
	Fb2 = 0x7A11F1AB,
	Fb2Dbx = (Dbx ^ Fb2),
	Fb2Ebx = (Ebx ^ Fb2),
	
	// standard bundle manifest used in fb2013+?
	Pecm = 0x7065636D,
	PecmDbx = (Dbx ^ Pecm),
	PecmEbx = (Ebx ^ Pecm),
	
	// either fb2013 type or fb2016 type. same format as pecm
	Pecn = 0x7065636E,
	PecnDbx = (Dbx ^ Pecn),
	PecnEbx = (Ebx ^ Pecn),
	
	
	// This is the new Ukpik manifest 2019?
	Owla = 0x6F776C61,
}