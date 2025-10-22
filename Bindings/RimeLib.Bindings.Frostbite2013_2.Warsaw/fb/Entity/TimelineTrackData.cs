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

namespace fb.Entity;

[ContainerType(8, 40)]
public class TimelineTrackData
	: fb.Entity.GameObjectData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<TimelineTrackDataConditionsBase> Conditions { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool ExposePins { get; set; } = false;
	
	[ContainerField(0x21), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
	public bool IsDisabled { get; set; } = false;
	
	[ContainerField(0x22), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
	public bool DependsOnAnimation { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Conditions = p_EbxWriter.GetArrayWriter(Conditions.GetType(), Conditions.Count);
		p_Writer.Write(s_Conditions.ArrayIndex);
		foreach (var s_Entry in Conditions)
		{
			s_Conditions.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ExposePins);
		p_Writer.Write(IsDisabled);
		p_Writer.Write(DependsOnAnimation);
		p_Writer.WriteNullBytes(5);
	}
}

