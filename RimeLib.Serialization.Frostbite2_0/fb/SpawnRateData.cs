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
	[ContainerType(16, 64)]
	public class SpawnRateData :
		ProcessorData
	{
		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float SpawnRate { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float TrailSegmentLength { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public bool DistributeOverTime { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		public bool DistributeOverDistance { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SpawnRate);
			p_Writer.Write(TrailSegmentLength);
			p_Writer.Write(DistributeOverTime);
			p_Writer.Write(DistributeOverDistance);
			p_Writer.WriteNullBytes(6);
		}
	}
}
