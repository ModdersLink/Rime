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
	[ContainerType(4, 44)]
	public class HudTrackerData :
		UIPartData
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float MaxDistance { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float StartFadeDistance { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float SecondFadeDistance { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float FadeMinAlpha { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float IconSize { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float TrackerHudRadiusX { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float TrackerHudRadiusY { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float DistanceTextOffsetY { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool ShowDistance { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		public bool DisplayExtraInfo { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MaxDistance);
			p_Writer.Write(StartFadeDistance);
			p_Writer.Write(SecondFadeDistance);
			p_Writer.Write(FadeMinAlpha);
			p_Writer.Write(IconSize);
			p_Writer.Write(TrackerHudRadiusX);
			p_Writer.Write(TrackerHudRadiusY);
			p_Writer.Write(DistanceTextOffsetY);
			p_Writer.Write(ShowDistance);
			p_Writer.Write(DisplayExtraInfo);
			p_Writer.WriteNullBytes(2);
		}
	}
}
