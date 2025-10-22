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

namespace fb.Terrain;

[ContainerType(8, 48)]
public class TerrainSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint HeightQueryCacheSize { get; set; } = 16;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint ModifiersCapacity { get; set; } = 5000;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint IntersectingModifiersMax { get; set; } = 16;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float ModifierSlopeMax { get; set; } = 0.460f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float ModifierDepthFactor { get; set; } = 1.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint ModifiersAppliedPerFrameMax { get; set; } = 8;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool ModifiersEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(HeightQueryCacheSize);
		p_Writer.Write(ModifiersCapacity);
		p_Writer.Write(IntersectingModifiersMax);
		p_Writer.Write(ModifierSlopeMax);
		p_Writer.Write(ModifierDepthFactor);
		p_Writer.Write(ModifiersAppliedPerFrameMax);
		p_Writer.Write(ModifiersEnable);
		p_Writer.WriteNullBytes(7);
	}
}

