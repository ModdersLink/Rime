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
	[ContainerType(4, 52)]
	public partial class AimingConstraintEntityCommonData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AimingConstraintEntityBinding _AimingConstraintsBinding = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AimingConstraintsData _AimingConstraints = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _DisableAimingConstraintsDelay;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _ConstraintMoveSpeedMultiplier;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _ShuffleAnimationThreshold;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _ShuffleAnimationDelay;

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
