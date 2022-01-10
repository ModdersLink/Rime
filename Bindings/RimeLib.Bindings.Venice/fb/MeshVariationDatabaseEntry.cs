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
	[ContainerType(4, 20)]
	public class MeshVariationDatabaseEntry : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint VariationAssetNameHash { get; set; }

		[ContainerField(16)]
		public List<MeshVariationDatabaseMaterial> Materials { get; set; } = new();

		public static void Deserialize(MeshVariationDatabaseEntry p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.VariationAssetNameHash = p_Reader.ReadUInt32();
			p_Instance.Materials.Clear();
			(RimeReader Reader, uint Count) s_Materials = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Materials.Count; ++i)
			{
				var s_Value = new MeshVariationDatabaseMaterial();
				fb.MeshVariationDatabaseMaterial.Deserialize(s_Value, s_Materials.Reader, p_Parser);
				p_Instance.Materials.Add(s_Value);
			}
			
			s_Materials.Reader.Dispose();
		}

	}
}
