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

namespace fb.Emitter;

[ContainerType(16, 64)]
public class LocalForceData
	: fb.Emitter.ProcessorData
{
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float PerParticleRandomness { get; set; } = 0.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public bool EmitterLocalSpaceForce { get; set; } = false;
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 LocalForce { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 1.000f,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PerParticleRandomness);
		p_Writer.Write(EmitterLocalSpaceForce);
		p_Writer.WriteNullBytes(3);
		LocalForce.Serialize(p_Writer, p_EbxWriter);
	}
}

