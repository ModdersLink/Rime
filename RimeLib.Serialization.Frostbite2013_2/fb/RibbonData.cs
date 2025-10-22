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
using fb.Render;
using fb.Entity;

namespace fb.Terrain;

[ContainerType(8, 72)]
public class RibbonData
	: fb.Terrain.VisualVectorShapeData
{
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<RibbonPointData> RibbonPoints { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_RibbonPoints = p_EbxWriter.GetArrayWriter(RibbonPoints.GetType(), RibbonPoints.Count);
		p_Writer.Write(s_RibbonPoints.ArrayIndex);
		foreach (var s_Entry in RibbonPoints)
		{
			s_Entry.Serialize(s_RibbonPoints.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

