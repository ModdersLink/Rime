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
	public class MeshVariationDatabaseEntry :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint VariationAssetNameHash { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<MeshVariationDatabaseMaterial> Materials { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(VariationAssetNameHash);
			(RimeWriter Writer, uint ArrayIndex) s_Materials = p_EbxWriter.GetArrayWriter(Materials.GetType(), Materials.Count);
			p_Writer.Write(s_Materials.ArrayIndex);
			foreach (var s_Entry in Materials)
			{
				s_Entry.Serialize(s_Materials.Writer, p_EbxWriter);
			}
		}
	}
}
