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
	[ContainerType(4, 20)]
	public class MissileUnguidedData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 StaticPosition { get; set; } = new();
		
		[ContainerField(8), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 TargetPositionOffset { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool UseTargetPosition { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool UseStaticPosition { get; set; }
		
		public static void Deserialize(MissileUnguidedData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.StaticPosition, p_Reader, p_Parser);
			fb.Vec2.Deserialize(p_Instance.TargetPositionOffset, p_Reader, p_Parser);
			p_Instance.UseTargetPosition = p_Reader.ReadBool();
			p_Instance.UseStaticPosition = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
