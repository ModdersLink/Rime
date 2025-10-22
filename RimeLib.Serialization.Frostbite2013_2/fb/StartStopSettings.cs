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

namespace fb.BFAI2Data;

[ContainerType(8, 32)]
public class StartStopSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float UpperRange { get; set; } = 12.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float LowerRange { get; set; } = 5.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float IdealRange { get; set; } = 8.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float LineOfSightTime { get; set; } = 2.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(UpperRange);
		p_Writer.Write(LowerRange);
		p_Writer.Write(IdealRange);
		p_Writer.Write(LineOfSightTime);
	}
}

