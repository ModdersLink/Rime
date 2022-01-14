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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 176)]
	public class FirstPersonCameraData :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 Offset { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 WeaponBaseOffset { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 WeaponLagRotationOffset { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public Vec3 Rotation { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public CtrRef<WeaponLagSpringEffectData> WeaponSpringEffect { get; set; } = new();

		[ContainerField(84), JsonProperty(Order = 84)]
		public CtrRef<WeaponLagSpringEffectData> CameraSpringEffect { get; set; } = new();

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float MoveStrafeModifier { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float MoveForwardModifier { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float RotateYawModifier { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float RotatePitchModifier { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float RotateRollModifier { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float ZoomMoveStrafeModifier { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float ZoomMoveForwardModifier { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float ZoomRotateYawModifier { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float ZoomRotatePitchModifier { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float ZoomRotateRollModifier { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float ReleaseModifier { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float ReleaseModifierPitch { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float ReleaseModifierYaw { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float ReleaseModifierRoll { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float OffsetReleaseModifier { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float ZoomReleaseModifierPitch { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float ZoomReleaseModifierYaw { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float ZoomReleaseModifierRoll { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float ZoomOffsetReleaseModifier { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float RotationAdditionToOffset { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			Offset.Serialize(p_Writer, p_EbxWriter);
			WeaponBaseOffset.Serialize(p_Writer, p_EbxWriter);
			WeaponLagRotationOffset.Serialize(p_Writer, p_EbxWriter);
			Rotation.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponSpringEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(CameraSpringEffect));
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
			p_Writer.WriteNullBytes(8);
		}
	}
}
