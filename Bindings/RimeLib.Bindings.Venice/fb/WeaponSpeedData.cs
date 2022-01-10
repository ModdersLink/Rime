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
	[ContainerType(4, 24)]
	public class WeaponSpeedData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float ZoomOutSpeed { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float ZoomInSpeed { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float UnDeploySpeed { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float DeploySpeed { get; set; }

		public static void Deserialize(WeaponSpeedData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ZoomOutSpeed = p_Reader.ReadSingle();
			p_Instance.ZoomInSpeed = p_Reader.ReadSingle();
			p_Instance.UnDeploySpeed = p_Reader.ReadSingle();
			p_Instance.DeploySpeed = p_Reader.ReadSingle();
		}

	}
}
