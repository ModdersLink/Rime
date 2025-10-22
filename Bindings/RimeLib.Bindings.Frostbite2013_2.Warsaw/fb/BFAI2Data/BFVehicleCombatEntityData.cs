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

[ContainerType(16, 80)]
public class BFVehicleCombatEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<VehicleCombatSettings> Settings { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 LastKnownLocation { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 ActualLocation { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float TimeSinceVisible { get; set; } = 0.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float PatrolSpeed { get; set; } = 10.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float CombatSpeed { get; set; } = 20.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool UsePathFinding { get; set; } = false;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool IsVehicleTarget { get; set; } = false;
	
	[ContainerField(0x4e), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
	public bool AllowFireWhileFollowing { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Settings));
		p_Writer.WriteNullBytes(4);
		LastKnownLocation.Serialize(p_Writer, p_EbxWriter);
		ActualLocation.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TimeSinceVisible);
		p_Writer.Write(PatrolSpeed);
		p_Writer.Write(CombatSpeed);
		p_Writer.Write(UsePathFinding);
		p_Writer.Write(IsVehicleTarget);
		p_Writer.Write(AllowFireWhileFollowing);
		p_Writer.WriteNullBytes(1);
	}
}

