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

namespace fb.SoldierShared;

[ContainerType(8, 56)]
public class SoldierWeaponSwitchingData
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<WeaponSwitchingMapData> SwitchMap { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<DirectWeaponSwitchingMapData> DirectSwitchMap { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<WeaponSwitchingEnum> AutoDropSlots { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int ToggleAction { get; set; } = -1584896676;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float ToggleMaxHoldTime { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_SwitchMap = p_EbxWriter.GetArrayWriter(SwitchMap.GetType(), SwitchMap.Count);
		p_Writer.Write(s_SwitchMap.ArrayIndex);
		foreach (var s_Entry in SwitchMap)
		{
			s_Entry.Serialize(s_SwitchMap.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_DirectSwitchMap = p_EbxWriter.GetArrayWriter(DirectSwitchMap.GetType(), DirectSwitchMap.Count);
		p_Writer.Write(s_DirectSwitchMap.ArrayIndex);
		foreach (var s_Entry in DirectSwitchMap)
		{
			s_Entry.Serialize(s_DirectSwitchMap.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_AutoDropSlots = p_EbxWriter.GetArrayWriter(AutoDropSlots.GetType(), AutoDropSlots.Count);
		p_Writer.Write(s_AutoDropSlots.ArrayIndex);
		foreach (var s_Entry in AutoDropSlots)
		{
			s_AutoDropSlots.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ToggleAction);
		p_Writer.Write(ToggleMaxHoldTime);
	}
}

