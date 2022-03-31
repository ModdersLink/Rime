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
	[ContainerType(4, 24)]
	public class GunSwayRecoilData :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public float RecoilAmplitudeMax { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public float RecoilAmplitudeIncPerShot { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float HorizontalRecoilAmplitudeIncPerShotMin { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float HorizontalRecoilAmplitudeIncPerShotMax { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float HorizontalRecoilAmplitudeMax { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float RecoilAmplitudeDecreaseFactor { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(RecoilAmplitudeMax);
			p_Writer.Write(RecoilAmplitudeIncPerShot);
			p_Writer.Write(HorizontalRecoilAmplitudeIncPerShotMin);
			p_Writer.Write(HorizontalRecoilAmplitudeIncPerShotMax);
			p_Writer.Write(HorizontalRecoilAmplitudeMax);
			p_Writer.Write(RecoilAmplitudeDecreaseFactor);
		}
	}
}
