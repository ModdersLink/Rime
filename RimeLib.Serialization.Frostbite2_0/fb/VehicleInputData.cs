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
	[ContainerType(4, 80)]
	public class VehicleInputData :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public float ThrottleDeadzone { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public float BrakeDeadzone { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float YawDeadzone { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float PitchDeadzone { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float RollDeadzone { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float ThrottleInertiaOutDuration { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float ThrottleInertiaInDuration { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float ThrottleInertiaMinRatio { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float BrakeInertiaOutDuration { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float BrakeInertiaInDuration { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float BrakeInertiaMinRatio { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float YawInertiaOutDuration { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float YawInertiaInDuration { get; set; }
		
		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float YawInertiaMinRatio { get; set; }
		
		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float PitchInertiaOutDuration { get; set; }
		
		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float PitchInertiaInDuration { get; set; }
		
		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float PitchInertiaMinRatio { get; set; }
		
		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float RollInertiaOutDuration { get; set; }
		
		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float RollInertiaInDuration { get; set; }
		
		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float RollInertiaMinRatio { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ThrottleDeadzone);
			p_Writer.Write(BrakeDeadzone);
			p_Writer.Write(YawDeadzone);
			p_Writer.Write(PitchDeadzone);
			p_Writer.Write(RollDeadzone);
			p_Writer.Write(ThrottleInertiaOutDuration);
			p_Writer.Write(ThrottleInertiaInDuration);
			p_Writer.Write(ThrottleInertiaMinRatio);
			p_Writer.Write(BrakeInertiaOutDuration);
			p_Writer.Write(BrakeInertiaInDuration);
			p_Writer.Write(BrakeInertiaMinRatio);
			p_Writer.Write(YawInertiaOutDuration);
			p_Writer.Write(YawInertiaInDuration);
			p_Writer.Write(YawInertiaMinRatio);
			p_Writer.Write(PitchInertiaOutDuration);
			p_Writer.Write(PitchInertiaInDuration);
			p_Writer.Write(PitchInertiaMinRatio);
			p_Writer.Write(RollInertiaOutDuration);
			p_Writer.Write(RollInertiaInDuration);
			p_Writer.Write(RollInertiaMinRatio);
		}
	}
}
