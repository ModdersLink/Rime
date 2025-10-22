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

namespace fb.Debris;

[ContainerType(8, 40)]
public class DebrisSystemAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<DebrisHavokInfo> HavokMeshes { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int HavokMeshCount { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_HavokMeshes = p_EbxWriter.GetArrayWriter(HavokMeshes.GetType(), HavokMeshes.Count);
		p_Writer.Write(s_HavokMeshes.ArrayIndex);
		foreach (var s_Entry in HavokMeshes)
		{
			s_Entry.Serialize(s_HavokMeshes.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HavokMeshCount);
		p_Writer.WriteNullBytes(4);
	}
}

