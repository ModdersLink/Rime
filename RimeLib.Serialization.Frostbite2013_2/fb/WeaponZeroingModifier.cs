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

namespace fb.SoldierShared;

[ContainerType(8, 40)]
public class WeaponZeroingModifier
	: fb.GameShared.WeaponModifierBase
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<WeaponZeroingEntry> Modes { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float DefaultZeroingDistance { get; set; } = 100.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Modes = p_EbxWriter.GetArrayWriter(Modes.GetType(), Modes.Count);
		p_Writer.Write(s_Modes.ArrayIndex);
		foreach (var s_Entry in Modes)
		{
			s_Entry.Serialize(s_Modes.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DefaultZeroingDistance);
		p_Writer.WriteNullBytes(4);
	}
}

