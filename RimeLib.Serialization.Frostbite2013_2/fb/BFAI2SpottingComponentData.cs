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

namespace fb.BFAI2Data;

[ContainerType(16, 128)]
public class BFAI2SpottingComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float SpottingFov { get; set; } = 5.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float SpottingDistance { get; set; } = 1200.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float VisorEquipHoldTime { get; set; } = 0.250f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public int VisorWeaponIndex { get; set; } = 8;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SpottingFov);
		p_Writer.Write(SpottingDistance);
		p_Writer.Write(VisorEquipHoldTime);
		p_Writer.Write(VisorWeaponIndex);
	}
}

