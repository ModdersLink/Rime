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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 176)]
	public partial class FirstPersonCameraData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _Offset = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _WeaponBaseOffset = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec3 _WeaponLagRotationOffset = new();

		[ObservableProperty]
		[property: ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private Vec3 _Rotation = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private CtrRef<WeaponLagSpringEffectData> _WeaponSpringEffect = new();

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private CtrRef<WeaponLagSpringEffectData> _CameraSpringEffect = new();

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _MoveStrafeModifier;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _MoveForwardModifier;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _RotateYawModifier;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _RotatePitchModifier;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _RotateRollModifier;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _ZoomMoveStrafeModifier;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _ZoomMoveForwardModifier;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _ZoomRotateYawModifier;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _ZoomRotatePitchModifier;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _ZoomRotateRollModifier;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _ReleaseModifier;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _ReleaseModifierPitch;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _ReleaseModifierYaw;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _ReleaseModifierRoll;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _OffsetReleaseModifier;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _ZoomReleaseModifierPitch;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _ZoomReleaseModifierYaw;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _ZoomReleaseModifierRoll;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _ZoomOffsetReleaseModifier;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _RotationAdditionToOffset;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
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
