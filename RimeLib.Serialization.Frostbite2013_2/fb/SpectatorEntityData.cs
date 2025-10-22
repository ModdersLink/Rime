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
public class SpectatorEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<SpectatorViewData> View { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float CorpseWatchMaxTimeSec { get; set; } = 2.500f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float ViewSyncTimeout { get; set; } = 5.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int ViewSyncExtraFrames { get; set; } = 3;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float ViewSyncExtraDelay { get; set; } = 0.100f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool Enabled { get; set; } = false;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool OnlySameTeam { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(View));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CorpseWatchMaxTimeSec);
		p_Writer.Write(ViewSyncTimeout);
		p_Writer.Write(ViewSyncExtraFrames);
		p_Writer.Write(ViewSyncExtraDelay);
		p_Writer.Write(Enabled);
		p_Writer.Write(OnlySameTeam);
		p_Writer.WriteNullBytes(6);
	}
}

