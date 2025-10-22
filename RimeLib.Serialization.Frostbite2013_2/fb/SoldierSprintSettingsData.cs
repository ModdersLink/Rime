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
public class SoldierSprintSettingsData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float Fov { get; set; } = 65.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float FovInDelay { get; set; } = 0.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float FovInTime { get; set; } = 0.300f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float FovOutDelay { get; set; } = 0.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float FovOutTime { get; set; } = 0.200f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float RecoverTime { get; set; } = 1.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float SprintToProneRecoverTime { get; set; } = 1.000f;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<int> InterruptingActions { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Fov);
		p_Writer.Write(FovInDelay);
		p_Writer.Write(FovInTime);
		p_Writer.Write(FovOutDelay);
		p_Writer.Write(FovOutTime);
		p_Writer.Write(RecoverTime);
		p_Writer.Write(SprintToProneRecoverTime);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InterruptingActions = p_EbxWriter.GetArrayWriter(InterruptingActions.GetType(), InterruptingActions.Count);
		p_Writer.Write(s_InterruptingActions.ArrayIndex);
		foreach (var s_Entry in InterruptingActions)
		{
			s_InterruptingActions.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

