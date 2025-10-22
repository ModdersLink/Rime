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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 48)]
public class GameSplineData
	: fb.Entity.CustomSplineData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<Vec3> Normals { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Normals = p_EbxWriter.GetArrayWriter(Normals.GetType(), Normals.Count);
		p_Writer.Write(s_Normals.ArrayIndex);
		foreach (var s_Entry in Normals)
		{
			s_Entry.Serialize(s_Normals.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

