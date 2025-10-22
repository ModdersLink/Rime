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
public class BFIdleBehaviorEntityData
	: fb.BFAI2Data.BFParameterEntityData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public IdleReadiness IdleReadiness { get; set; } = fb.BFAI2Data.IdleReadiness.IdleReadiness_Relaxed;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float AimingTargetDistance { get; set; } = 60.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool AllowAimingWhileScripted { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) IdleReadiness);
		p_Writer.Write(AimingTargetDistance);
		p_Writer.Write(AllowAimingWhileScripted);
		p_Writer.WriteNullBytes(7);
	}
}

