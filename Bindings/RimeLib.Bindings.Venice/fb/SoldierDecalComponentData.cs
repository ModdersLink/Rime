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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class SoldierDecalComponentData : 
		ComponentData
	{
		protected CtrRef<DecalTemplateData> m_SplashDecal = new CtrRef<DecalTemplateData>();
		[ContainerField(Name: "SplashDecal", Offset: 96, NameHash: 2194140991, Flags: 53)]
		public CtrRef<DecalTemplateData> SplashDecal { get { return m_SplashDecal; } set { if (OnPropertyChanging("SoldierDecalComponentData." + nameof(SplashDecal), this, m_SplashDecal, value)) m_SplashDecal = value; } } // 0x60 (96)
		
		protected float m_SplashRayLength = new float();
		[ContainerField(Name: "SplashRayLength", Offset: 100, NameHash: 1743765414, Flags: 49469), LayoutImmutable, Blittable]
		public float SplashRayLength { get { return m_SplashRayLength; } set { if (OnPropertyChanging("SoldierDecalComponentData." + nameof(SplashRayLength), this, m_SplashRayLength, value)) m_SplashRayLength = value; } } // 0x64 (100)
		
		protected CtrRef<DecalTemplateData> m_PoolDecal = new CtrRef<DecalTemplateData>();
		[ContainerField(Name: "PoolDecal", Offset: 104, NameHash: 3686889142, Flags: 53)]
		public CtrRef<DecalTemplateData> PoolDecal { get { return m_PoolDecal; } set { if (OnPropertyChanging("SoldierDecalComponentData." + nameof(PoolDecal), this, m_PoolDecal, value)) m_PoolDecal = value; } } // 0x68 (104)
		
		protected float m_PoolRayYOffset = new float();
		[ContainerField(Name: "PoolRayYOffset", Offset: 108, NameHash: 41417415, Flags: 49469), LayoutImmutable, Blittable]
		public float PoolRayYOffset { get { return m_PoolRayYOffset; } set { if (OnPropertyChanging("SoldierDecalComponentData." + nameof(PoolRayYOffset), this, m_PoolRayYOffset, value)) m_PoolRayYOffset = value; } } // 0x6C (108)
		
		protected float m_PoolRayLength = new float();
		[ContainerField(Name: "PoolRayLength", Offset: 112, NameHash: 3617868719, Flags: 49469), LayoutImmutable, Blittable]
		public float PoolRayLength { get { return m_PoolRayLength; } set { if (OnPropertyChanging("SoldierDecalComponentData." + nameof(PoolRayLength), this, m_PoolRayLength, value)) m_PoolRayLength = value; } } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2194140991:
					SplashDecal = (CtrRef<DecalTemplateData>) p_Value;
					break;

				case 1743765414:
					SplashRayLength = (float) p_Value;
					break;

				case 3686889142:
					PoolDecal = (CtrRef<DecalTemplateData>) p_Value;
					break;

				case 41417415:
					PoolRayYOffset = (float) p_Value;
					break;

				case 3617868719:
					PoolRayLength = (float) p_Value;
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
				case 2194140991:
					return SplashDecal;

				case 1743765414:
					return SplashRayLength;

				case 3686889142:
					return PoolDecal;

				case 41417415:
					return PoolRayYOffset;

				case 3617868719:
					return PoolRayLength;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2194140991:
					return typeof(SoldierDecalComponentData).GetProperty(nameof(SplashDecal));

				case 1743765414:
					return typeof(SoldierDecalComponentData).GetProperty(nameof(SplashRayLength));

				case 3686889142:
					return typeof(SoldierDecalComponentData).GetProperty(nameof(PoolDecal));

				case 41417415:
					return typeof(SoldierDecalComponentData).GetProperty(nameof(PoolRayYOffset));

				case 3617868719:
					return typeof(SoldierDecalComponentData).GetProperty(nameof(PoolRayLength));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
