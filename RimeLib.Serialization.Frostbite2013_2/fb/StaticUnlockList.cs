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

[ContainerType(8, 32)]
public class StaticUnlockList
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<BasicUnlockInfo> UnlockInfos { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_UnlockInfos = p_EbxWriter.GetArrayWriter(UnlockInfos.GetType(), UnlockInfos.Count);
		p_Writer.Write(s_UnlockInfos.ArrayIndex);
		foreach (var s_Entry in UnlockInfos)
		{
			s_Entry.Serialize(s_UnlockInfos.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

