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
using fb.Render;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 368)]
public class ControllableChaseCameraData
	: fb.GameShared.ChaseCameraData
{
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float RotateSpeedMultiplier { get; set; } = 2.000f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public float RotateMinUpDown { get; set; } = -0.800f;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public float RotateMaxUpDown { get; set; } = 0.200f;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public bool UseTargetRelativePitch { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RotateSpeedMultiplier);
		p_Writer.Write(RotateMinUpDown);
		p_Writer.Write(RotateMaxUpDown);
		p_Writer.Write(UseTargetRelativePitch);
		p_Writer.WriteNullBytes(3);
	}
}

