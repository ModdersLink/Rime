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
using fb.GameShared;

namespace fb.SoldierShared;

[ContainerType(16, 288)]
public class BallisticShieldWeaponData
	: fb.GameShared.WeaponData
{
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 ADSZeroPitchOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 ADSMinPitchOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 ADSMaxPitchOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec3 CrouchZeroPitchOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 CrouchMinPitchOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 CrouchMaxPitchOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 CrouchMoveZeroPitchOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 CrouchMoveMinPitchOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec3 CrouchMoveMaxPitchOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xb0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public LinearTransform SprintOffset { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float MaxHealth { get; set; } = 100.000f;
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public CtrRef<ObjectBlueprint> PhysicsBlueprint { get; set; } = new();
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float DestructionMeshHealth { get; set; } = 30.000f;
	
	[ContainerField(0x108), JsonProperty(Order = 264)]
	public CtrRef<ObjectBlueprint> DestructionMeshBlueprint1p { get; set; } = new();
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public CtrRef<ObjectBlueprint> DestructionMeshBlueprint3p { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ADSZeroPitchOffset.Serialize(p_Writer, p_EbxWriter);
		ADSMinPitchOffset.Serialize(p_Writer, p_EbxWriter);
		ADSMaxPitchOffset.Serialize(p_Writer, p_EbxWriter);
		CrouchZeroPitchOffset.Serialize(p_Writer, p_EbxWriter);
		CrouchMinPitchOffset.Serialize(p_Writer, p_EbxWriter);
		CrouchMaxPitchOffset.Serialize(p_Writer, p_EbxWriter);
		CrouchMoveZeroPitchOffset.Serialize(p_Writer, p_EbxWriter);
		CrouchMoveMinPitchOffset.Serialize(p_Writer, p_EbxWriter);
		CrouchMoveMaxPitchOffset.Serialize(p_Writer, p_EbxWriter);
		SprintOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxHealth);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PhysicsBlueprint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DestructionMeshHealth);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DestructionMeshBlueprint1p));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DestructionMeshBlueprint3p));
		p_Writer.WriteNullBytes(12);
	}
}

