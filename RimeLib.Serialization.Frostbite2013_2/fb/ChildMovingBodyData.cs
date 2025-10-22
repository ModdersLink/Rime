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
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 128)]
public class ChildMovingBodyData
	: fb.Physics.LinearMovingBodyData
{
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float InputDelay { get; set; } = 0.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float Speed { get; set; } = 10.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public int InputAction { get; set; } = 1018135856;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float TriggerImpulse { get; set; } = 0.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool IsOneShotInput { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(InputDelay);
		p_Writer.Write(Speed);
		p_Writer.Write(InputAction);
		p_Writer.Write(TriggerImpulse);
		p_Writer.Write(IsOneShotInput);
		p_Writer.WriteNullBytes(15);
	}
}

