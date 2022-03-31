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

namespace fb
{
	[ContainerType(4, 52)]
	public class AimingConstraintEntityCommonData :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public AimingConstraintEntityBinding AimingConstraintsBinding { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public AimingConstraintsData AimingConstraints { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float DisableAimingConstraintsDelay { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float ConstraintMoveSpeedMultiplier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float ShuffleAnimationThreshold { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float ShuffleAnimationDelay { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AimingConstraintsBinding.Serialize(p_Writer, p_EbxWriter);
			AimingConstraints.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DisableAimingConstraintsDelay);
			p_Writer.Write(ConstraintMoveSpeedMultiplier);
			p_Writer.Write(ShuffleAnimationThreshold);
			p_Writer.Write(ShuffleAnimationDelay);
		}
	}
}
