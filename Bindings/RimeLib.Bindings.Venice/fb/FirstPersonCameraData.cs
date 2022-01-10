///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 176)]
	public class FirstPersonCameraData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WeaponBaseOffset { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 WeaponLagRotationOffset { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Rotation { get; set; } = new();

		[ContainerField(80)]
		public CtrRef<WeaponLagSpringEffectData> WeaponSpringEffect { get; set; } = new();

		[ContainerField(84)]
		public CtrRef<WeaponLagSpringEffectData> CameraSpringEffect { get; set; } = new();

		[ContainerField(88), LayoutImmutable, Blittable]
		public float MoveStrafeModifier { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float MoveForwardModifier { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float RotateYawModifier { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float RotatePitchModifier { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float RotateRollModifier { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float ZoomMoveStrafeModifier { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float ZoomMoveForwardModifier { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float ZoomRotateYawModifier { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float ZoomRotatePitchModifier { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float ZoomRotateRollModifier { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float ReleaseModifier { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float ReleaseModifierPitch { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float ReleaseModifierYaw { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float ReleaseModifierRoll { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float OffsetReleaseModifier { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float ZoomReleaseModifierPitch { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float ZoomReleaseModifierYaw { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float ZoomReleaseModifierRoll { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float ZoomOffsetReleaseModifier { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float RotationAdditionToOffset { get; set; }

		public static void Deserialize(FirstPersonCameraData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.Offset, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.WeaponBaseOffset, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.WeaponLagRotationOffset, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.Rotation, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.WeaponSpringEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CameraSpringEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MoveStrafeModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MoveForwardModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RotateYawModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RotatePitchModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RotateRollModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ZoomMoveStrafeModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ZoomMoveForwardModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ZoomRotateYawModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ZoomRotatePitchModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ZoomRotateRollModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ReleaseModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ReleaseModifierPitch = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ReleaseModifierYaw = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ReleaseModifierRoll = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.OffsetReleaseModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ZoomReleaseModifierPitch = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ZoomReleaseModifierYaw = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ZoomReleaseModifierRoll = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ZoomOffsetReleaseModifier = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.RotationAdditionToOffset = p_Reader.ReadSingle();
			p_Reader.Seek(16, SeekOrigin.Current);
		}

	}
}
