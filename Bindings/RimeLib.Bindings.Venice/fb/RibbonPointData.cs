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
	[ContainerType(16, 48)]
	public class RibbonPointData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UserMaskRight { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UserMaskLeft { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float Right { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float Left { get; set; }
		
		public static void Deserialize(RibbonPointData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.UserMaskRight, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.UserMaskLeft, p_Reader, p_Parser);
			p_Instance.Right = p_Reader.ReadSingle();
			p_Instance.Left = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}
	}
}
