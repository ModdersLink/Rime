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

namespace fb.GameShared;

[ContainerType(8, 56)]
public class CustomizeCharacterData
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<CustomizeVisual> VisualGroups { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<UnlockAssetBase> Unlocks { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float OverrideMaxHealth { get; set; } = -1.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float OverrideCriticalHealthThreshold { get; set; } = -1.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool RestoreToOriginalVisualState { get; set; } = false;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool ClearVisualState { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_VisualGroups = p_EbxWriter.GetArrayWriter(VisualGroups.GetType(), VisualGroups.Count);
		p_Writer.Write(s_VisualGroups.ArrayIndex);
		foreach (var s_Entry in VisualGroups)
		{
			s_Entry.Serialize(s_VisualGroups.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Unlocks = p_EbxWriter.GetArrayWriter(Unlocks.GetType(), Unlocks.Count);
		p_Writer.Write(s_Unlocks.ArrayIndex);
		foreach (var s_Entry in Unlocks)
		{
			s_Unlocks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(OverrideMaxHealth);
		p_Writer.Write(OverrideCriticalHealthThreshold);
		p_Writer.Write(RestoreToOriginalVisualState);
		p_Writer.Write(ClearVisualState);
		p_Writer.WriteNullBytes(6);
	}
}

