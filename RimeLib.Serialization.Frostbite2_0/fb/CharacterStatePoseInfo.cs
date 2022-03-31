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
	[ContainerType(4, 48)]
	public class CharacterStatePoseInfo :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CharacterPoseType PoseType { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float Velocity { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float AccelerationGain { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float DecelerationGain { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float SprintGain { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float SprintMultiplier { get; set; }

		[ContainerField(32), JsonProperty(Order = 32)]
		public SpeedModifierData SpeedModifier { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) PoseType);
			p_Writer.Write(Velocity);
			p_Writer.Write(AccelerationGain);
			p_Writer.Write(DecelerationGain);
			p_Writer.Write(SprintGain);
			p_Writer.Write(SprintMultiplier);
			SpeedModifier.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
