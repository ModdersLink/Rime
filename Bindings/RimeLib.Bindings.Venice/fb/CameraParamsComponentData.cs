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
	[ContainerType(16, 112)]
	public class CameraParamsComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float NearPlane { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float SunShadowmapViewDistance { get; set; }

		public static void Deserialize(CameraParamsComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ViewDistance = p_Reader.ReadSingle();
			p_Instance.NearPlane = p_Reader.ReadSingle();
			p_Instance.SunShadowmapViewDistance = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
