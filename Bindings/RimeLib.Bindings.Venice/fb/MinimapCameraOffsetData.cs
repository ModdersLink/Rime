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
	[ContainerType(4, 12)]
	public class MinimapCameraOffsetData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Position { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CameraFov { get; set; }
		
		public static void Deserialize(MinimapCameraOffsetData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.Position, p_Reader, p_Parser);
			p_Instance.CameraFov = p_Reader.ReadSingle();
		}
	}
}
