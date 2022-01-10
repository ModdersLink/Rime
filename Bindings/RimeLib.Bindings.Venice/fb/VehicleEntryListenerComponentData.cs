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
	[ContainerType(16, 176)]
	public class VehicleEntryListenerComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public VehicleEntryListenerBinding VehicleEntryListener { get; set; } = new();

		[ContainerField(156)]
		public VehicleCameraControlBinding VehicleCameraControl { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float AnimationWheelTransformDelay { get; set; }

		public static void Deserialize(VehicleEntryListenerComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.VehicleEntryListenerBinding.Deserialize(p_Instance.VehicleEntryListener, p_Reader, p_Parser);
			fb.VehicleCameraControlBinding.Deserialize(p_Instance.VehicleCameraControl, p_Reader, p_Parser);
			p_Instance.AnimationEntitySpacePriority = p_Reader.ReadInt32();
			p_Instance.AnimationWheelTransformDelay = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
