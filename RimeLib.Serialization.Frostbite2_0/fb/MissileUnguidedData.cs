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
	[ContainerType(4, 20)]
	public class MissileUnguidedData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec2 StaticPosition { get; set; } = new();
		
		[ContainerField(8), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public Vec2 TargetPositionOffset { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool UseTargetPosition { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		public bool UseStaticPosition { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			StaticPosition.Serialize(p_Writer, p_EbxWriter);
			TargetPositionOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UseTargetPosition);
			p_Writer.Write(UseStaticPosition);
			p_Writer.WriteNullBytes(2);
		}
	}
}
