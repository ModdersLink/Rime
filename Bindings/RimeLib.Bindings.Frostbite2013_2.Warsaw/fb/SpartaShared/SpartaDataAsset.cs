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

namespace fb.SpartaShared;

[ContainerType(8, 64)]
public class SpartaDataAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public GUID ChunkGuid { get; set; } = GUID.Empty;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<OffsetInfo> Offsets { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint ChunkSize { get; set; } = 0;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string LocalPath { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ChunkGuid.Serialize(p_Writer);
		(RimeWriter Writer, uint ArrayIndex) s_Offsets = p_EbxWriter.GetArrayWriter(Offsets.GetType(), Offsets.Count);
		p_Writer.Write(s_Offsets.ArrayIndex);
		foreach (var s_Entry in Offsets)
		{
			s_Entry.Serialize(s_Offsets.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ChunkSize);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(LocalPath));
	}
}

