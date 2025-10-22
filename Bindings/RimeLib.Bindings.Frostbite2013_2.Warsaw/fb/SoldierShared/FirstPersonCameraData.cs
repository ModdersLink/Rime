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

namespace fb.SoldierShared;

[ContainerType(16, 176)]
public class FirstPersonCameraData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<WeaponLagSpringEffectData> WeaponSpringEffect { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<WeaponLagSpringEffectData> CameraSpringEffect { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 Offset { get; set; } = new()
	{
		z = 0.200f,
		y = -1.500f,
		x = 0.100f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 WeaponBaseOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = -0.090f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 WeaponLagRotationOffset { get; set; } = new()
	{
		z = 0.200f,
		y = 0.000f,
		x = -0.090f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec3 Rotation { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float MoveStrafeModifier { get; set; } = 0.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float MoveForwardModifier { get; set; } = 0.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float RotateYawModifier { get; set; } = 0.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float RotatePitchModifier { get; set; } = 0.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float RotateRollModifier { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float ZoomMoveStrafeModifier { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float ZoomMoveForwardModifier { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float ZoomRotateYawModifier { get; set; } = 0.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float ZoomRotatePitchModifier { get; set; } = 0.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float ZoomRotateRollModifier { get; set; } = 0.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float ReleaseModifier { get; set; } = 0.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float ReleaseModifierPitch { get; set; } = -1.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float ReleaseModifierYaw { get; set; } = -1.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float ReleaseModifierRoll { get; set; } = -1.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float OffsetReleaseModifier { get; set; } = -1.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float ZoomReleaseModifierPitch { get; set; } = -1.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float ZoomReleaseModifierYaw { get; set; } = -1.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float ZoomReleaseModifierRoll { get; set; } = -1.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float ZoomOffsetReleaseModifier { get; set; } = -1.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float RotationAdditionToOffset { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(WeaponSpringEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CameraSpringEffect));
		p_Writer.WriteNullBytes(4);
		Offset.Serialize(p_Writer, p_EbxWriter);
		WeaponBaseOffset.Serialize(p_Writer, p_EbxWriter);
		WeaponLagRotationOffset.Serialize(p_Writer, p_EbxWriter);
		Rotation.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MoveStrafeModifier);
		p_Writer.Write(MoveForwardModifier);
		p_Writer.Write(RotateYawModifier);
		p_Writer.Write(RotatePitchModifier);
		p_Writer.Write(RotateRollModifier);
		p_Writer.Write(ZoomMoveStrafeModifier);
		p_Writer.Write(ZoomMoveForwardModifier);
		p_Writer.Write(ZoomRotateYawModifier);
		p_Writer.Write(ZoomRotatePitchModifier);
		p_Writer.Write(ZoomRotateRollModifier);
		p_Writer.Write(ReleaseModifier);
		p_Writer.Write(ReleaseModifierPitch);
		p_Writer.Write(ReleaseModifierYaw);
		p_Writer.Write(ReleaseModifierRoll);
		p_Writer.Write(OffsetReleaseModifier);
		p_Writer.Write(ZoomReleaseModifierPitch);
		p_Writer.Write(ZoomReleaseModifierYaw);
		p_Writer.Write(ZoomReleaseModifierRoll);
		p_Writer.Write(ZoomOffsetReleaseModifier);
		p_Writer.Write(RotationAdditionToOffset);
	}
}

