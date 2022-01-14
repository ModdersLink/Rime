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
	[ContainerType(16, 80)]
	public class AutoAimData :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 AutoAimOuterBoxOffset { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 AutoAimOuterBoxExtends { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 AutoAimInnerBoxOffset { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 AutoAimInnerBoxExtends { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public CharacterPoseType PoseType { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AutoAimOuterBoxOffset.Serialize(p_Writer, p_EbxWriter);
			AutoAimOuterBoxExtends.Serialize(p_Writer, p_EbxWriter);
			AutoAimInnerBoxOffset.Serialize(p_Writer, p_EbxWriter);
			AutoAimInnerBoxExtends.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) PoseType);
			p_Writer.WriteNullBytes(12);
		}
	}
}
