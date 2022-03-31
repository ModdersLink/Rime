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
	[ContainerType(16, 48)]
	public class DebrisClusterPartInfoData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 AngularVelocity { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 LinearVelocity { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public int NumberOfChildren { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public int PartIndex { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float SplitSpeedThreshold { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool InEffectWorldOnly { get; set; }
		
		[ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		public bool SyncRestPosition { get; set; }
		
		[ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		public bool SyncContinous { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AngularVelocity.Serialize(p_Writer, p_EbxWriter);
			LinearVelocity.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(NumberOfChildren);
			p_Writer.Write(PartIndex);
			p_Writer.Write(SplitSpeedThreshold);
			p_Writer.Write(InEffectWorldOnly);
			p_Writer.Write(SyncRestPosition);
			p_Writer.Write(SyncContinous);
			p_Writer.WriteNullBytes(1);
		}
	}
}
