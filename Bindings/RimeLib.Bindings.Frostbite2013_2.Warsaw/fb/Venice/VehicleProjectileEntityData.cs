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
using fb.Entity;
using fb.Physics;

namespace fb.Venice;

[ContainerType(16, 256)]
public class VehicleProjectileEntityData
	: fb.GameShared.ProjectileEntityData
{
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<VehicleBlueprint> Vehicle { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float EnterDelay { get; set; } = 0.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float AlignWithGroundRayLength { get; set; } = 5.000f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float NoVehicleCollisionTime { get; set; } = 0.000f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public bool AutoEnter { get; set; } = true;
	
	[ContainerField(0xf5), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
	public bool AlignWithGround { get; set; } = true;
	
	[ContainerField(0xf6), LayoutImmutable, Blittable, JsonProperty(Order = 246)]
	public bool CheckGroundWhenSpawned { get; set; } = false;
	
	[ContainerField(0xf7), LayoutImmutable, Blittable, JsonProperty(Order = 247)]
	public bool DeployInsideNeutralCombatAreaOnly { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Vehicle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(EnterDelay);
		p_Writer.Write(AlignWithGroundRayLength);
		p_Writer.Write(NoVehicleCollisionTime);
		p_Writer.Write(AutoEnter);
		p_Writer.Write(AlignWithGround);
		p_Writer.Write(CheckGroundWhenSpawned);
		p_Writer.Write(DeployInsideNeutralCombatAreaOnly);
		p_Writer.WriteNullBytes(8);
	}
}

