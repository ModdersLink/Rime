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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 176)]
	public partial class VehicleEntryListenerComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private VehicleEntryListenerBinding _VehicleEntryListener = new();

		[ObservableProperty]
		[property: ContainerField(156), JsonProperty(Order = 156)]
		private VehicleCameraControlBinding _VehicleCameraControl = new();

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private int _AnimationEntitySpacePriority;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _AnimationWheelTransformDelay;

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
