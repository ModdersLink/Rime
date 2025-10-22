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

namespace fb.Venice;

[ContainerType(8, 48)]
public class DVRMomentEvent
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public Moments MomentType { get; set; } = Moments.Moment_Undefined;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float SecondsStartTime { get; set; } = 0.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float SecondsDurationTime { get; set; } = 0.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string MomentId { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool VariableTiming { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) MomentType);
		p_Writer.Write(SecondsStartTime);
		p_Writer.Write(SecondsDurationTime);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(MomentId));
		p_Writer.Write(VariableTiming);
		p_Writer.WriteNullBytes(7);
	}
}

