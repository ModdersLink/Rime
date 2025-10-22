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

namespace fb.SoldierShared;

[ContainerType(8, 160)]
public class CoverPeekEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CoverPeekBinding Binding { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float DetectDistanceForward { get; set; } = 1.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float DetectDistanceHorizontal { get; set; } = 0.400f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public bool OverEnabled { get; set; } = true;
	
	[ContainerField(0x99), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
	public bool HorizEnabled { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Binding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DetectDistanceForward);
		p_Writer.Write(DetectDistanceHorizontal);
		p_Writer.Write(OverEnabled);
		p_Writer.Write(HorizEnabled);
		p_Writer.WriteNullBytes(6);
	}
}

