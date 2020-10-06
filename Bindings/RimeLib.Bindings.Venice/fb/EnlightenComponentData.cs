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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(224), ContainerClass]
	public class EnlightenComponentData : 
		ComponentData
	{
		protected Vec3 m_SkyBoxSkyColor = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(573165997)]
		public Vec3 SkyBoxSkyColor { get { return m_SkyBoxSkyColor; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(SkyBoxSkyColor), this, m_SkyBoxSkyColor, value)) m_SkyBoxSkyColor = value; } } // 0x60 (96)
		
		protected Vec3 m_SkyBoxBackLightColor = new Vec3();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(554253337)]
		public Vec3 SkyBoxBackLightColor { get { return m_SkyBoxBackLightColor; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(SkyBoxBackLightColor), this, m_SkyBoxBackLightColor, value)) m_SkyBoxBackLightColor = value; } } // 0x70 (112)
		
		protected Vec3 m_SkyBoxGroundColor = new Vec3();
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2438224137)]
		public Vec3 SkyBoxGroundColor { get { return m_SkyBoxGroundColor; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(SkyBoxGroundColor), this, m_SkyBoxGroundColor, value)) m_SkyBoxGroundColor = value; } } // 0x80 (128)
		
		protected Vec3 m_TerrainColor = new Vec3();
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(87781231)]
		public Vec3 TerrainColor { get { return m_TerrainColor; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(TerrainColor), this, m_TerrainColor, value)) m_TerrainColor = value; } } // 0x90 (144)
		
		protected Vec3 m_SkyBoxSunLightColor = new Vec3();
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2622963034)]
		public Vec3 SkyBoxSunLightColor { get { return m_SkyBoxSunLightColor; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(SkyBoxSunLightColor), this, m_SkyBoxSunLightColor, value)) m_SkyBoxSunLightColor = value; } } // 0xA0 (160)
		
		protected float m_BounceScale = new float();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1158285805)]
		public float BounceScale { get { return m_BounceScale; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(BounceScale), this, m_BounceScale, value)) m_BounceScale = value; } } // 0xB0 (176)
		
		protected float m_CullDistance = new float();
		[ContainerField(180), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1000432400)]
		public float CullDistance { get { return m_CullDistance; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(CullDistance), this, m_CullDistance, value)) m_CullDistance = value; } } // 0xB4 (180)
		
		protected float m_SunScale = new float();
		[ContainerField(184), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2209231701)]
		public float SunScale { get { return m_SunScale; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(SunScale), this, m_SunScale, value)) m_SunScale = value; } } // 0xB8 (184)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(188), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xBC (188)
		
		protected float m_SkyBoxBackLightRotationY = new float();
		[ContainerField(192), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(533859401)]
		public float SkyBoxBackLightRotationY { get { return m_SkyBoxBackLightRotationY; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(SkyBoxBackLightRotationY), this, m_SkyBoxBackLightRotationY, value)) m_SkyBoxBackLightRotationY = value; } } // 0xC0 (192)
		
		protected float m_SkyBoxSunLightColorSize = new float();
		[ContainerField(196), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1176662367)]
		public float SkyBoxSunLightColorSize { get { return m_SkyBoxSunLightColorSize; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(SkyBoxSunLightColorSize), this, m_SkyBoxSunLightColorSize, value)) m_SkyBoxSunLightColorSize = value; } } // 0xC4 (196)
		
		protected float m_SkyBoxBackLightColorSize = new float();
		[ContainerField(200), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3173445660)]
		public float SkyBoxBackLightColorSize { get { return m_SkyBoxBackLightColorSize; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(SkyBoxBackLightColorSize), this, m_SkyBoxBackLightColorSize, value)) m_SkyBoxBackLightColorSize = value; } } // 0xC8 (200)
		
		protected float m_SkyBoxBackLightRotationX = new float();
		[ContainerField(204), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(533859400)]
		public float SkyBoxBackLightRotationX { get { return m_SkyBoxBackLightRotationX; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(SkyBoxBackLightRotationX), this, m_SkyBoxBackLightRotationX, value)) m_SkyBoxBackLightRotationX = value; } } // 0xCC (204)
		
		protected bool m_SkyBoxEnable = new bool();
		[ContainerField(208), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2201282448)]
		public bool SkyBoxEnable { get { return m_SkyBoxEnable; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(SkyBoxEnable), this, m_SkyBoxEnable, value)) m_SkyBoxEnable = value; } } // 0xD0 (208)
		
		protected bool m_Enable = new bool();
		[ContainerField(209), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("EnlightenComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0xD1 (209)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 573165997:
					SkyBoxSkyColor = (Vec3) p_Value;
					break;

				case 554253337:
					SkyBoxBackLightColor = (Vec3) p_Value;
					break;

				case 2438224137:
					SkyBoxGroundColor = (Vec3) p_Value;
					break;

				case 87781231:
					TerrainColor = (Vec3) p_Value;
					break;

				case 2622963034:
					SkyBoxSunLightColor = (Vec3) p_Value;
					break;

				case 1158285805:
					BounceScale = (float) p_Value;
					break;

				case 1000432400:
					CullDistance = (float) p_Value;
					break;

				case 2209231701:
					SunScale = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 533859401:
					SkyBoxBackLightRotationY = (float) p_Value;
					break;

				case 1176662367:
					SkyBoxSunLightColorSize = (float) p_Value;
					break;

				case 3173445660:
					SkyBoxBackLightColorSize = (float) p_Value;
					break;

				case 533859400:
					SkyBoxBackLightRotationX = (float) p_Value;
					break;

				case 2201282448:
					SkyBoxEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 573165997:
					return SkyBoxSkyColor;

				case 554253337:
					return SkyBoxBackLightColor;

				case 2438224137:
					return SkyBoxGroundColor;

				case 87781231:
					return TerrainColor;

				case 2622963034:
					return SkyBoxSunLightColor;

				case 1158285805:
					return BounceScale;

				case 1000432400:
					return CullDistance;

				case 2209231701:
					return SunScale;

				case 229961746:
					return Realm;

				case 533859401:
					return SkyBoxBackLightRotationY;

				case 1176662367:
					return SkyBoxSunLightColorSize;

				case 3173445660:
					return SkyBoxBackLightColorSize;

				case 533859400:
					return SkyBoxBackLightRotationX;

				case 2201282448:
					return SkyBoxEnable;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 573165997:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxSkyColor));

				case 554253337:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxBackLightColor));

				case 2438224137:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxGroundColor));

				case 87781231:
					return typeof(EnlightenComponentData).GetProperty(nameof(TerrainColor));

				case 2622963034:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxSunLightColor));

				case 1158285805:
					return typeof(EnlightenComponentData).GetProperty(nameof(BounceScale));

				case 1000432400:
					return typeof(EnlightenComponentData).GetProperty(nameof(CullDistance));

				case 2209231701:
					return typeof(EnlightenComponentData).GetProperty(nameof(SunScale));

				case 229961746:
					return typeof(EnlightenComponentData).GetProperty(nameof(Realm));

				case 533859401:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxBackLightRotationY));

				case 1176662367:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxSunLightColorSize));

				case 3173445660:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxBackLightColorSize));

				case 533859400:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxBackLightRotationX));

				case 2201282448:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxEnable));

				case 2342790116:
					return typeof(EnlightenComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
