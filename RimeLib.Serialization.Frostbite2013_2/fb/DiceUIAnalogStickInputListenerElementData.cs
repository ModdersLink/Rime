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
using fb.GameShared;
using fb.Entity;

namespace fb.DiceCommonsShared;

[ContainerType(16, 224)]
public class DiceUIAnalogStickInputListenerElementData
	: fb.GameShared.UIElementEntityData
{
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public DiceUIAnalogStick AnalogStick { get; set; } = DiceUIAnalogStick.DiceUIAnalogStick_Left;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float TriggerThreshold { get; set; } = 0.700f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float DeadZone { get; set; } = 0.100f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public bool ConsumeInput { get; set; } = true;
	
	[ContainerField(0xdd), LayoutImmutable, Blittable, JsonProperty(Order = 221)]
	public bool FlipYAxis { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) AnalogStick);
		p_Writer.Write(TriggerThreshold);
		p_Writer.Write(DeadZone);
		p_Writer.Write(ConsumeInput);
		p_Writer.Write(FlipYAxis);
		p_Writer.WriteNullBytes(2);
	}
}

