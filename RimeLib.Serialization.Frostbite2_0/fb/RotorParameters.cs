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
	[ContainerType(4, 56)]
	public class RotorParameters :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float CyclicInputScaleRoll { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float CyclicInputScalePitch { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float CollectiveThrottleInputScale { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float CollectiveBrakeInputScale { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float CollectiveInputIdle { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float HorizontalForceModifier { get; set; }

		[ContainerField(32), JsonProperty(Order = 32)]
		public List<Vec2> AngleOfAttack { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float CyclicFadeOutOffset { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float AdditionalGravityModifier { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float HorisontalMinEffectMod { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float HorisontalMinEffectVelocity { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public bool EnableHorisontalMinEffect { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		public bool ReverseThrottle { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(CyclicInputScaleRoll);
			p_Writer.Write(CyclicInputScalePitch);
			p_Writer.Write(CollectiveThrottleInputScale);
			p_Writer.Write(CollectiveBrakeInputScale);
			p_Writer.Write(CollectiveInputIdle);
			p_Writer.Write(HorizontalForceModifier);
			(RimeWriter Writer, uint ArrayIndex) s_AngleOfAttack = p_EbxWriter.GetArrayWriter(AngleOfAttack.GetType(), AngleOfAttack.Count);
			p_Writer.Write(s_AngleOfAttack.ArrayIndex);
			foreach (var s_Entry in AngleOfAttack)
			{
				s_Entry.Serialize(s_AngleOfAttack.Writer, p_EbxWriter);
			}
			p_Writer.Write(CyclicFadeOutOffset);
			p_Writer.Write(AdditionalGravityModifier);
			p_Writer.Write(HorisontalMinEffectMod);
			p_Writer.Write(HorisontalMinEffectVelocity);
			p_Writer.Write(EnableHorisontalMinEffect);
			p_Writer.Write(ReverseThrottle);
			p_Writer.WriteNullBytes(2);
		}
	}
}
