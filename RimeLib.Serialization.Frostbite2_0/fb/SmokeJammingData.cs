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
	[ContainerType(4, 20)]
	public class SmokeJammingData :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public float JammingTime { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public float MaxRadius { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float MinRadius { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float TargetUpdateTime { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool EnableSmokeJamming { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		public bool JammingPositionIsLocationDependent { get; set; }
		
		[ContainerField(18), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
		public bool ReportJammedBasedOnStartPosition { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(JammingTime);
			p_Writer.Write(MaxRadius);
			p_Writer.Write(MinRadius);
			p_Writer.Write(TargetUpdateTime);
			p_Writer.Write(EnableSmokeJamming);
			p_Writer.Write(JammingPositionIsLocationDependent);
			p_Writer.Write(ReportJammedBasedOnStartPosition);
			p_Writer.WriteNullBytes(1);
		}
	}
}
