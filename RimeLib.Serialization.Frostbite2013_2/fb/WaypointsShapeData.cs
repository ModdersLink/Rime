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

using fb.Entity;
using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 48)]
public class WaypointsShapeData
	: fb.Entity.VectorShapeData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<WaypointData> Waypoints { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Waypoints = p_EbxWriter.GetArrayWriter(Waypoints.GetType(), Waypoints.Count);
		p_Writer.Write(s_Waypoints.ArrayIndex);
		foreach (var s_Entry in Waypoints)
		{
			s_Waypoints.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

