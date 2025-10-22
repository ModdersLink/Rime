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
using fb.Ant;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 96)]
public class AnimationSignalEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AntRef Signal { get; set; } = new();
	
	[ContainerField(0x2c), JsonProperty(Order = 44)]
	public AntRef IntGameState { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public AntRef FloatGameState { get; set; } = new();
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public int ValueInt { get; set; } = 0;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float ValueFloat { get; set; } = 0.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool Reset { get; set; } = false;
	
	[ContainerField(0x5d), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
	public bool Continuous { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Signal.Serialize(p_Writer, p_EbxWriter);
		IntGameState.Serialize(p_Writer, p_EbxWriter);
		FloatGameState.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ValueInt);
		p_Writer.Write(ValueFloat);
		p_Writer.Write(Reset);
		p_Writer.Write(Continuous);
		p_Writer.WriteNullBytes(2);
	}
}

