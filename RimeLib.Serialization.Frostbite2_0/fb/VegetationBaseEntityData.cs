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
	[ContainerType(16, 128)]
	public class VegetationBaseEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public List<LinearTransform> BasePoseTransforms { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public List<Vec3> BasePoseTranslations { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public List<int> Hierarchy { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public CtrRef<SkinnedMeshAsset> Mesh { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public CtrRef<SkinnedMeshAsset> ShadowMesh { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public CtrRef<PhysicsEntityData> PhysicsData { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_BasePoseTransforms = p_EbxWriter.GetArrayWriter(BasePoseTransforms.GetType(), BasePoseTransforms.Count);
			p_Writer.Write(s_BasePoseTransforms.ArrayIndex);
			foreach (var s_Entry in BasePoseTransforms)
			{
				s_Entry.Serialize(s_BasePoseTransforms.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_BasePoseTranslations = p_EbxWriter.GetArrayWriter(BasePoseTranslations.GetType(), BasePoseTranslations.Count);
			p_Writer.Write(s_BasePoseTranslations.ArrayIndex);
			foreach (var s_Entry in BasePoseTranslations)
			{
				s_Entry.Serialize(s_BasePoseTranslations.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_Hierarchy = p_EbxWriter.GetArrayWriter(Hierarchy.GetType(), Hierarchy.Count);
			p_Writer.Write(s_Hierarchy.ArrayIndex);
			foreach (var s_Entry in Hierarchy)
			{
				s_Hierarchy.Writer.Write(s_Entry);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(p_EbxWriter.WriteImport(ShadowMesh));
			p_Writer.Write(p_EbxWriter.WriteImport(PhysicsData));
			p_Writer.WriteNullBytes(8);
		}
	}
}
