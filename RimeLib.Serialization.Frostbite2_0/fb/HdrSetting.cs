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
	[ContainerType(4, 68)]
	public class HdrSetting :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float WindowMinTop { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float WindowMinBottom { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float WindowTopMinReleaseTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float WindowTopMaxReleaseTime { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float WindowTopAttackTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float WindowBottomReleaseTime { get; set; }

		[ContainerField(32), JsonProperty(Order = 32)]
		public AudioCurve WindowTopReleaseTimeCurve { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float DischargeFactor { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float MaxAllowedEnergy { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float WindowBottomAttackTime { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float WindowSize { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float CompressFactor { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float Headroom { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float AllowedOvershoot { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(WindowMinTop);
			p_Writer.Write(WindowMinBottom);
			p_Writer.Write(WindowTopMinReleaseTime);
			p_Writer.Write(WindowTopMaxReleaseTime);
			p_Writer.Write(WindowTopAttackTime);
			p_Writer.Write(WindowBottomReleaseTime);
			WindowTopReleaseTimeCurve.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DischargeFactor);
			p_Writer.Write(MaxAllowedEnergy);
			p_Writer.Write(WindowBottomAttackTime);
			p_Writer.Write(WindowSize);
			p_Writer.Write(CompressFactor);
			p_Writer.Write(Headroom);
			p_Writer.Write(AllowedOvershoot);
		}
	}
}
