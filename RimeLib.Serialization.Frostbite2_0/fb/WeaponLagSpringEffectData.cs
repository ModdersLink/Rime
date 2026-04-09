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
	[ContainerType(16, 208)]
	public partial class WeaponLagSpringEffectData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private WeaponLagEffectSpringVector _OffsetSprings = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private WeaponLagEffectSpringVector _RotationSprings = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private WeaponLagEffectForceData _JumpForces = new();

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private WeaponLagEffectForceData _LandForces = new();

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private WeaponLagEffectForceData _PoseUpForces = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private WeaponLagEffectForceData _PoseDownForces = new();

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _ZoomForceModifier;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			OffsetSprings.Serialize(p_Writer, p_EbxWriter);
			RotationSprings.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			JumpForces.Serialize(p_Writer, p_EbxWriter);
			LandForces.Serialize(p_Writer, p_EbxWriter);
			PoseUpForces.Serialize(p_Writer, p_EbxWriter);
			PoseDownForces.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ZoomForceModifier);
			p_Writer.WriteNullBytes(12);
		}
	}
}
