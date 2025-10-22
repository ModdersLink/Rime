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

namespace fb.Render;

[ContainerType(8, 48)]
public class DynamicTextureAtlasSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint EmitterBaseWidth { get; set; } = 4096;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint EmitterBaseHeight { get; set; } = 4096;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint EmitterBaseMipmapCount { get; set; } = 5;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public uint EmitterBaseSkipmipsCount { get; set; } = 0;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint EmitterNormalWidth { get; set; } = 512;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint EmitterNormalHeight { get; set; } = 512;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint EmitterNormalMipmapCount { get; set; } = 3;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint EmitterNormalSkipmipsCount { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(EmitterBaseWidth);
		p_Writer.Write(EmitterBaseHeight);
		p_Writer.Write(EmitterBaseMipmapCount);
		p_Writer.Write(EmitterBaseSkipmipsCount);
		p_Writer.Write(EmitterNormalWidth);
		p_Writer.Write(EmitterNormalHeight);
		p_Writer.Write(EmitterNormalMipmapCount);
		p_Writer.Write(EmitterNormalSkipmipsCount);
	}
}

