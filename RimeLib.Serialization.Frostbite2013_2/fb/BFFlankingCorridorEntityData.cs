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

namespace fb.BFAI2Data;

[ContainerType(8, 48)]
public class BFFlankingCorridorEntityData
	: fb.BFAI2Data.BFParameterWithShapeEntityData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int AdvanceCount { get; set; } = 2;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float AdvanceInterval { get; set; } = 10.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float HumanTargetDistance { get; set; } = 20.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public bool AllowLeavingFlankingCorridor { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AdvanceCount);
		p_Writer.Write(AdvanceInterval);
		p_Writer.Write(HumanTargetDistance);
		p_Writer.Write(AllowLeavingFlankingCorridor);
		p_Writer.WriteNullBytes(3);
	}
}

