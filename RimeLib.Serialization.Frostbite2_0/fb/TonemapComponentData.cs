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
	[ContainerType(16, 160)]
	public class TonemapComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 BloomScale { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public Realm Realm { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public TonemapMethod TonemapMethod { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float MinExposure { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float MiddleGray { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float ExposureAdjustTime { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float MaxExposure { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float ChromostereopsisOffset { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float ChromostereopsisScale { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public bool ChromostereopsisEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			BloomScale.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write((int) TonemapMethod);
			p_Writer.Write(MinExposure);
			p_Writer.Write(MiddleGray);
			p_Writer.Write(ExposureAdjustTime);
			p_Writer.Write(MaxExposure);
			p_Writer.Write(ChromostereopsisOffset);
			p_Writer.Write(ChromostereopsisScale);
			p_Writer.Write(ChromostereopsisEnable);
			p_Writer.WriteNullBytes(15);
		}
	}
}
