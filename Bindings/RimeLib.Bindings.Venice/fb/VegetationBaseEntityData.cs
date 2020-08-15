///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16)]
	public class VegetationBaseEntityData : 
		GameEntityData
	{
		protected List<LinearTransform> m_BasePoseTransforms = new List<LinearTransform>();
		[ContainerField(96), ContainerFieldNameHash(2949884966)]
		public List<LinearTransform> BasePoseTransforms { get { return m_BasePoseTransforms; } set { if (OnPropertyChanging("VegetationBaseEntityData." + nameof(BasePoseTransforms), this, m_BasePoseTransforms, value)) m_BasePoseTransforms = value; } } // 0x60 (96)
		
		protected List<Vec3> m_BasePoseTranslations = new List<Vec3>();
		[ContainerField(100), ContainerFieldNameHash(3010608801)]
		public List<Vec3> BasePoseTranslations { get { return m_BasePoseTranslations; } set { if (OnPropertyChanging("VegetationBaseEntityData." + nameof(BasePoseTranslations), this, m_BasePoseTranslations, value)) m_BasePoseTranslations = value; } } // 0x64 (100)
		
		protected List<int> m_Hierarchy = new List<int>();
		[ContainerField(104), ContainerFieldNameHash(2981249554)]
		public List<int> Hierarchy { get { return m_Hierarchy; } set { if (OnPropertyChanging("VegetationBaseEntityData." + nameof(Hierarchy), this, m_Hierarchy, value)) m_Hierarchy = value; } } // 0x68 (104)
		
		protected CtrRef<SkinnedMeshAsset> m_Mesh = new CtrRef<SkinnedMeshAsset>();
		[ContainerField(108), ContainerFieldNameHash(2088783990)]
		public CtrRef<SkinnedMeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("VegetationBaseEntityData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x6C (108)
		
		protected CtrRef<SkinnedMeshAsset> m_ShadowMesh = new CtrRef<SkinnedMeshAsset>();
		[ContainerField(112), ContainerFieldNameHash(699932784)]
		public CtrRef<SkinnedMeshAsset> ShadowMesh { get { return m_ShadowMesh; } set { if (OnPropertyChanging("VegetationBaseEntityData." + nameof(ShadowMesh), this, m_ShadowMesh, value)) m_ShadowMesh = value; } } // 0x70 (112)
		
		protected CtrRef<PhysicsEntityData> m_PhysicsData = new CtrRef<PhysicsEntityData>();
		[ContainerField(116), ContainerFieldNameHash(1743842718)]
		public CtrRef<PhysicsEntityData> PhysicsData { get { return m_PhysicsData; } set { if (OnPropertyChanging("VegetationBaseEntityData." + nameof(PhysicsData), this, m_PhysicsData, value)) m_PhysicsData = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2949884966:
					BasePoseTransforms = (List<LinearTransform>) p_Value;
					break;

				case 3010608801:
					BasePoseTranslations = (List<Vec3>) p_Value;
					break;

				case 2981249554:
					Hierarchy = (List<int>) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<SkinnedMeshAsset>) p_Value;
					break;

				case 699932784:
					ShadowMesh = (CtrRef<SkinnedMeshAsset>) p_Value;
					break;

				case 1743842718:
					PhysicsData = (CtrRef<PhysicsEntityData>) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2949884966:
					return BasePoseTransforms;

				case 3010608801:
					return BasePoseTranslations;

				case 2981249554:
					return Hierarchy;

				case 2088783990:
					return Mesh;

				case 699932784:
					return ShadowMesh;

				case 1743842718:
					return PhysicsData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2949884966:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(BasePoseTransforms));

				case 3010608801:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(BasePoseTranslations));

				case 2981249554:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(Hierarchy));

				case 2088783990:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(Mesh));

				case 699932784:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(ShadowMesh));

				case 1743842718:
					return typeof(VegetationBaseEntityData).GetProperty(nameof(PhysicsData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
