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
	[ContainerType(4, 36)]
	public class MaterialGridData : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<MaterialContainerPair> DefaultMaterial { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<MaterialContainerPair>> MaterialPairs { get; set; } = new();

		[ContainerField(20)]
		public List<uint> MaterialIndexMap { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint DefaultMaterialIndex { get; set; }

		[ContainerField(28)]
		public List<MaterialRelationPropertyPair> MaterialProperties { get; set; } = new();

		[ContainerField(32)]
		public List<MaterialInteractionGridRow> InteractionGrid { get; set; } = new();

		public static void Deserialize(MaterialGridData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DefaultMaterial.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MaterialPairs.Clear();
			(RimeReader Reader, uint Count) s_MaterialPairs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MaterialPairs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MaterialContainerPair>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_MaterialPairs.Reader.ReadUInt32()));
				p_Instance.MaterialPairs.Add(s_CtrRef);
			}
			
			s_MaterialPairs.Reader.Dispose();
			p_Instance.MaterialIndexMap.Clear();
			(RimeReader Reader, uint Count) s_MaterialIndexMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MaterialIndexMap.Count; ++i)
			{
				var s_Value = s_MaterialIndexMap.Reader.ReadUInt32();
				p_Instance.MaterialIndexMap.Add(s_Value);
			}
			
			s_MaterialIndexMap.Reader.Dispose();
			p_Instance.DefaultMaterialIndex = p_Reader.ReadUInt32();
			p_Instance.MaterialProperties.Clear();
			(RimeReader Reader, uint Count) s_MaterialProperties = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MaterialProperties.Count; ++i)
			{
				var s_Value = new MaterialRelationPropertyPair();
				fb.MaterialRelationPropertyPair.Deserialize(s_Value, s_MaterialProperties.Reader, p_Parser);
				p_Instance.MaterialProperties.Add(s_Value);
			}
			
			s_MaterialProperties.Reader.Dispose();
			p_Instance.InteractionGrid.Clear();
			(RimeReader Reader, uint Count) s_InteractionGrid = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InteractionGrid.Count; ++i)
			{
				var s_Value = new MaterialInteractionGridRow();
				fb.MaterialInteractionGridRow.Deserialize(s_Value, s_InteractionGrid.Reader, p_Parser);
				p_Instance.InteractionGrid.Add(s_Value);
			}
			
			s_InteractionGrid.Reader.Dispose();
		}

	}
}
