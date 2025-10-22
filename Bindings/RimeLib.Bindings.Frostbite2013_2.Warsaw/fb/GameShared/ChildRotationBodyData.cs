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

[ContainerType(8, 96)]
public class ChildRotationBodyData
	: fb.Physics.RotationBodyData
{
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float ForceModifier { get; set; } = 100000.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float ResetForceModifier { get; set; } = 0.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float ResetForceInputThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public int RotationInput { get; set; } = -754024050;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float WorldSpaceLockEfficiency { get; set; } = 0.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool UseLinearInput { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ForceModifier);
		p_Writer.Write(ResetForceModifier);
		p_Writer.Write(ResetForceInputThreshold);
		p_Writer.Write(RotationInput);
		p_Writer.Write(WorldSpaceLockEfficiency);
		p_Writer.Write(UseLinearInput);
		p_Writer.WriteNullBytes(3);
	}
}

