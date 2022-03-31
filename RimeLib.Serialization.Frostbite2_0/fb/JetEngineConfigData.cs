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
	[ContainerType(16, 128)]
	public class JetEngineConfigData :
		EngineConfigData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec2 PowerFadeOutRange { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float ForceMagnitudeMultiplier { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float AngleInputYMultiplier { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float AngleInputPitchMultiplier { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float MaxVelocity { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public uint DirectionVectorIndex { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public bool IsWaterJetEngine { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		public bool IsTurnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			PowerFadeOutRange.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ForceMagnitudeMultiplier);
			p_Writer.Write(AngleInputYMultiplier);
			p_Writer.Write(AngleInputPitchMultiplier);
			p_Writer.Write(MaxVelocity);
			p_Writer.Write(DirectionVectorIndex);
			p_Writer.Write(IsWaterJetEngine);
			p_Writer.Write(IsTurnable);
			p_Writer.WriteNullBytes(2);
		}
	}
}
