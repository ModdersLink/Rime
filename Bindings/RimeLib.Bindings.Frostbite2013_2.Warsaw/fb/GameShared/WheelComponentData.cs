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

using fb.Physics;
using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 128)]
public class WheelComponentData
	: fb.GameShared.BoneComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<WheelConfigData> Config { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public WheelPhysicsType PhysicsType { get; set; } = WheelPhysicsType.wptNormal;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float EffectClampVelocity { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Config));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) PhysicsType);
		p_Writer.Write(EffectClampVelocity);
	}
}

