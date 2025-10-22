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
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 96)]
public class BFUnlockAsset
	: fb.GameShared.UnlockAsset
{
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public List<uint> CompatibilityIdentifiers { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public InventoryType InventoryType { get; set; } = fb.VeniceShared.InventoryType.IT_None;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public uint ZoomLevelStandard { get; set; } = 0;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public uint ZoomLevelToggled { get; set; } = 14;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool UseListAsExclusion { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_CompatibilityIdentifiers = p_EbxWriter.GetArrayWriter(CompatibilityIdentifiers.GetType(), CompatibilityIdentifiers.Count);
		p_Writer.Write(s_CompatibilityIdentifiers.ArrayIndex);
		foreach (var s_Entry in CompatibilityIdentifiers)
		{
			s_CompatibilityIdentifiers.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) InventoryType);
		p_Writer.Write(ZoomLevelStandard);
		p_Writer.Write(ZoomLevelToggled);
		p_Writer.Write(UseListAsExclusion);
		p_Writer.WriteNullBytes(3);
	}
}

