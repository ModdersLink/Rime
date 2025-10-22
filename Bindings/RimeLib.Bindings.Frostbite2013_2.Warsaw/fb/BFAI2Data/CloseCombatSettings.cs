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

namespace fb.BFAI2Data;

[ContainerType(8, 40)]
public class CloseCombatSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float Distance { get; set; } = 6.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float HeightDistance { get; set; } = 2.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float DistanceLimit { get; set; } = 15.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float LostVisibilityTimeout { get; set; } = 2.000f;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<PoseSettings> PoseSettings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Distance);
		p_Writer.Write(HeightDistance);
		p_Writer.Write(DistanceLimit);
		p_Writer.Write(LostVisibilityTimeout);
		p_Writer.Write(p_EbxWriter.WriteImport(PoseSettings));
		p_Writer.WriteNullBytes(4);
	}
}

