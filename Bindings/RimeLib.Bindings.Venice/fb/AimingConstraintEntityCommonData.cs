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
	[ContainerType(4, 52)]
	public class AimingConstraintEntityCommonData : 
		Asset
	{
		[ContainerField(12)]
		public AimingConstraintEntityBinding AimingConstraintsBinding { get; set; } = new();

		[ContainerField(20)]
		public AimingConstraintsData AimingConstraints { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float DisableAimingConstraintsDelay { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float ConstraintMoveSpeedMultiplier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float ShuffleAnimationThreshold { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float ShuffleAnimationDelay { get; set; }

		public static void Deserialize(AimingConstraintEntityCommonData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AimingConstraintEntityBinding.Deserialize(p_Instance.AimingConstraintsBinding, p_Reader, p_Parser);
			fb.AimingConstraintsData.Deserialize(p_Instance.AimingConstraints, p_Reader, p_Parser);
			p_Instance.DisableAimingConstraintsDelay = p_Reader.ReadSingle();
			p_Instance.ConstraintMoveSpeedMultiplier = p_Reader.ReadSingle();
			p_Instance.ShuffleAnimationThreshold = p_Reader.ReadSingle();
			p_Instance.ShuffleAnimationDelay = p_Reader.ReadSingle();
		}

	}
}
