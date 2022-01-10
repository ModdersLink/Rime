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
	[ContainerType(4, 8)]
	public class SoldierAnimatedCameraData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float CameraTransitionTime { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public bool EnableFeature { get; set; }
		
		public static void Deserialize(SoldierAnimatedCameraData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CameraTransitionTime = p_Reader.ReadSingle();
			p_Instance.EnableFeature = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
