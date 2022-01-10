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
	public class ShaderCustomizationUnlockPartCollection : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<ObjectBlueprint>> MeshBlueprints { get; set; } = new();

		[ContainerField(12), LayoutImmutable]
		public string ShaderNodeName { get; set; } = string.Empty;

		[ContainerField(16)]
		public List<CustomizedMeshMaterialsData> MeshMaterials { get; set; } = new();

		public static void Deserialize(ShaderCustomizationUnlockPartCollection p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MeshBlueprints.Clear();
			(RimeReader Reader, uint Count) s_MeshBlueprints = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MeshBlueprints.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ObjectBlueprint>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_MeshBlueprints.Reader.ReadUInt32()));
				p_Instance.MeshBlueprints.Add(s_CtrRef);
			}
			
			s_MeshBlueprints.Reader.Dispose();
			p_Instance.ShaderNodeName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.MeshMaterials.Clear();
			(RimeReader Reader, uint Count) s_MeshMaterials = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MeshMaterials.Count; ++i)
			{
				var s_Value = new CustomizedMeshMaterialsData();
				fb.CustomizedMeshMaterialsData.Deserialize(s_Value, s_MeshMaterials.Reader, p_Parser);
				p_Instance.MeshMaterials.Add(s_Value);
			}
			
			s_MeshMaterials.Reader.Dispose();
		}

	}
}
