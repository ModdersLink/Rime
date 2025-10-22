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

namespace fb.VeniceShared;

[ContainerType(8, 48)]
public class NuiSpeechSettings
	: fb.Core.SystemSettings
{
	public NuiSpeechSettings()
	{
		//SystemSettings
		Name = @"NuiSpeech";
	}
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<NuiSpeechDialect> DialectsConfiguration { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<NuiSpeechConfidencePolicySetup> DefaultConfidencePolicy { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_DialectsConfiguration = p_EbxWriter.GetArrayWriter(DialectsConfiguration.GetType(), DialectsConfiguration.Count);
		p_Writer.Write(s_DialectsConfiguration.ArrayIndex);
		foreach (var s_Entry in DialectsConfiguration)
		{
			s_DialectsConfiguration.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultConfidencePolicy));
		p_Writer.WriteNullBytes(4);
	}
}

