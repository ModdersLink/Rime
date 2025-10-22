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

using fb.GameShared;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 80)]
public class PersistenceSettings
	: fb.Core.SystemSettings
{
	public PersistenceSettings()
	{
		//SystemSettings
		Name = @"Persistence";
	}
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<PersistenceData> SingleplayerTemplate { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<PersistenceData> CoopTemplate { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<PersistenceData> MultiplayerTemplate { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<PointSystemParamsAsset> PointSystemParams { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<RankParamsAsset> RankParams { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<SkillLevelParameters> SkillLevelParams { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SingleplayerTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CoopTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MultiplayerTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PointSystemParams));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(RankParams));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SkillLevelParams));
		p_Writer.WriteNullBytes(4);
	}
}

