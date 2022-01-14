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
	[ContainerType(4, 12)]
	public class MeshVariationDatabaseMaterial :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public CtrRef<MeshMaterial> Material { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public CtrRef<MeshMaterialVariation> MaterialVariation { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public List<TextureShaderParameter> TextureParameters { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Material));
			p_Writer.Write(p_EbxWriter.WriteImport(MaterialVariation));
			(RimeWriter Writer, uint ArrayIndex) s_TextureParameters = p_EbxWriter.GetArrayWriter(TextureParameters.GetType(), TextureParameters.Count);
			p_Writer.Write(s_TextureParameters.ArrayIndex);
			foreach (var s_Entry in TextureParameters)
			{
				s_Entry.Serialize(s_TextureParameters.Writer, p_EbxWriter);
			}
		}
	}
}
