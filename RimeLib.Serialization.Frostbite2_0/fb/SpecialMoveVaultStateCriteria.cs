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
	[ContainerType(4, 84)]
	public class SpecialMoveVaultStateCriteria :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public float DistToObject { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public float DistToObjectTolerance { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float HeightOfObject { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float HeightOfObjectTolerance { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float LengthOfObject { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float LengthOfObjectTolerance { get; set; }
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public SpecialMoveStateData SpecialMoveState { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DistToObject);
			p_Writer.Write(DistToObjectTolerance);
			p_Writer.Write(HeightOfObject);
			p_Writer.Write(HeightOfObjectTolerance);
			p_Writer.Write(LengthOfObject);
			p_Writer.Write(LengthOfObjectTolerance);
			SpecialMoveState.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
