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
	[ContainerType(16, 32)]
	public class PickupSettingsData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MeshRenderOffset { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MeshRenderRotation { get; set; } = new();
		
		public static void Deserialize(PickupSettingsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.MeshRenderOffset, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.MeshRenderRotation, p_Reader, p_Parser);
		}
	}
}
