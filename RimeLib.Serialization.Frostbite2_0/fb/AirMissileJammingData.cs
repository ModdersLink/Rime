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
	public class AirMissileJammingData :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public float MinTurnSpeed { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public float MaxRadius { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float MinRadius { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float Theta { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float Phi { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float UpdateJammingPositionTime { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float MaxTurnSpeed { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float QuietModeProbability { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float QuietModeTime { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float JammingTime { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float TurnCalculationTime { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool EnableAirMissileJamming { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MinTurnSpeed);
			p_Writer.Write(MaxRadius);
			p_Writer.Write(MinRadius);
			p_Writer.Write(Theta);
			p_Writer.Write(Phi);
			p_Writer.Write(UpdateJammingPositionTime);
			p_Writer.Write(MaxTurnSpeed);
			p_Writer.Write(QuietModeProbability);
			p_Writer.Write(QuietModeTime);
			p_Writer.Write(JammingTime);
			p_Writer.Write(TurnCalculationTime);
			p_Writer.Write(EnableAirMissileJamming);
			p_Writer.WriteNullBytes(3);
		}
	}
}
