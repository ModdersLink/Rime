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
	[ContainerType(16, 32)]
	public class ConstantForceData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 Value { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public ForceCondition Condition { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public ForceType TypeOfForce { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public SpaceType Space { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Value.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Condition);
			p_Writer.Write((int) TypeOfForce);
			p_Writer.Write((int) Space);
			p_Writer.WriteNullBytes(4);
		}
	}
}
