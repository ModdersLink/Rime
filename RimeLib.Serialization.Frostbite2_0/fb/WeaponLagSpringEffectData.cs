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
	[ContainerType(16, 208)]
	public class WeaponLagSpringEffectData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public WeaponLagEffectSpringVector OffsetSprings { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public WeaponLagEffectSpringVector RotationSprings { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public WeaponLagEffectForceData JumpForces { get; set; } = new();

		[ContainerField(96), JsonProperty(Order = 96)]
		public WeaponLagEffectForceData LandForces { get; set; } = new();

		[ContainerField(128), JsonProperty(Order = 128)]
		public WeaponLagEffectForceData PoseUpForces { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public WeaponLagEffectForceData PoseDownForces { get; set; } = new();

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float ZoomForceModifier { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
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
