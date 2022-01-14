///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 176)]
	public class VehicleEntryListenerComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public VehicleEntryListenerBinding VehicleEntryListener { get; set; } = new();

		[ContainerField(156), JsonProperty(Order = 156)]
		public VehicleCameraControlBinding VehicleCameraControl { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public int AnimationEntitySpacePriority { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float AnimationWheelTransformDelay { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			VehicleEntryListener.Serialize(p_Writer, p_EbxWriter);
			VehicleCameraControl.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AnimationEntitySpacePriority);
			p_Writer.Write(AnimationWheelTransformDelay);
			p_Writer.WriteNullBytes(8);
		}
	}
}
