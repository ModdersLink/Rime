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

using fb.SoldierShared;
using fb.Core;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 40)]
public class StatsCategoryPlayerRoleData
	: fb.VeniceShared.StatsCategoryBaseData
{
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<PlayerRole> Roles { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Roles = p_EbxWriter.GetArrayWriter(Roles.GetType(), Roles.Count);
		p_Writer.Write(s_Roles.ArrayIndex);
		foreach (var s_Entry in Roles)
		{
			s_Roles.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

