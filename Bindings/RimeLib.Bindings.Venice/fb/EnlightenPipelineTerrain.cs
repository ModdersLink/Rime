///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 16)]
	public class EnlightenPipelineTerrain : 
		Asset
	{
		[ContainerField(12)]
		public List<EnlightenPipelineTerrainMesh> Meshes { get; set; } = new();

		public static void Deserialize(EnlightenPipelineTerrain p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Meshes.Clear();
			(RimeReader Reader, uint Count) s_Meshes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Meshes.Count; ++i)
			{
				var s_Value = new EnlightenPipelineTerrainMesh();
				fb.EnlightenPipelineTerrainMesh.Deserialize(s_Value, s_Meshes.Reader, p_Parser);
				p_Instance.Meshes.Add(s_Value);
			}
			
			s_Meshes.Reader.Dispose();
		}

	}
}
