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

using fb.Entity;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 72)]
public class SectorScanActionData
	: fb.VeniceShared.CommanderActionBaseData
{
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float ScanFrequency { get; set; } = 2.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float ScanRadius { get; set; } = 50.000f;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<PrefabBlueprint> UAVDronePrefabBlueprint { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float PrefabSpawnHeightOffset { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ScanFrequency);
		p_Writer.Write(ScanRadius);
		p_Writer.Write(p_EbxWriter.WriteImport(UAVDronePrefabBlueprint));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PrefabSpawnHeightOffset);
		p_Writer.WriteNullBytes(4);
	}
}

