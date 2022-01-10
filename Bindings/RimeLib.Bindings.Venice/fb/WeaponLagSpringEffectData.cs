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
	[ContainerType(16, 208)]
	public class WeaponLagSpringEffectData : 
		DataContainer
	{
		[ContainerField(8)]
		public WeaponLagEffectSpringVector OffsetSprings { get; set; } = new();

		[ContainerField(32)]
		public WeaponLagEffectSpringVector RotationSprings { get; set; } = new();

		[ContainerField(64)]
		public WeaponLagEffectForceData JumpForces { get; set; } = new();

		[ContainerField(96)]
		public WeaponLagEffectForceData LandForces { get; set; } = new();

		[ContainerField(128)]
		public WeaponLagEffectForceData PoseUpForces { get; set; } = new();

		[ContainerField(160)]
		public WeaponLagEffectForceData PoseDownForces { get; set; } = new();

		[ContainerField(192), LayoutImmutable, Blittable]
		public float ZoomForceModifier { get; set; }

		public static void Deserialize(WeaponLagSpringEffectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.WeaponLagEffectSpringVector.Deserialize(p_Instance.OffsetSprings, p_Reader, p_Parser);
			fb.WeaponLagEffectSpringVector.Deserialize(p_Instance.RotationSprings, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.WeaponLagEffectForceData.Deserialize(p_Instance.JumpForces, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.WeaponLagEffectForceData.Deserialize(p_Instance.LandForces, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.WeaponLagEffectForceData.Deserialize(p_Instance.PoseUpForces, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.WeaponLagEffectForceData.Deserialize(p_Instance.PoseDownForces, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ZoomForceModifier = p_Reader.ReadSingle();
			p_Reader.Seek(20, SeekOrigin.Current);
		}

	}
}
