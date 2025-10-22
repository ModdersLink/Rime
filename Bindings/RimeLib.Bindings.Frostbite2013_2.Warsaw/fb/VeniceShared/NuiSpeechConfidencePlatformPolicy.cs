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

[ContainerType(8, 40)]
public class NuiSpeechConfidencePlatformPolicy
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public GamePlatform Platform { get; set; } = GamePlatform.GamePlatform_Ps3;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<NuiSpeechConfidencePolicy> DefaultPolicy { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<NuiSpeechConfidenceDialectPolicy> DialectPolicies { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Platform);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultPolicy));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_DialectPolicies = p_EbxWriter.GetArrayWriter(DialectPolicies.GetType(), DialectPolicies.Count);
		p_Writer.Write(s_DialectPolicies.ArrayIndex);
		foreach (var s_Entry in DialectPolicies)
		{
			s_DialectPolicies.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

