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

[ContainerType(8, 56)]
public class VisionModifier
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float SensingConeRange { get; set; } = 100.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float SensingConeRangeWhenAlerted { get; set; } = 120.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float SensingConeAngle { get; set; } = 60.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float SensingConeAngleWhenAlerted { get; set; } = 60.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float SensingConeAngleAbove { get; set; } = 15.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float SensingConeAngleBelow { get; set; } = 55.000f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<FlashlightModifier> FlashlightModifier { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool AlwaysSeeHuman { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SensingConeRange);
		p_Writer.Write(SensingConeRangeWhenAlerted);
		p_Writer.Write(SensingConeAngle);
		p_Writer.Write(SensingConeAngleWhenAlerted);
		p_Writer.Write(SensingConeAngleAbove);
		p_Writer.Write(SensingConeAngleBelow);
		p_Writer.Write(p_EbxWriter.WriteImport(FlashlightModifier));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AlwaysSeeHuman);
		p_Writer.WriteNullBytes(7);
	}
}

