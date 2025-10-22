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

namespace fb.SoldierShared;

[ContainerType(8, 24)]
public class WeaponStateData1p
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<WeaponMesh1p> WeaponMesh1p { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_WeaponMesh1p = p_EbxWriter.GetArrayWriter(WeaponMesh1p.GetType(), WeaponMesh1p.Count);
		p_Writer.Write(s_WeaponMesh1p.ArrayIndex);
		foreach (var s_Entry in WeaponMesh1p)
		{
			s_Entry.Serialize(s_WeaponMesh1p.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

