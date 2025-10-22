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

namespace fb.Audio;

[ContainerType(8, 40)]
public class SoundAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<SoundScopeData> Scope { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<SoundDataReference> ReferencedData { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Scope));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ReferencedData = p_EbxWriter.GetArrayWriter(ReferencedData.GetType(), ReferencedData.Count);
		p_Writer.Write(s_ReferencedData.ArrayIndex);
		foreach (var s_Entry in ReferencedData)
		{
			s_Entry.Serialize(s_ReferencedData.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

