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

namespace fb.VeniceShared;

[ContainerType(8, 56)]
public class RadarScanActionData
	: fb.VeniceShared.CommanderActionBaseData
{
	public RadarScanActionData()
	{
		//CommanderActionBaseData
		ActionType = CommanderActionType.CommanderActionType_RadarScan;
	}
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public RadarScanMode ScanMode { get; set; } = RadarScanMode.RSM_LeftToRight;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float ScanAreaPadding { get; set; } = 100.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) ScanMode);
		p_Writer.Write(ScanAreaPadding);
	}
}

