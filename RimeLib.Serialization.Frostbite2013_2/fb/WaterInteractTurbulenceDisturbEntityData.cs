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

namespace fb.WaterInteract;

[ContainerType(16, 128)]
public class WaterInteractTurbulenceDisturbEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float DisturbFreq { get; set; } = 30.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float AreaSizeX { get; set; } = 0.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float AreaSizeZ { get; set; } = 0.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float DisturbSize { get; set; } = 0.500f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float DisturbVel { get; set; } = 5.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DisturbFreq);
		p_Writer.Write(AreaSizeX);
		p_Writer.Write(AreaSizeZ);
		p_Writer.Write(DisturbSize);
		p_Writer.Write(DisturbVel);
		p_Writer.WriteNullBytes(12);
	}
}

