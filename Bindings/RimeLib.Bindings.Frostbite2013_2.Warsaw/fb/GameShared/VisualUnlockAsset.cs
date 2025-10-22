///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;

using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 152)]
public class VisualUnlockAsset
	: fb.GameShared.UnlockAsset
{
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<ObjectBlueprint> OutObjectBlueprint { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public BlueprintBundleReference BlueprintBundleReference { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public BlueprintBundleReference FirstPersonBundle { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public int FaceposerLibraryIndex { get; set; } = -1;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public RefArray<VisualUnlockAsset> VisualUnlockAssets { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public bool RenderIn1p { get; set; } = false;
	
	[ContainerField(0x91), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
	public bool OnDemandLoaded { get; set; } = false;
	
	[ContainerField(0x92), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
	public bool VisualIsNetworkedResource { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(OutObjectBlueprint));
		p_Writer.WriteNullBytes(4);
		BlueprintBundleReference.Serialize(p_Writer, p_EbxWriter);
		FirstPersonBundle.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FaceposerLibraryIndex);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_VisualUnlockAssets = p_EbxWriter.GetArrayWriter(VisualUnlockAssets.GetType(), VisualUnlockAssets.Count);
		p_Writer.Write(s_VisualUnlockAssets.ArrayIndex);
		foreach (var s_Entry in VisualUnlockAssets)
		{
			s_VisualUnlockAssets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RenderIn1p);
		p_Writer.Write(OnDemandLoaded);
		p_Writer.Write(VisualIsNetworkedResource);
		p_Writer.WriteNullBytes(5);
	}
}

