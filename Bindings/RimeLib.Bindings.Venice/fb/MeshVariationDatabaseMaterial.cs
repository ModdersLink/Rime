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
	[ContainerType(4, 12)]
	public class MeshVariationDatabaseMaterial
	{
		[ContainerField(0)]
		public CtrRef<MeshMaterial> Material { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<MeshMaterialVariation> MaterialVariation { get; set; } = new();
		
		[ContainerField(8)]
		public List<TextureShaderParameter> TextureParameters { get; set; } = new();
		
		public static void Deserialize(MeshVariationDatabaseMaterial p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Material.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MaterialVariation.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TextureParameters.Clear();
			(RimeReader Reader, uint Count) s_TextureParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TextureParameters.Count; ++i)
			{
				var s_Value = new TextureShaderParameter();
				fb.TextureShaderParameter.Deserialize(s_Value, s_TextureParameters.Reader, p_Parser);
				p_Instance.TextureParameters.Add(s_Value);
			}
			
			s_TextureParameters.Reader.Dispose();
		}
	}
}
