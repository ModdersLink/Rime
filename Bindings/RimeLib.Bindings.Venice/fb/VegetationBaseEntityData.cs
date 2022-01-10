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
	[ContainerType(16, 128)]
	public class VegetationBaseEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<LinearTransform> BasePoseTransforms { get; set; } = new();

		[ContainerField(100)]
		public List<Vec3> BasePoseTranslations { get; set; } = new();

		[ContainerField(104)]
		public List<int> Hierarchy { get; set; } = new();

		[ContainerField(108)]
		public CtrRef<SkinnedMeshAsset> Mesh { get; set; } = new();

		[ContainerField(112)]
		public CtrRef<SkinnedMeshAsset> ShadowMesh { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<PhysicsEntityData> PhysicsData { get; set; } = new();

		public static void Deserialize(VegetationBaseEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BasePoseTransforms.Clear();
			(RimeReader Reader, uint Count) s_BasePoseTransforms = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BasePoseTransforms.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_BasePoseTransforms.Reader, p_Parser);
				p_Instance.BasePoseTransforms.Add(s_Value);
			}
			
			s_BasePoseTransforms.Reader.Dispose();
			p_Instance.BasePoseTranslations.Clear();
			(RimeReader Reader, uint Count) s_BasePoseTranslations = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BasePoseTranslations.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_BasePoseTranslations.Reader, p_Parser);
				p_Instance.BasePoseTranslations.Add(s_Value);
			}
			
			s_BasePoseTranslations.Reader.Dispose();
			p_Instance.Hierarchy.Clear();
			(RimeReader Reader, uint Count) s_Hierarchy = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Hierarchy.Count; ++i)
			{
				var s_Value = s_Hierarchy.Reader.ReadInt32();
				p_Instance.Hierarchy.Add(s_Value);
			}
			
			s_Hierarchy.Reader.Dispose();
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ShadowMesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PhysicsData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
