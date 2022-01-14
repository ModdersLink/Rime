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
	[ContainerType(4, 24)]
	public class TurretRotationInfo :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public RotationAxis RotationAxis { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public RotationChannel Channel { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float MaxRotation { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float MinRotation { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float PhaseOffset { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool NormalizeRotation { get; set; }
		
		[ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		public bool InvertRotation { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) RotationAxis);
			p_Writer.Write((int) Channel);
			p_Writer.Write(MaxRotation);
			p_Writer.Write(MinRotation);
			p_Writer.Write(PhaseOffset);
			p_Writer.Write(NormalizeRotation);
			p_Writer.Write(InvertRotation);
			p_Writer.WriteNullBytes(2);
		}
	}
}
