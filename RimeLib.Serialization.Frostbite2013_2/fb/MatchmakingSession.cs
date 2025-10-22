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

namespace fb.Online;

[ContainerType(8, 160)]
public class MatchmakingSession
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public MatchmakingSessionMode Mode { get; set; } = MatchmakingSessionMode.MatchmakingSessionMode_FindDedicatedServer;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint DurationMs { get; set; } = 0;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public MatchmakingCriteria Criteria { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<GameParametersData> CreateGameParams { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<MatchmakingSession> OnNotFound { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public RefArray<MatchmakingModifier> Modifiers { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Mode);
		p_Writer.Write(DurationMs);
		Criteria.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(CreateGameParams));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(OnNotFound));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Modifiers = p_EbxWriter.GetArrayWriter(Modifiers.GetType(), Modifiers.Count);
		p_Writer.Write(s_Modifiers.ArrayIndex);
		foreach (var s_Entry in Modifiers)
		{
			s_Modifiers.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

