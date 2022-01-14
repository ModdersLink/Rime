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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 100)]
	public class HudCameraShakeData :
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float WeaponDispersionMin { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float WeaponDispersionMax { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float WeaponDispersionOffsetScale { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float JumpEffectDurationMin { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float JumpEffectDurationMax { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float JumpEffectMin { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float JumpEffectMax { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float LandEffectDurationMin { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float LandEffectDurationMax { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float LandEffectMin { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float LandEffectMax { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float CameraShakeMinAngle { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float CameraShakeMaxAngle { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float CameraShakeScale { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float WeaponLagXScale { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float WeaponLagYScale { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public uint FilterSize { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float MaxDisplacement { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(WeaponDispersionMin);
			p_Writer.Write(WeaponDispersionMax);
			p_Writer.Write(WeaponDispersionOffsetScale);
			p_Writer.Write(JumpEffectDurationMin);
			p_Writer.Write(JumpEffectDurationMax);
			p_Writer.Write(JumpEffectMin);
			p_Writer.Write(JumpEffectMax);
			p_Writer.Write(LandEffectDurationMin);
			p_Writer.Write(LandEffectDurationMax);
			p_Writer.Write(LandEffectMin);
			p_Writer.Write(LandEffectMax);
			p_Writer.Write(CameraShakeMinAngle);
			p_Writer.Write(CameraShakeMaxAngle);
			p_Writer.Write(CameraShakeScale);
			p_Writer.Write(WeaponLagXScale);
			p_Writer.Write(WeaponLagYScale);
			p_Writer.Write(FilterSize);
			p_Writer.Write(MaxDisplacement);
		}
	}
}
