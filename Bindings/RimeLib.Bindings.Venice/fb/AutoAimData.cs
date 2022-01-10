///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 80)]
	public class AutoAimData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AutoAimOuterBoxOffset { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AutoAimOuterBoxExtends { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AutoAimInnerBoxOffset { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AutoAimInnerBoxExtends { get; set; } = new();
		
		[ContainerField(64)]
		public CharacterPoseType PoseType { get; set; } = new();
		
		public static void Deserialize(AutoAimData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.AutoAimOuterBoxOffset, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.AutoAimOuterBoxExtends, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.AutoAimInnerBoxOffset, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.AutoAimInnerBoxExtends, p_Reader, p_Parser);
			p_Instance.PoseType = (CharacterPoseType) p_Reader.ReadInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
		}
	}
}
