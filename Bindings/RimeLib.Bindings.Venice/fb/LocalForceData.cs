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
	[ContainerType(16, 64)]
	public class LocalForceData : 
		ProcessorData
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 LocalForce { get; set; } = new();

		public static void Deserialize(LocalForceData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.LocalForce, p_Reader, p_Parser);
		}

	}
}
