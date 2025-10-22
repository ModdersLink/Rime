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

namespace fb.Terrain;

[ContainerType(8, 24)]
public class SingleTerrainLayerData
	: fb.Terrain.TerrainLayerData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<TerrainMeshScatteringType> MeshScatteringTypes { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_MeshScatteringTypes = p_EbxWriter.GetArrayWriter(MeshScatteringTypes.GetType(), MeshScatteringTypes.Count);
		p_Writer.Write(s_MeshScatteringTypes.ArrayIndex);
		foreach (var s_Entry in MeshScatteringTypes)
		{
			s_MeshScatteringTypes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

