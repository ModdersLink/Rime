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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class BreakableModelEntityData : 
		GamePhysicsEntityData
	{
		protected CtrRef<SurfaceShaderBaseAsset> m_DecalVolumeShader = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(112), MemberInfoFlag(53), ContainerFieldNameHash(1251902379), ContainerCtrRef]
		public CtrRef<SurfaceShaderBaseAsset> DecalVolumeShader { get { return m_DecalVolumeShader; } set { if (OnPropertyChanging("BreakableModelEntityData." + nameof(DecalVolumeShader), this, m_DecalVolumeShader, value)) m_DecalVolumeShader = value; } } // 0x70 (112)
		
		protected float m_DecalVolumeScaleFactor = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3086740471)]
		public float DecalVolumeScaleFactor { get { return m_DecalVolumeScaleFactor; } set { if (OnPropertyChanging("BreakableModelEntityData." + nameof(DecalVolumeScaleFactor), this, m_DecalVolumeScaleFactor, value)) m_DecalVolumeScaleFactor = value; } } // 0x74 (116)
		
		protected CtrRef<MeshAsset> m_Mesh = new CtrRef<MeshAsset>();
		[ContainerField(120), MemberInfoFlag(53), ContainerFieldNameHash(2088783990), ContainerCtrRef]
		public CtrRef<MeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("BreakableModelEntityData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x78 (120)
		
		protected uint m_BoneCount = new uint();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(939250912)]
		public uint BoneCount { get { return m_BoneCount; } set { if (OnPropertyChanging("BreakableModelEntityData." + nameof(BoneCount), this, m_BoneCount, value)) m_BoneCount = value; } } // 0x7C (124)
		
		protected CtrRef<EdgeModelLightMapData> m_EdgeModelLightMapData = new CtrRef<EdgeModelLightMapData>();
		[ContainerField(128), MemberInfoFlag(53), ContainerFieldNameHash(863288475), ContainerCtrRef]
		public CtrRef<EdgeModelLightMapData> EdgeModelLightMapData { get { return m_EdgeModelLightMapData; } set { if (OnPropertyChanging("BreakableModelEntityData." + nameof(EdgeModelLightMapData), this, m_EdgeModelLightMapData, value)) m_EdgeModelLightMapData = value; } } // 0x80 (128)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1251902379:
					DecalVolumeShader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 3086740471:
					DecalVolumeScaleFactor = (float) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 939250912:
					BoneCount = (uint) p_Value;
					break;

				case 863288475:
					EdgeModelLightMapData = (CtrRef<EdgeModelLightMapData>) p_Value;
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
				case 1251902379:
					return DecalVolumeShader;

				case 3086740471:
					return DecalVolumeScaleFactor;

				case 2088783990:
					return Mesh;

				case 939250912:
					return BoneCount;

				case 863288475:
					return EdgeModelLightMapData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1251902379:
					return typeof(BreakableModelEntityData).GetProperty(nameof(DecalVolumeShader));

				case 3086740471:
					return typeof(BreakableModelEntityData).GetProperty(nameof(DecalVolumeScaleFactor));

				case 2088783990:
					return typeof(BreakableModelEntityData).GetProperty(nameof(Mesh));

				case 939250912:
					return typeof(BreakableModelEntityData).GetProperty(nameof(BoneCount));

				case 863288475:
					return typeof(BreakableModelEntityData).GetProperty(nameof(EdgeModelLightMapData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
