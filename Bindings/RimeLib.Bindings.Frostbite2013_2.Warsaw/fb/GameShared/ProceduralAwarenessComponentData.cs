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

[ContainerType(16, 240)]
public class ProceduralAwarenessComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 TargetOverride { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public ProceduralAwarenessComponentBinding Binding { get; set; } = new();
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0xe5), LayoutImmutable, Blittable, JsonProperty(Order = 229)]
	public bool ForceLookAtPlayer { get; set; } = false;
	
	[ContainerField(0xe6), LayoutImmutable, Blittable, JsonProperty(Order = 230)]
	public bool DisableRandomForcedLooksAtPlayer { get; set; } = false;
	
	[ContainerField(0xe7), LayoutImmutable, Blittable, JsonProperty(Order = 231)]
	public bool UseTargetOverride { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		TargetOverride.Serialize(p_Writer, p_EbxWriter);
		Binding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Enabled);
		p_Writer.Write(ForceLookAtPlayer);
		p_Writer.Write(DisableRandomForcedLooksAtPlayer);
		p_Writer.Write(UseTargetOverride);
		p_Writer.WriteNullBytes(8);
	}
}

