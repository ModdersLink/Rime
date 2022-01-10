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
	public class PackagingRule : 
		Asset
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DebugColor { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool CanTargetSelf { get; set; }

		public static void Deserialize(PackagingRule p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.DebugColor, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.CanTargetSelf = p_Reader.ReadBool();
			p_Reader.Seek(19, SeekOrigin.Current);
		}

	}
}
