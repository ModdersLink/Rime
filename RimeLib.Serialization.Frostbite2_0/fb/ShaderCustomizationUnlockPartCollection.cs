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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class ShaderCustomizationUnlockPartCollection :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<ObjectBlueprint> MeshBlueprints { get; set; } = new();

		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string ShaderNodeName { get; set; } = string.Empty;

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<CustomizedMeshMaterialsData> MeshMaterials { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_MeshBlueprints = p_EbxWriter.GetArrayWriter(MeshBlueprints.GetType(), MeshBlueprints.Count);
			p_Writer.Write(s_MeshBlueprints.ArrayIndex);
			foreach (var s_Entry in MeshBlueprints)
			{
				s_MeshBlueprints.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteString(ShaderNodeName));
			(RimeWriter Writer, uint ArrayIndex) s_MeshMaterials = p_EbxWriter.GetArrayWriter(MeshMaterials.GetType(), MeshMaterials.Count);
			p_Writer.Write(s_MeshMaterials.ArrayIndex);
			foreach (var s_Entry in MeshMaterials)
			{
				s_Entry.Serialize(s_MeshMaterials.Writer, p_EbxWriter);
			}
		}
	}
}
