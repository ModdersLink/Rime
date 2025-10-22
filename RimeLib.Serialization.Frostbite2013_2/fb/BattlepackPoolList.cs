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

[ContainerType(8, 32)]
public class BattlepackPoolList
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<BattlepackPool> Pools { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Pools = p_EbxWriter.GetArrayWriter(Pools.GetType(), Pools.Count);
		p_Writer.Write(s_Pools.ArrayIndex);
		foreach (var s_Entry in Pools)
		{
			s_Pools.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

