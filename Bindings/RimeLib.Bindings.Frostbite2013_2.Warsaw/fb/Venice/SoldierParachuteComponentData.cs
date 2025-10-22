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
using fb.VeniceShared;
using fb.Entity;

namespace fb.Venice;

[ContainerType(16, 256)]
public class SoldierParachuteComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public SoldierParachuteBinding Binding { get; set; } = new();
	
	[ContainerField(0xd4), JsonProperty(Order = 212)]
	public AimingConstraintsData AimingConstraints { get; set; } = new();
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public float UndeployTime { get; set; } = 3.200f;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float AutoDeployInitialDelay { get; set; } = 0.200f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float AutoDeployGroundDistance { get; set; } = 55.000f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float AutoDeployMinGroundDistance { get; set; } = 20.000f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public bool AutoDeployEnabled { get; set; } = true;
	
	[ContainerField(0xf5), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
	public bool AutoDeployOnceOnSpawnOnly { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Binding.Serialize(p_Writer, p_EbxWriter);
		AimingConstraints.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(UndeployTime);
		p_Writer.Write(AutoDeployInitialDelay);
		p_Writer.Write(AutoDeployGroundDistance);
		p_Writer.Write(AutoDeployMinGroundDistance);
		p_Writer.Write(AutoDeployEnabled);
		p_Writer.Write(AutoDeployOnceOnSpawnOnly);
		p_Writer.WriteNullBytes(10);
	}
}

