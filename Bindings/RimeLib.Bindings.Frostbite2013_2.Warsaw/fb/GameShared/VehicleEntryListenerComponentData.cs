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

using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 464)]
public class VehicleEntryListenerComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public VehicleEntryListenerBinding VehicleEntryListener { get; set; } = new();
	
	[ContainerField(0x1b0), JsonProperty(Order = 432)]
	public VehicleCameraControlBinding VehicleCameraControl { get; set; } = new();
	
	[ContainerField(0x1c4), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
	public int AnimationEntitySpacePriority { get; set; } = 0;
	
	[ContainerField(0x1c8), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
	public float AnimationWheelTransformDelay { get; set; } = 0.500f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		VehicleEntryListener.Serialize(p_Writer, p_EbxWriter);
		VehicleCameraControl.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AnimationEntitySpacePriority);
		p_Writer.Write(AnimationWheelTransformDelay);
		p_Writer.WriteNullBytes(4);
	}
}

